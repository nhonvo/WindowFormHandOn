using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Lab01_04;

namespace Lab01_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.WriteLine("------ Danh Sách Nhà ------");
            List<Land> ListHouse = NhapNha();
            XuatNha(ListHouse);
            Tongprice(ListHouse);
            ListLand(ListHouse);
            TimkiemNha(ListHouse);
        }

        private static bool KiemTra(Land i, String diaChicantim, double pricecantim, int dienTichcantim)
        {
            if (i.location1.ToLower().StartsWith(diaChicantim.ToLower()) && i.price1 <= pricecantim && i.square1 >= dienTichcantim)
                return true;
            return false;
        }
        private static void TimkiemNha(List<Land> listHouse)
        {
            String location;
            double price; 
            int DienTich;
            Console.WriteLine("----Search Tool----");

            Console.WriteLine("Nhập địa điểm cần tìm : ");
            location = Console.ReadLine();
            Console.WriteLine("Nhập giá cần tìm : ");
            price = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập diện tích cần tìm : ");
            DienTich = int.Parse(Console.ReadLine());

            foreach (Land i in listHouse)
            {
                if (KiemTra(i, location, price, DienTich)) 
                    i.Show();
            }
        }
        private static void ListLand(List<Land> listHouse)
        {
            Console.WriteLine("\n---danh sách các khu đất có diện tích > 100m2 hoặc là nhà phố mà có diện tích >60m2 và năm xây dựng >= 2020 (nếu có)---");
            var listLand = listHouse.OfType<Land>();
            List<Land> danhsachcacLand = listLand.Where(a => a.square1 > 100)
                                                  .ToList();
            var listhousee = listHouse.OfType<House>();
            List<House> danhsachcacHouse = listhousee.Where(a => a.square1 > 60 && a.year1 >= 2020)
                                                    .ToList();
            foreach (Land item in danhsachcacLand)
            {
                item.Show();
                Console.WriteLine("\n");
            }
            foreach (Land item in danhsachcacHouse)
            {
                item.Show();
                Console.WriteLine("\n");
            }
        }

        private static void Tongprice(List<Land> listHouse)
        {
            
            float sum = 0;
            foreach (var i in listHouse)
            {
                sum = (float)(sum + i.price1);
            }
            Console.WriteLine("\n---Tổng giá bán các khu nhà là:{0}", sum);
        }

        private static void XuatNha(List<Land> ListHouse)
        {
            Console.WriteLine("\n----- Danh Sách Nhà: ------");
            foreach (var i in ListHouse)
            {
                i.Show();
            }
                Console.WriteLine("\n");

        }

        private static List<Land> NhapNha()
        {
            Console.WriteLine("----- Chọn Khu nhà bạn cần------");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("\nNhập Số Lượng Nhà:");
            int N = Convert.ToInt32(Console.ReadLine());
            List<Land> ListHouse = new List<Land>();
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Bạn Muốn nhà nào: ");
                Console.WriteLine("1. Khu Đất: ");
                Console.WriteLine("2. Nhà Phố: ");
                Console.WriteLine("3. Chung cư: ");
                int Temp = Convert.ToInt32(Console.ReadLine());
                Land land = new Land(); // tao 1 ps
                switch (Temp)
                {
                    case 1:
                        land = new Land();
                        break;
                    case 2:
                        land = new House();
                        break;
                    case 3:
                        land = new Apartment();
                        break;
                    default:
                        Console.WriteLine("Chưa có nhà này");
                        break;
                }
                try
                {
                    land.Input();
                    
                }
                catch (Exception e)
                {
                    throw e = new Exception("Error while reading land: " + e.Message);
                }
                ListHouse.Add(land);
            }


            return ListHouse;// ket qua tra ve
        }

        private static void ListHouse(List<Land> listHouse)
        {
            Console.WriteLine("----- Danh Sách Sinh Viên là: ------");
            foreach (var i in listHouse)
            {
                i.Show();
            }
        }

        private static List<Land> NhapDSHouse()
        {
            Console.WriteLine("Nhập Số Lượng Nhà: ");
            int N = Convert.ToInt32(Console.ReadLine());
            List<Land> ListHouse = new List<Land>();
            Console.WriteLine(" ------ Nhập Danh Sách Nhà ------");

            // Nhập danh sách sv
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($" ------Nhà thứ {i + 1} ------");
                Land house = new Land();
                house.Input();
                ListHouse.Add(house);
            }
            return ListHouse;
        }
    }
}

