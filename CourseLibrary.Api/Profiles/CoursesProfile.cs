using AutoMapper;
using CourseLibrary.Api.Models;
using CourseLibrary.API.Entities;

namespace CourseLibrary.Api.Profiles
{
    public class CoursesProfile : Profile
    {

        public CoursesProfile()
        {
            CreateMap<Course, CourseDto>(); 
        }
        
    }
}