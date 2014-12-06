using System;
//NTD change the name of the class to general name like 'User' (this app can be manage also by students and some other types of users)
using ShiftSchedule.Domain.Entities.Base;
using System.Collections.Generic;

namespace ShiftSchedule.Domain.Entities
{
    public class Employee : AuditableEntity<long>
    {
        public virtual int EmployeeId { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string Email { get; set; }
        public virtual bool AdminRights { get; set; }

        public List<Team> Teams;

       public Employee()
        {
        }

        public Employee(string firstName, string lastName, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }
       
        public Boolean IsAdmin()
        {
            return AdminRights;
        }
        public string GetFullName()
        {
            return (FirstName + " " + LastName);
        }

        public bool IsValidFirstName()
        {
            if (string.IsNullOrEmpty(FirstName))
                return false;
            return true;
        } 
    }
}