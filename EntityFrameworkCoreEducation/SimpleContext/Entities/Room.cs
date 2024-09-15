using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkCoreEducation.SimpleContext.Entities
{
    public class Room
    {
        [Key]
        public Guid RoomCode { get; set; }
        public string? Name { get; set; }
        public List<Student>? Students { get; set; }
    }
}
