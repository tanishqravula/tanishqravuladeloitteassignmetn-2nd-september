using WebApplication6.Models;

using WebApplication6.Repositories;
using WebApplication6.Models;
namespace WebApplication6.Services
{
    public class StudentService : IStudentService
    {
        public IStudentRepository _repository;
        public StudentService(IStudentRepository repository)
        {
            _repository = repository;
        }
        public void AddStudent(Student student)
        {
            _repository.AddStudent(student);

            
        }

        public List<Student> GetAll()
        {
            return _repository.GetAll();
            
        }

        public Student GetStudentById(int id)
        {
            return _repository.GetStudentById(id);
        }
        public void DeleteStudent(int id) {
            _repository.DeleteStudent(id);
        }
        public void UpdateStudent(Student student) { 
            _repository.UpdateStudent(student);
        }

    }
}
