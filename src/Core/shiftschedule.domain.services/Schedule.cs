using System.Collections.Generic;
using ShiftSchedule.Domain.Entities;

namespace ShiftSchedule.Domain.Services
{
    public class Schedule
    {

        private Team team;
        private Shift shift;
        List<Employee> employees { get; set; }

        public Schedule(Shift shift, Team team, List<Employee> employees)
        {
            this.shift = shift;
            this.team = team;
            this.employees = employees;
        }

        public void addEmployee(Employee emp)
        {
            employees.Add(emp);
        }

        public Team Team
        {
            get { return team; }
            set { team = value; }
        }

        public Shift Shift
        {
            get { return shift; }
            set { shift = value; }
        }
    }

   
}
