using AutoMapper;
using FILE_UPLOAD_BASE64_ARCHITECTURE.Data;
using FILE_UPLOAD_BASE64_ARCHITECTURE.DTOs.Blogs;
using FILE_UPLOAD_BASE64_ARCHITECTURE.Models;
using FILE_UPLOAD_BASE64_ARCHITECTURE.Services.Interface;
using Microsoft.EntityFrameworkCore;

namespace FILE_UPLOAD_BASE64_ARCHITECTURE.Services
{
    public class BlogService : IBlogService
    {
        private readonly AppDBContext __context;
        private readonly IMapper _mapper;

        public BlogService(AppDBContext context,
                           IMapper mapper)
        {
            __context = context;
            _mapper = mapper;
            
        }

        public async Task CreateAsync(BlogCreateDTo request)
        {
            using (var ms = new MemoryStream())
            {
                request.UploadImage.CopyTo(ms);
                request.Image = ms.ToArray();
                
            }

            await __context.AddAsync(_mapper.Map<Blog>(request));
            await __context.SaveChangesAsync();



        }


        public async Task<IEnumerable<BlogDTo>> GetAllAsync()
        {
            return _mapper.Map<IEnumerable<BlogDTo>>(await __context.Blogs.AsNoTracking().ToListAsync());
        }
    }
}
