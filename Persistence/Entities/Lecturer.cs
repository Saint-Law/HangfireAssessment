namespace Persistence.Entities;

public class Lecturer: BaseEntity<long>
{
    public string Name { get; set; }
    public string Qualification { get; set; }
    public string Role { get; set; }
    public string Address { get; set; }
    public Gender Gender { get; set; }
}
