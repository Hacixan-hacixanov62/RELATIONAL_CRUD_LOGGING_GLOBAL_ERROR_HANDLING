using FILE_UPLOAD_BASE64_ARCHITECTURE.Data;
using Microsoft.EntityFrameworkCore;


namespace Repositoryy.Data
{
    public class AppDbContext: DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }

    }
}
