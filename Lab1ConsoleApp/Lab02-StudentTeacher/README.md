```c#
List<Person> listSVCNTT = listPersons.Where(s => s.Faculty.ToLower() == "cntt").ToList();
List<Person> listSvDTB4CNTT = listPersons.Where(s => s.AverageScore < 5).ToList();
List<Person> listq9 = listPersons.Where(s => s.AddressTeacher.ToLower().Contains("quan 9").ToList();
List<Person> listSearch = listPerson.Where(s=>s.PersonID.ToUpper() == "CHN060286").ToList();
List<Person> dbtMax = listPerson.Where(s => s.AverageScore.Max());
```
// 5 query

a(a1)
b(a1,c1)
c(c1)
b.Where()