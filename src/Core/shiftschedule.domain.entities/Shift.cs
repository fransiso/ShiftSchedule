using System;
using ShiftSchedule.Domain.Entities.Base;

namespace ShiftSchedule.Domain.Entities
{
    internal enum ShiftDesc
    {
        Morning = 0,
        Evening = 1,
        Night = 2
    }

    public class Shift : Entity<int>
    {
        public int ShiftId { get; set; }
        private readonly string Name; //Morning,Evening or other (
        private DayOfWeek Day;
        private TimeSpan Started { get; set; }
        private TimeSpan Ended { get; set; }

        public Shift(string name, DayOfWeek day, TimeSpan started, TimeSpan ended)
        {
            Name = name;
            Day = day;
            Started = started;
            Ended = ended;
        }

        public TimeSpan GetDuration()
        {
            return (Ended.Subtract(Started));
        }

        public override string ToString()
        {
            string output = Name + " Started " + Started.ToString(@"hh\:mm") + "," +
                            " Ended " + Ended.ToString(@"hh\:mm");
            return output;
        }
    }
}