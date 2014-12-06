using System.Collections.Generic;
using ShiftSchedule.Domain.Entities;
using ShiftSchedule.Domain.Entities.Base;
using ShiftSchedule.Domain.Interfaces.Base;

namespace ShiftSchedule.Domain.Interfaces
{
    public interface IShiftRepository : IGenericRepository<Shift>
    {
        //Since IPersonRepository does not define additional methods, this class's body is empty for now.

        //IEnumerable<Employee> GetEmployeesByShiftId(int shiftId);
        //void Save(Shift shift);
    }
}