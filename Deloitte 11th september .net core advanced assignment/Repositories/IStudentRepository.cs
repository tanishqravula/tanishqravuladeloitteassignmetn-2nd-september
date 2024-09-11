using WebApplication6.Models;
namespace WebApplication6.Repositories
{
    public interface IStudentRepository
    {
        List<Student> GetAll();
        Student GetStudentById(int id);
        void AddStudent(Student studentobj);
        void UpdateStudent(Student studentobj);
        void DeleteStudent(int id);

    }
}
