using System.Collections.Generic;
using ShiftSchedule.Domain.Entities;
using ShiftSchedule.Domain.Services.Base;

namespace ShiftSchedule.Domain.Services
{
    public interface IEmployeeService : IEntityService<Employee>
    {
        Employee GetById(long Id);
    }
}
