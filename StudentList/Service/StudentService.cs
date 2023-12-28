using StudentList.Exceptions;
using StudentList.Model;
using StudentList.Repository;

namespace StudentList.Service
{
    
        public class StudentService : IStudentService
        {
            private readonly IStudentRepository _studentRepository;

            public StudentService(IStudentRepository studentRepository)
            {
                _studentRepository = studentRepository;
            }

            public List<Student> GetStudents()
            {
                return _studentRepository.GetStudents();
            }

            public Student GetStudentById(int id)
            {
                return _studentRepository.GetStudentById(id);
            }

            public List<Student> GetStudentsByName(string name)
            {
                return _studentRepository.GetStudentsByName(name);
            }

            public void AddStudent(Student student)
            {
                _studentRepository.AddStudent(student);
            }

            public bool UpdateStudent(int id, Student student)
            {
                if (_studentRepository.UpdateStudent(id, student))
                {
                    return true;
                }

                throw new StudentNotFoundException($"Student with ID {id} not found");
            }

            public bool DeleteStudent(int id)
            {
                if (_studentRepository.DeleteStudent(id))
                {
                    return true;
                }

                throw new StudentNotFoundException($"Student with ID {id} not found");
            }
        }
}
