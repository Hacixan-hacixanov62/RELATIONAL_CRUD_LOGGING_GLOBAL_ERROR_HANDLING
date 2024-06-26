namespace FILE_UPLOAD_BASE64_ARCHITECTURE.Models
{
    public class Blog:BaseEntity
    {
        public string Title { get; set; }
        public string Desc { get; set; }
        public byte[] Image { get; set; }
    }
}
