namespace Exercise1_ScientistsManagement
{
    public class NhaQuanly : NhanVien
    {
        protected float bacLuong;
        protected int soNgayCong;
        public NhaQuanly() : base()
        {
            bacLuong = 0f;
            soNgayCong = 0;
        }

        public override float TongLuong()
        {
            return bacLuong * soNgayCong;
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhap so ngay cong trong thang:");
            soNgayCong = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nhap bac luong:");
            bacLuong = Convert.ToInt32(Console.ReadLine());
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine(soNgayCong + bacLuong);
            Console.WriteLine("Luong quan ly: " + TongLuong());

        }
    }
}