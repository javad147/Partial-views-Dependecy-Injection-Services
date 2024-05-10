namespace Task.Models
{
    public class Specialist : BaseEntity
    {
        public string Image { get; set; }
        public string Name { get; set; }
        public int PositionId { get; set; }
        public Position Position { get; set; }
    }
}
