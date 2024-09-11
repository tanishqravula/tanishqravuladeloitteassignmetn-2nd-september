using WebApplication6.Models;
using WebApplication6.Repositories;
using Microsoft.EntityFrameworkCore;

namespace WebApplication6.Repositories
{
    public class StudentRepository:IStudentRepository
    {
        public SchoolDbContext _context;
        public StudentRepository(SchoolDbContext context)
        {
            _context = context;
        }

        public void AddStudent(Student studentobj)
        {
            _context.Students.Add(studentobj);
            _context.SaveChanges();
        }

        public List<Student> GetAll()
        {
            List<Student> students = _context.Students.ToList();
            return students;
        }

        public Student GetStudentById(int id)
        {
            Student students = _context.Students.Find(id);
            return students;
        }
        public void UpdateStudent(Student student) { 
            _context.Students.Update(student);
            _context.SaveChanges();

        }
        public void DeleteStudent(int id)
        {

                Student students = _context.Students.Find(id);
                _context.Students.Remove(students);
                _context.SaveChanges();

        }
    }
}
