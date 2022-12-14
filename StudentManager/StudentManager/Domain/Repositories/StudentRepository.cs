using StudentManager.Models;

namespace StudentManager.Domain.Repositories;

public class StudentRepository : GenericRepository<Student>, IStudentRepository
{
    public StudentRepository(StudentDbContext context) : base(context)
    {
    }
}

public interface IStudentRepository : IGenericRepository<Student>{}