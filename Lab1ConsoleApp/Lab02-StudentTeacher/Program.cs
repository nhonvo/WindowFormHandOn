using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise2_StudentTeacher;
namespace Exercise2_StudentTeacher
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> listPersons = inputList();

            // List<Person> listPersons = Init();

            Console.WriteLine("List of peoples:");
            showList(listPersons);

            //LINQ
            //Tim danh sach cac sinh vien thuoc khoa CNTT neu co
            // List<Person> listSVCNTT = (from s in listPersons where (s is Student && (s as Student).Faculty.ToLower() == "cntt") select s).ToList();
            List<Person> listSVCNTT = listPersons.Where(s=> s is Student && (s as Student).Faculty.ToLower() == "cntt" ).ToList();
            if (listSVCNTT.Count == 0)
            {
                Console.WriteLine("\nDanh sach khong co SV CNTT");
            }
            else
            {
                Console.WriteLine("\n=====2.1 DANH SACH SV CNTT=====");
                showList(listSVCNTT);
            }

            // 2.2 Xuat ra ds sv co diem trung binh < 5 va thuoc khoa cntt
            // List<Person> listSvDTB4CNTT = (from s1 in listPersons where (s1 is Student) && (s1 as Student).AverageScore < 5 && (s1 as Student).Faculty.ToLower() == "cntt" select s1).ToList();
            List<Person> listSvDTB4CNTT = listPersons.Where( s => s is Student && (s as Student).AverageScore < 5 && (s as Student).Faculty.ToLower() == "cntt").ToList();
            if (listSvDTB4CNTT.Count == 0)
            {
                Console.WriteLine("Danh sach khong co sv CNTT co diem trung binh < 5");
            }
            else
            {
                Console.Write("=====2.2 DANH SACH SV CNTT CO DIEM TRUNG BINH < 5======");
                showList(listSvDTB4CNTT);
            }

            //2.3 Xuat ra danh sach gv co dia chi chua thong tin "Quan 9" neu co

            List<Person> listq9 = (from t in listPersons where t is Teacher && (t as Teacher).AddressTeacher.ToLower().Contains("quan 9") select t).ToList();
            if (listq9.Count == 0)
            {
                Console.WriteLine("Khong co gv o Quan 9");
            }
            else
            {
                Console.WriteLine("=====DANH SACH GV O QUAN 9=====");
                showList(listq9) ;
            }

            //2.4 tim kiem ma gv: CHN060286
            // List<Person> listSearch = (from st in listPersons where st is Teacher && (st as Teacher).PersonID.ToLower() == "chn060286" select st).ToList();
            // List<Person> listSearch = listPersons.Where(p => p is Teacher && (p as Teacher).PersonID.ToLower() == "chn060286").ToList();
            List<Person> listSearch = listPersons.Where(p => p is Teacher && (p as Teacher).PersonID.ToLower().Contains("chn060286")).ToList();
            if (listSearch.Count == 0)
            {
                Console.WriteLine("Khong tim thay MA GV: CHN060286");
            }
            else
            {
                Console.WriteLine("=====TIM THAY GV=====");
                showList(listSearch);
                
            }
            //2.5 Tim sv co DTB cao nhat va thuoc khoa cntt

            // var dtbMax = (from d in listPersons where d is Student && (d as Student).Faculty.ToLower()=="cntt" select (d as Student).AverageScore).Max();
            // List<Person> listDTBMax = (from s4 in listPersons where s4 is Student && (s4 as Student).AverageScore == dtbMax && (s4 as Student).Faculty.ToLower() == "cntt" select s4).ToList();
            var dtbMax = listPersons.Where(s => s is Student && (s as Student).Faculty.ToLower() == "cntt" ).Select(s =>(s as Student).AverageScore).Max();
            List<Person> listDTBMax = listPersons.Where(p => p is Student && (p as Student).Faculty.ToLower() == "cntt" && (p as Student).AverageScore == dtbMax).ToList();
            if (listDTBMax.Count == 0)
            {
                Console.WriteLine("Khong co sv IT");
            }
            else
            {
                Console.WriteLine("====SV IT CO DIEM TRUNG BINH CAO NHAT====");
                showList(listDTBMax);
            }
        }

        public static List<Person> inputList()
        {
            Console.Write("Enter number of people: ");
            int soluongPerson = Convert.ToInt32(Console.ReadLine());

            List<Person> listPerson = new List<Person>();

            for (int i = 0; i < soluongPerson; i++)
            {
                int chon;
                Console.WriteLine("1: Teacher \t2: Student");
                Console.Write("Options: ");
                chon = Convert.ToInt32(Console.ReadLine());

                if (chon == 1)
                {
                    Teacher t = new Teacher();
                    t.input();
                    listPerson.Add(t);
                }
                else if (chon == 2)
                {
                    Student s = new Student();
                    s.input();
                    listPerson.Add(s);
                }
                else
                {
                    Console.WriteLine("sai");
                    i = i - 1;
                }
            }
            return listPerson;
        }

        public static void showList(List<Person> listPerson)
        {
            foreach (Person ps in listPerson)
            {
                ps.show();
            }
        }

        public static List<Person> Init()
        {
            List<Person> listPS = new List<Person>();

            listPS.Add(new Person("1", "Monkey D Luffy"));
            listPS.Add(new Person("2", "Zorodoro"));
            listPS.Add(new Person("3", "Vinmoke Sanji"));

            listPS.Add(new Student("4","Anh Quan", 6,"CNTT"));
            listPS.Add(new Student("10", "Anh Loc", 4, "cntt"));
            listPS.Add(new Student("5", "Long Nhat",8, "CNXD"));
            listPS.Add(new Student("6", "Van Long",8, "QTKD"));
            
            listPS.Add(new Teacher("7", "Grap","Quan 9"));
            listPS.Add(new Teacher("8", "Drag","Quan 9 HCM"));
            listPS.Add(new Teacher("CHN060286", "Ace","Quan 1"));
           
            return listPS;

        }
    }

        
    }

