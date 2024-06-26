using FluentValidation;
using Swashbuckle.AspNetCore.Annotations;

namespace FILE_UPLOAD_BASE64_ARCHITECTURE.DTOs.Blogs
{
    public class BlogCreateDTo
    {
        public string Title { get; set; }
        public string  Desc { get; set; }
        [SwaggerSchema(ReadOnly = true)]
        public byte[] Image { get; set; }
        public IFormFile UploadImage { get; set; }
    }


    public class BlogCreateDTOValidator : AbstractValidator<BlogCreateDTo>
    {
        public BlogCreateDTOValidator()
        {
            RuleFor(m => m.Title).NotNull().WithMessage("Title PB-101 is required");
            RuleFor(m => m.Desc).NotEmpty().NotNull();
        }
    }
}
