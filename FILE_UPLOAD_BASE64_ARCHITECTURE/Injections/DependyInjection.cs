using FILE_UPLOAD_BASE64_ARCHITECTURE.DTOs.Blogs;
using FILE_UPLOAD_BASE64_ARCHITECTURE.Helpers;
using FILE_UPLOAD_BASE64_ARCHITECTURE.Services;
using FILE_UPLOAD_BASE64_ARCHITECTURE.Services.Interface;
using FluentValidation;
using FluentValidation.AspNetCore;

namespace FILE_UPLOAD_BASE64_ARCHITECTURE.Injections
{
    public static class DependyInjection
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
           
            services.AddAutoMapper(typeof(MappingProfile).Assembly);

            services.AddFluentValidationAutoValidation(config =>
            {
                config.DisableDataAnnotationsValidation = true;
            });


            //Blog
            services.AddScoped<IBlogService, BlogService>();

            services.AddScoped<IValidator<BlogCreateDTo>, BlogCreateDTOValidator>();

            return services;

        }


    }
}
