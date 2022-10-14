using System;
using System.Collections.Generic;
using System.Text;

namespace Lab01_04
{
    class Land
    {
        private string location;
        private double price;
        private int square;


        public Land()
        {

        }
        public Land(string Location, double Price, int Square)
        {
            Location = location;
            Price = price;
            Square = square;
        }

        public string location1 { get => location; set => location = value; }
        public double price1 { get => price; set => price = value; }
        public int square1 { get => square; set => square = value; }

        public virtual void Input()
        {
            Console.WriteLine("Nhập tên địa điểm: ");
            location = Console.ReadLine();
            Console.WriteLine("Nhập tên giá bán: ");
            price = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập tên diện tích: ");
            square = int.Parse(Console.ReadLine());

        }

        public virtual void Show()
        {
            Console.Write($"\nĐịa điểm {this.location} Giá bán {this.price} Diện tích {this.square}");
        }
    }

}
