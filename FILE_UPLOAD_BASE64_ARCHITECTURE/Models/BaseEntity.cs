namespace FILE_UPLOAD_BASE64_ARCHITECTURE.Models
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
    }
}
