namespace Task.Models
{
    public class Position : BaseEntity
    {
        public string Name { get; set; }
        
        public ICollection<Specialist> Specialists { get; set; }
    }
}
