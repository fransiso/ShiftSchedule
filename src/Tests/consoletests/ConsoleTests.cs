using System;
using System.Collections.Generic;
using System.Globalization;
using ShiftSchedule.Domain.Entities;
using ShiftSchedule.Domain.Services;

namespace ShiftSchedule.ConsoleTests
{
    class Program
    {
        static void Main()
        {
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
            string format;
            CultureInfo culture;
            // Parse hour:minute value with "g" specifier current culture.
            format = "g";
            culture = CultureInfo.CurrentCulture;

            Console.WriteLine("Whats up, how many domains you handle?");
            int numOfDomains = Convert.ToInt32(Console.ReadLine());
            List<Team> domains = new List<Team>();
            int shiftsPerDay;
            List<Shift> shifts = new List<Shift>();
            List<Schedule> schedules = new List<Schedule>();
            for (int i = 0; i < numOfDomains; i++)
            {
                Console.WriteLine("Please enter domain {0} is name",i+1);
                string domainName = Console.ReadLine();
                domains.Add(new Team(domainName));
                Console.WriteLine("Please enter how many shift per day for domain: {0} ",domains[i].Name);
                shiftsPerDay = Convert.ToInt32(Console.ReadLine());
                for (int j = 0; j < shiftsPerDay; j++)
                {
                    Console.WriteLine("Please enter when shift {0} started (Fromat HH:MM):", j + 1);
                    string startedShift = Console.ReadLine();
                    Console.WriteLine("Please enter when shift {0} ended (Fromat HH:MM):", j + 1);
                    string endedShift = Console.ReadLine();
                    foreach (DayOfWeek day in Enum.GetValues(typeof(DayOfWeek)))
                    {
                        shifts.Add(new Shift("shift " + (j + 1) + " ", day, TimeSpan.ParseExact(startedShift, format, culture), TimeSpan.ParseExact(endedShift, format, culture)));
                        schedules.Add(new Schedule(shifts[shifts.Count-1], domains[i], new List<Employee>()));
                    }
                }
                
            }

            PrintTable(schedules);
            Console.ReadLine(); //pause
        }

        static void PrintTable(List<Schedule> schedules)
        {
            
            // set the columns in the constructor
            var table = new ConsoleTable("Shift","Team",
                                         DayOfWeek.Sunday.ToString(), 
                                         DayOfWeek.Monday.ToString(), 
                                         DayOfWeek.Thursday.ToString(),
                                         DayOfWeek.Wednesday.ToString(),
                                         DayOfWeek.Thursday.ToString(),
                                         DayOfWeek.Friday.ToString(),
                                         DayOfWeek.Saturday.ToString());

            for (int i = 0; i < schedules.Count; i++)
            {
                if ((i % 7 == 0))
                table.AddRow(schedules[i].Shift, schedules[i].Team, 3, 4, 5, 6, 7, 8, 9);
            }
           
            // spit out the result to Console (uses Console.WriteLine())
            table.Write();
           }
    }
}
