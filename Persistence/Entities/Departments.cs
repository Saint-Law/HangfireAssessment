namespace Persistence.Entities;

public class Departments: BaseEntity<long>
{
    public string Name { get; set; }
    public string Description { get; set; }
}
