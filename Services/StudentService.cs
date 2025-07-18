

using EFCoreApp.Data;
using EFCoreApp.Model;

namespace EFCoreApp.Services
{
    public class StudentService
    {
        private readonly AppDbContext _context;

        public StudentService()
        {
            _context = new AppDbContext();
        }

        public void AddStudent(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
        }

        public List<Student> GetAllStudents()
        {
            return _context.Students.ToList();
        }

        public Student GetStudentById(int id)
        {
            return _context.Students.Find(id);
        }

        public void UpdateStudent(int id, Student updatedStudent)
        {
            var student = _context.Students.Find(id);
            if (student != null)
            {
                student.Name = updatedStudent.Name;
                student.Email = updatedStudent.Email;
                student.Age = updatedStudent.Age;

                _context.SaveChanges();
            }
        }

        public void DeleteStudent(int id)
        {
            var student = _context.Students.Find(id);
            if (student != null)
            {
                _context.Students.Remove(student);
                _context.SaveChanges();
            }
        }
    }
}
