using StudentList.Exceptions;
using StudentList.Model;

namespace StudentList.Repository
{
  
        public class StudentRepository : IStudentRepository
        {
            private static List<Student> students = new List<Student>()
        {
            new Student { StudentId = 1, StudentName = "John Doe", Age = 20, Course = "Computer Science" },
            new Student { StudentId = 2, StudentName = "Jane Smith", Age = 22, Course = "Electrical Engineering" },
            new Student { StudentId = 3, StudentName = "Bob Johnson", Age = 21, Course = "Mechanical Engineering" },
        };

            private static int nextStudentId = 4;

            public List<Student> GetStudents()
            {
                return students;
            }

            public Student GetStudentById(int id)
            {
                var student = students.FirstOrDefault(x => x.StudentId == id);
                if (student != null)
                    return student;

                throw new InvalidOperationException($"Student with ID {id} not found");
            }

            public List<Student> GetStudentsByName(string name)
            {
                return students
                    .Where(x => x.StudentName.Contains(name, StringComparison.OrdinalIgnoreCase))
                    .ToList();
            }

            public void AddStudent(Student student)
            {
                student.StudentId = nextStudentId++;
                students.Add(student);
            }

            public bool UpdateStudent(int id, Student student)
            {
                var currentStudent = students.FirstOrDefault(x => x.StudentId == id);
                if (currentStudent != null)
                {
                    currentStudent.StudentName = student.StudentName;
                    currentStudent.Age = student.Age;
                    currentStudent.Course = student.Course;
                    return true;
                }

                return false;
            }

            public bool DeleteStudent(int id)
            {
                var student = students.Find(x => x.StudentId == id);
                if (student != null)
                {
                    students.Remove(student);
                    return true;
                }

                return false;
            }
        }
    }
