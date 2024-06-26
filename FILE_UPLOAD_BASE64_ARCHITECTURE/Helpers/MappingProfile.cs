using AutoMapper;
using FILE_UPLOAD_BASE64_ARCHITECTURE.DTOs.Blogs;
using FILE_UPLOAD_BASE64_ARCHITECTURE.Models;
using System.Runtime.CompilerServices;

namespace FILE_UPLOAD_BASE64_ARCHITECTURE.Helpers
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            //Blog
            CreateMap<BlogCreateDTo, Blog>();
            CreateMap<Blog, BlogDTo>().ForMember(dest => dest.Image, opt => opt.MapFrom(src =>Convert.ToBase64String(src.Image)));

        }
    }
}
