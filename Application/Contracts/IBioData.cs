namespace Application.Contracts;

public interface IBioData
{
    Task<bool> AddStudent(AddStudentDto model);
}
