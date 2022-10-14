using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2_StudentTeacher
{
    class Person
    {
        protected string personID;
        protected string namePerson;

        public string NamePerson { get => namePerson; set => namePerson = value; }
        public string PersonID { get => personID; set => personID = value; }

        public Person()
        {
            
        }

        public Person(string perID, string namePs)
        {
            personID = perID;
            namePerson = namePs;
        }

        public virtual void input()
        {
            Console.Write("Moi` nhap ID: ");
            PersonID = Console.ReadLine();
            Console.Write("Moi` nhap vao fullname: ");
            NamePerson = Console.ReadLine();
        }

        public virtual void show()
        {
             
            Console.Write("\nID: {0} \tFullname: {1}",PersonID,NamePerson);
            
         
        }

    }
}
