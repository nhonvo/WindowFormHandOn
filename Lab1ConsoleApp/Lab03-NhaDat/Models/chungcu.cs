using System;
using System.Collections.Generic;
using System.Text;

namespace Lab01_04
{
    class Apartment : Land
    {
        private int floor;

        public Apartment()
        {

        }

        public Apartment(int Floor, string location, double price, int square) : base( location, price, square)
        {
            Floor = floor;
        }

        public int floor1 { get => floor; set => floor = value; }

        public override void Input()
        {
            base.Input();
            Console.WriteLine("Nhập số tầng: ");
            floor = int.Parse(Console.ReadLine());
        }

        public override void Show()
        {
            base.Show();
            Console.Write($" Số Tầng: {this.floor}");
        }
    }
}
