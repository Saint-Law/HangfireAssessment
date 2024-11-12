namespace Persistence.Entities;

public class Result: BaseEntity<Guid>
{
    public string Grade { get; set; }
    public Single Score { get; set; }
    public long StudentId { get; set; }
}
