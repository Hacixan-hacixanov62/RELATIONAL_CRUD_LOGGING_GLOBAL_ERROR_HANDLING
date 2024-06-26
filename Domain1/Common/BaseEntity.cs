namespace Domain1.Common
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public bool SoftDelete { get; set; }
        public DateTime CreateDate { get; set; }
    }

}
