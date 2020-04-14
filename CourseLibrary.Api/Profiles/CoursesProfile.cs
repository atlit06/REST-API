using AutoMapper;
using CourseLibrary.Api.Models;
using CourseLibrary.Api.Entities;

namespace CourseLibrary.Api.Profiles
{
    public class CoursesProfile : Profile
    {

        public CoursesProfile()
        {
            CreateMap<Entities.Course, Models.CourseDto>();
            CreateMap<Models.CourseForCreationDto, Course>(); 
        }
        
    }
}