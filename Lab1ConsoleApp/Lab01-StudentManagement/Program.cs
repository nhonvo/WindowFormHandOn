using System.Text;
using Student_Management;


// for vietnamese
Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;


// Exercise 1A
/*
Console.Write("Enter number of students: \n");
int number = Convert.ToInt32(Console.ReadLine());

Student[] student = new Student[number];

Console.Write("--Enter List of students infromation: ");
for (int i = 0; i < number; i++)
{
    Console.Write("Student "+i);
    student[i] = new Student();
    student[i].Input();
}
Console.Write("--List of studnets infromation: \n");
for (int i = 0; i < number; i++)
{
    Console.Write("Student "+i);
    student[i].Output();
}

*/
// Exercise 1B
List<Student> lst = new List<Student>();

lst.Add(new Student(1, "Anh Quan", 8, "CNTT"));
lst.Add(new Student(2, "Anh Tuan", 9, "cntt"));
lst.Add(new Student(3, "Phu Loc", 10, "CNTT"));
lst.Add(new Student(4, "Hai Duong", 8, "cntt"));
lst.Add(new Student(5, "Long Nhat", 10, "NNA"));
lst.Add(new Student(6, "Anh Tu", 10, "QTKD"));


Console.WriteLine("\t======DANH SACH VUA NHAP=====");
Output(lst); // xuat danh sach Sv



//truy van xuat ra sv thuoc khoa CNTT
// List<Student> lstCNTT = (from s in lst
//                                   where s.faculty.ToLower() == "CNTT" || s.faculty == "cntt"
//                                   select s).ToList();

List<Student> lstCNTT = lst.Where(s => s.faculty.ToLower() == "CNTT" || s.faculty == "cntt").ToList();
 
//xuat thong tin sv thuoc khoa CNTT
if (lstCNTT.Count() == 0)
{
    Console.WriteLine("Khong co sv thuoc khoa CNTT");
}

else
{
    Console.WriteLine("\t=====XUAT THONG TIN SV THUOC KHOA CNTT=====");
    Output(lstCNTT);
}

//truy van xuat ra sv co diem trung binh lon hon 5
// List<Student> lstDTB5 = (from s1 in lst
//                                   where s1.averageScore >= 5
//                                   select s1).ToList();

List<Student> lstDTB5 = lst.Where(s => s.averageScore >= 5).ToList();

//xuat thong tin sv
if (lstDTB5.Count() == 0)
{
    Console.WriteLine("Khong co sv nao co diem trung binh >=5");
}
else
{
    Console.WriteLine("\t======XUAT THONG TIN SV CO DIEM TRUNG BINH >=5 =====");
    Output(lstDTB5);
}

//truy van xuat ra thong tin sv sap xep theo DTB tang dan`
// List<Student> lstTD = (from s2 in lst
//                                 orderby s2.averageScore
//                                 select s2
//                                 ).ToList();

List<Student> lstTD = lst.OrderBy(x=>x.averageScore).ToList();
//xuat thong tin sv
if (lstTD.Count() == 0)
{
    Console.WriteLine("Danh sach SV trong");
}
else
{
    Console.WriteLine("\t=====XUAT THONG TIN SV THEO DIEM TRUNG BINH TANG DAN=====");
    Output(lstTD);
}

//truy van xuat ra sv co DTB >=5  va thuoc khoa CNTT
// List<Student> lstCNTTDTB5 = (from s3 in lst
//                                       where s3.averageScore >= 5 && (s3.faculty == "CNTT" || s3.faculty == "cntt")
//                                       select s3).ToList();
List<Student> lstCNTTDTB5 = lst.Where(x=>x.averageScore >= 5 && (x.faculty == "CNTT" || x.faculty == "cntt")).ToList();
//xuat thong tin sv
if (lstCNTTDTB5.Count() == 0)
{
    Console.WriteLine("KHONG CO SV CO DIEM TRUNG BINH >=5 VA THUOC KHOA CNTT");
}
else
{
    Console.WriteLine("\t=====XUAT THONG TIN SV CO DIEM TRUNG BINH>=5 & KHOA CNTT");
    Output(lstCNTTDTB5);
}

//truy van xuat ra sv co diem trung binh cao nhat va thuoc khoa CNTT
// var dtbMax = (from s4 in lst where s4.faculty.ToLower() == "cntt" select s4.averageScore).Max();
// List<Student> lstScoreMaxCNTT = (from s5 in lst where s5.averageScore == dtbMax && (s5.faculty == "CNTT" || s5.faculty == "cntt") select s5).ToList();

var dtbMax = lst.Where(x => x.faculty.ToLower() == "cntt").Select(x => x.averageScore).Max();
List<Student> lstScoreMaxCNTT = lst.Where(x => x.averageScore == dtbMax && (x.faculty == "CNTT" || x.faculty == "cntt")).ToList();

if ((lstScoreMaxCNTT.Count == 0))
{
    Console.WriteLine("Khong co SV CNTT");
}
else
{
    Console.WriteLine("\t=====XUAT THONG TIN SV CO DIEM TRUNG BINH CAO NHAT && KHOA CNTT");
    Output(lstScoreMaxCNTT);
}

static void Output(List<Student> lst) //phuong thuc xuat sv
{
    foreach (Student sv in lst)
    {
        sv.Output(); 
    }
}
