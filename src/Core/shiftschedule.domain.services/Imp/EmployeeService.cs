using ShiftSchedule.Domain.Entities;
using ShiftSchedule.Domain.Interfaces;
using ShiftSchedule.Domain.Services.Base;

namespace ShiftSchedule.Domain.Services
{
    public class EmployeeService :  EntityService<Employee>, IEmployeeService
    {
        IUnitOfWork _unitOfWork;
        IEmployeeRepository _repository;

        public EmployeeService(IUnitOfWork unitOfWork, IEmployeeRepository repository)
            : base(unitOfWork, repository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
        }

         public Employee GetById(long Id) {
             return _repository.GetById(Id);
        }
        
    }
}
