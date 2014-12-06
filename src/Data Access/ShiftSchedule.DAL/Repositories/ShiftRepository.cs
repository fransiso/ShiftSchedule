using System.Collections.Generic;
using System.Data.Entity;
using ShiftSchedule.Domain.Entities;
using ShiftSchedule.Domain.Interfaces;


namespace ShiftSchedule.DAL
{
    public class ShiftRepositoryBase : EfRepositoryBase<Shift>, IShiftRepository
    {
        public ShiftRepositoryBase(DbContext context)
            : base(context)
        {
        }

        public IEnumerable<Employee> GetEmployeesByShiftId(int shiftId)
        {
            throw new System.NotImplementedException();
        }

        public void Save(Shift shift)
        {
            throw new System.NotImplementedException();
        }

        public Shift Get(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
