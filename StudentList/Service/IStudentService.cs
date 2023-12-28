using StudentList.Model;

namespace StudentList.Service
{
    public interface IStudentService
    {
        List<Student> GetStudents();
        Student GetStudentById(int id);
        List<Student> GetStudentsByName(string name);
        void AddStudent(Student student);
        bool UpdateStudent(int id, Student student);
        bool DeleteStudent(int id);
    }
}
