using System.Data.Entity;
using ShiftSchedule.Domain.Entities;
using ShiftSchedule.Domain.Interfaces;

namespace ShiftSchedule.DAL.Repositories
{
    public class EmployeeRepository : EfRepositoryBase<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(DbContext context)
            : base(context)
        {
        }

        public Employee GetById(long id)
        {
            return _dbset.Find(id);
        }
    }
}
