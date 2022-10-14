namespace Student_Management
{
    public class ListStudent
    {
        public List<Student> list = new List<Student>();
        public int count = 0;
        public ListStudent(int count)
        {
            this.count = count;
        }
        public void CreateListStudent(int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("--{0}.Student Information--", (i + 1));
                Student student = new Student();
                student.Input();
                list.Add(student);
            }
        }
        public void OutputStudent()
        {
            foreach (var item in list)
            {
                Console.WriteLine("Student Information");
                item.Output();
            }
        }
        public void AddStudent(Student student)
        {
            list.Add(student);
        }
        public List<Student> ITFaculity(List<Student> lst)
        {
            List<Student> lstCNTT = (from s in lst
                                     where s.faculty.ToLower() == "CNTT" || s.faculty == "cntt"
                                     select s).ToList();
            return lstCNTT;
        }

    }
}