## Cấu trúc chương trình


```c#
namespace HelloWorld
{
    namespace Nested_Namespace
    {
        class ClassName{
            // method
            static void Main(string[] args)
            {
                Console.WriteLine("Hello World");
            }
        }
    }
    class Program
    {
        // method
    }
    // class
}
```

## Kiểu dữ liệu trong C#

1. Kiểu dữ liệu dựng sẳn
sbyte, byte, short, ushort, int, uint, long, ulong, char, string, bool, decimal, float, double
2. Kiểu dữ liệu người dùng định nghĩa   

1.  kiểu dữ liệu giá Trị
1.  kiểu dữ liệu tham chiếu

### Khai báo kiểu dữ liệu

```c#
int a = 1;
float b = 1.5f;
string c = "Hello World";
bool d = true;

```

### Cấu trúc câu lệnh điều khiển

```c#
// if statements
void displayCharacter(char character)
{
    if (character == ' ')
    {
        Console.Write($"space : {character}");
    }
    else if (character == '\n')
    {
        Console.Write($"newline : {character}");
    }
    else if (character == '\t')
    {
        Console.Write($"tab : {character}");
    }
    else
    {
        Console.Write(character);
    }

}
// switch case
switch (character)
{
    case ' ':
        Console.Write($"space : {character}");
        break;
    case '\n':
        Console.Write($"newline : {character}");
        break;
    case '\t':
        Console.Write($"tab : {character}");
        break;
    default:
        Console.Write(character);
        break;
}
```
### LOOP - Vòng lặp
```C#
// for loop:  
while (i < 10)
{
    Console.WriteLine(i);
    i++;
}
// do while loop
do
{
    Console.WriteLine(i);
    i++;
} while (i < 10);
// for each loop
foreach (char character in c)
{
    displayCharacter(character);
}
// for loop
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}
```
### toán tử
```C#
/** 

// số học 
+, -, *, /, %, ++, --, +=, -=, *=, /=, %=

// logic
&&, ||, !, &, |, ^, ~

// quan hệ
==, !=, >, <, >=, <=

// ba ngôi
max = a > b ? a : b;
*/

//Chuyển đổi kiểu dữ liệu 
// parse
int a = int.Parse("1");
float b = float.Parse("1.5");
string c = "1.5";
float d = float.Parse(c);

// try base
float b = tryParse("1.5", out b);
// convert
int a = convert.ToInt32("1");
// casting
float b = 5.5f;
int a = (int)b;
```


### Mảng - array
```C#
int[] a = new int[10];
int[] b = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

// write input array function
void inputArray(int[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        a[i] = int.Parse(Console.ReadLine()); 
    }
}
// write output array function
void writeArray(int[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        Console.WriteLine(a[i]);
    }
}
int [,] diem = new int[2,3] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
// write input array 2 dismention function
void inputArray(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            a[i, j] = int.Parse(Console.ReadLine());
        }
    }
}
// write output array 2 dismention function
void writeArray(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            Console.WriteLine(a[i, j]);
        }
    }
}
// output: 1 2 3 4 5 6
```

# Lớp và giao diện

## Xây dựng lớp
```c#
// Access Modifiers private, public, protected, internal
// static, virtual, override, abstract, sealed
// new, sealed, base, this, base.method()
// constructor, destructor, method, property, event, indexer, operator, enum, interface, struct
// using, namespace, using static, using namespace
// class, interface, struct, enum, delegate, delegate void, delegate int, delegate string, delegate bool, delegate float, delegate double

class Sinhvien{
    private String name;
    public static String HelloWorld()
    {
        return $"Hello World: {character}";
        // return "Hello World: " + character;
    }
    public String Name{
        get{
            return name;
        }
        set{
            name = value;
        }
    }

    public Sinhvien(){
        // constructor
        name = "Program";
    }
    public Sinhvien(String name){
        this.name = name;
    }
    public Sinhvien(Sinhvien sv){
        name = sv.name;
    }
    public void display(){
        Console.WriteLine(name);
    }

    static void Main(string[] args)
    {
        // code
        Sinhvien sv = new Sinhvien();
        Sinhvien sv2 = new Sinhvien("Nguyen Van A", "123456789");
    }
}
```

# Tính kế thừa - đa hình - giao diện
## Tính kế thừa
```c#
// inheritance
class A{
    public void display(){
        Console.WriteLine("A");
    }
}
class A : class B{
    // code
}

// Lớp cơ sở
class pointA{
    public int x;
    public int y;
    public pointA(int x, int y){
        this.x = x;
        this.y = y;
    }
    public void display(){
        Console.WriteLine($"x: {x}, y: {y}");
    }
}
// Lớp con
class pointB : pointA{
    public int z;
    public pointB(int x, int y, int z) : base(x, y){
        this.z = z;
    }
    public void display(){
        Console.WriteLine($"x: {x}, y: {y}, z: {z}");
    }
}
public static void Main(string[] args)
{
    // code
    pointA p1 = new pointA(1, 2);
    p1.display();

    pointB pb = new pointB(1, 2, 3);
    pb.display();
    
    Console.ReadLine();
}
```
## Tính đa hình
- Đánh đấu phương thức ảo bằng vitural
- Các lớp dẫn xuất định nghĩa lại phương thức ảo bằng override
```c#
// polymorphism
class ship{
    public virtual void display(){
        Console.WriteLine("ship");
    }
}
class ship: Warship{
    public override void display(){
        Console.WriteLine("Warship");
    }
}
class ship: submarine{
    public override void display(){
        Console.WriteLine("submarine");
    }
}
public static void Main(string[] args)
{
    // code
    ship s = new ship();
    ship s1 = new submarine();
    ship s2 = new warship();
    s.display();
    s1.display();
    s2.display();

}
```

## Lớp trừu tượng 
- có từ khoá abstract trước class
```c#
abstract class ship{
}
class ship: Warship{
    public  void display(){
        Console.WriteLine("Warship");
    }
}
class ship: submarine{
    public  void display(){
        Console.WriteLine("submarine");
    }
}
```

## Lớp niêm phong
```C#
sealed class ship{
    public void display(){
        Console.WriteLine("ship");
    }
}
```

## Lớp trong lớp
- internal

## Lớp giao diện - interface

```c#
// interface
public interface bankAcount{
    void sendMoney(decimal money);
    void getMoney(decimal money);
    decimal soTien(){
        get;
    };

}
public class saveBankAccount : bankAcount{
    private decimal money;
    private decimal balance;
    demical balance{
        get{
            return money;
        }
        set{
            money = value;
        }
    }
    public saveBankAccount(decimal money){
        this.money = money;
    }
    public void sendMoney(decimal money){
        this.money += money;
    }
    public void getMoney(decimal money){
        if (balance >= money){
            balance -= money;
            console.writeLine("Thanh cong");
        }
        else
        {
            console.writeLine("That bai");
            return false;            
        }
    }
    public decimal soTien(){
        return money;
    }
}
public static void Main(string[] args)
{
    // code
    saveBankAccount sb = new saveBankAccount(100000);
    sb.sendMoney(100000);
    sb.getMoney(100000);
    Console.WriteLine(sb.soTien());
    Console.ReadLine();
}

```

# Delegate & event 

Delegate: truyền thông tin qua các form (phân quyền)

# Linq tutorial

