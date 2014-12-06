using AutoMapper;
using ShiftSchedule.Domain.Entities;
using ShiftSchedule.UI.MVC.ViewModels;

namespace ShiftSchedule.UI.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<EmployeeViewModel, Employee>();
           
        }
    }
    
}