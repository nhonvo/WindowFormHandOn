using EXERCISE2_BEEGAME.Models;


BeeList beeList = new BeeList(30);
beeList.CreateList(30);
do
{
    Console.WriteLine("Select option: ");
    Console.WriteLine("1. Create bee list");
    Console.WriteLine("2. Attack bee list");
    Console.WriteLine("0. End program");

    Console.WriteLine("Select: ");
    int option = Convert.ToInt32(Console.ReadLine());
    switch (option)
    {
        case 1:
            beeList.CreateList();
            beeList.OutPut();
            break;
        case 2:
            beeList.Attack();
            beeList.OutPut();
            break;
        case 0:
            return 0;            
        default:
            Console.WriteLine("Invaid Syntax error");
            break;
    }
} while (true);