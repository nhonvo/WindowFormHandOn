namespace Student_Management
{
    public class Student
    {
        public int studentId { get; set; }
        public string? fullName { get; set; }
        public float averageScore { get; set; }
        public string? faculty { get; set; }
        public Student()
        {
        }

        public Student(int studentId, string? fullName, float averageScore, string? faculty)
        {
            this.studentId = studentId;
            this.fullName = fullName;
            this.averageScore = averageScore;
            this.faculty = faculty;
        }
        public Student(Student student)
        {
            student.studentId = studentId;
            student.fullName = fullName;
            student.averageScore = averageScore;
            student.faculty = faculty;
        }

        public virtual void Input()
        {
            Console.WriteLine("Enter student Id: ");
            studentId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter student fullname: ");
            fullName = Console.ReadLine();
            Console.WriteLine("Enter student averageScore: ");
            averageScore = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter student faculty: ");
            faculty = Console.ReadLine();
        }
        public virtual void Output()
        {
            Console.WriteLine(studentId + " " + fullName + " " + faculty + " " + averageScore);
        }
    }
}