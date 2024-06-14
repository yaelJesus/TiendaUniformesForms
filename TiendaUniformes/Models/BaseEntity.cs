namespace TiendaUniformes.Models
{
    public class BaseEntity
    {
        public bool isActive { get; set; }
        public int createUser { get; set; }
        public DateOnly createDate { get; set; }
        public int? modifyUser { get; set; }
        public DateOnly? modifyDate { get; set; }
    }
}
