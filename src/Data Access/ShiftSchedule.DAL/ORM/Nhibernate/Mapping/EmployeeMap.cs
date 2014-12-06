using FluentNHibernate.Mapping;
using ShiftSchedule.Domain.Entities;

namespace ShiftSchedule.DAL.ORM.Nhibernate.Mapping
{
    class EmployeeMap : ClassMap<Employee>
    {

        public EmployeeMap()
        {
            Table("User");
            Id(x => x.EmployeeId).Column("UserId");
            Map(x => x.FirstName);
            Map(x => x.LastName);
            Map(x => x.Email);
            Map(x => x.AdminRights);
        }
    }
}
