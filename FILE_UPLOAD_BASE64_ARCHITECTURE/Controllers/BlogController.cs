using FILE_UPLOAD_BASE64_ARCHITECTURE.DTOs.Blogs;
using FILE_UPLOAD_BASE64_ARCHITECTURE.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FILE_UPLOAD_BASE64_ARCHITECTURE.Controllers
{
    [Route("api/admin/[controller]/[action]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly IBlogService _blogService;

        public BlogController(IBlogService blogService)
        {
            _blogService = blogService;
           
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _blogService.GetAllAsync());

        }

        [HttpPost]
        public async Task<IActionResult> Create([FromForm] BlogCreateDTo request)
        {
            await _blogService.CreateAsync(request);

            return CreatedAtAction(nameof(Create), request);
        }

    }
}
