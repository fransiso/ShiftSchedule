namespace ShiftSchedule.Domain.Entities
{
    public class Team
    {
        //NOC,Support,...
        public int TeamId { get; set; } //NOTE maybe its value object so we dont need identity (and will be moved to Domain Services scope)
        public Team(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}