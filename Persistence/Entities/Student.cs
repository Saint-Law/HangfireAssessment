namespace Persistence.Entities;

public class Student: BaseEntity<long>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Gender Gender { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string LGA { get; set; }
}
