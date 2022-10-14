using System;
using System.Collections.Generic;
using System.Text;

namespace Lab01_04
{
    class House : Land
    {
        private int year;
        private int floor;

        public House()
        {

        }
        public House(string location, double price, int square, int Year, int Floor) : base(location,price,square)
        {
            Year = year;
            Floor = floor;
        }

        public int year1 { get => year; set => year = value; }
        public int floor1 { get => floor; set => floor = value; }

        public override void Input()
        {
            base.Input();
            Console.WriteLine("Nhập năm xây dựng: ");
            year = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số tầng: ");
            floor = int.Parse(Console.ReadLine());
        }

        public override void Show()
        {
            base.Show();
            Console.Write($"Nam xay dung {this.year} So tang {this.floor} \n");
        }
    }
}
