using AutoMapper;
using ShiftSchedule.Domain.Entities;
using ShiftSchedule.UI.MVC.ViewModels;

namespace ShiftSchedule.UI.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<Employee, EmployeeViewModel>();
        }
    }
}