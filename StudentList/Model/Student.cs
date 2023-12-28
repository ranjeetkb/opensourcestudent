namespace StudentList.Model
{
    public class Student
    {
        [Required]
        public int StudentId { get; set; }
        [Required]
        public string StudentName { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string Course { get; set; }
    }
}
