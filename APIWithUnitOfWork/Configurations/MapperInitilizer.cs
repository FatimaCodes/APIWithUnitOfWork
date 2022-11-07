using APIWithUnitOfWork.Data;
using APIWithUnitOfWork.Models;
using AutoMapper;

namespace APIWithUnitOfWork.Configurations
{
    public class MapperInitilizer : Profile
    {
        public MapperInitilizer()
        {
            CreateMap<Country, CountryDTO>().ReverseMap();
            CreateMap<Country, CreateCountryDTO>().ReverseMap();
            CreateMap<Category, CategoryDTO>().ReverseMap();
            CreateMap<Category, CreateCategoryDTO>().ReverseMap();
            CreateMap<Doctor, DoctorDTO>().ReverseMap();
            CreateMap<Doctor, CreateDoctorDTO>().ReverseMap();
            CreateMap<ApiUser, UserDTO>().ReverseMap();

        }
    }
}