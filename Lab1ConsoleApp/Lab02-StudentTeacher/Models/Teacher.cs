using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2_StudentTeacher
//namespace Lab01
{
    class Teacher : Person
    {
        private string addressTeacher;
        public string AddressTeacher { get => addressTeacher; set => addressTeacher = value; }

        public Teacher() : base ()
        {

        }

        public Teacher(string perID, string namePs, string AddressTeacher) : base (perID, namePs)
        {
            addressTeacher = AddressTeacher;
        }

        public override void input()
        {
            base.input();
            Console.Write("Moi` nhap vao` address Teacher: ");
            AddressTeacher = Console.ReadLine();
        }

        public override void show()
        {
            base.show();
            Console.Write("\tAddress Teacher: {0}\n", this.AddressTeacher);
        }
    }
}
