using API.DAL.DataEntity;
using API.Model;
using AutoMapper;
using Microsoft.Extensions.Logging;

namespace API.WEB
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<Employee, EmployeeDTO>().ReverseMap();
        }
    }
}
