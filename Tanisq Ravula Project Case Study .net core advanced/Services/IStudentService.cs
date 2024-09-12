using WebApplication6.Models;
namespace WebApplication6.Services
{
    public interface IStudentService
    {
        List<Student> GetAll();
        Student GetStudentById(int id);
        void AddStudent(Student student);
        void UpdateStudent(Student studentobj);
        void DeleteStudent(int id);
    }
}
