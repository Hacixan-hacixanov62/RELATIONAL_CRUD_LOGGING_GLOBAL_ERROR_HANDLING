using FILE_UPLOAD_BASE64_ARCHITECTURE.DTOs.Blogs;
using System.Collections;

namespace FILE_UPLOAD_BASE64_ARCHITECTURE.Services.Interface
{
    public interface IBlogService
    {
        Task CreateAsync(BlogCreateDTo request);
        Task<IEnumerable<BlogDTo>> GetAllAsync();

    }
}
