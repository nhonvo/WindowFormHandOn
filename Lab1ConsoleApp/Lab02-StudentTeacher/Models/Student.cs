using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2_StudentTeacher
{
    class Student: Person
    {
        private float averageScore; // khai bao diem trung binh
        private string faculty; // khai bai khoa
        public float AverageScore { get => averageScore; set => averageScore = value; } // goi phuong thuc get set
        public string Faculty { get => faculty; set => faculty = value; } // goi phuong thuc get set

        public Student() : base () // contructor khoi tao
        {

        }

        public Student(string perID, string namePs, float score, string faculty) : base (perID,namePs) // contructor co tham so
        {
            AverageScore = score;
            Faculty = faculty;
        }

        public override void input()
        {
            base.input();
            Console.Write("\tMoi` nhap diem trung binh: ");
                AverageScore = float.Parse(Console.ReadLine());
                  Console.Write("\tMoi` nhap khoa: ");
                   Faculty = Console.ReadLine();

        }

        public override void show()
        {
            base.show(); 
            Console.WriteLine("\tDiem trung binh: {0} \tKhoa: {1}", this.AverageScore, this.Faculty);
        }    
    }
}
