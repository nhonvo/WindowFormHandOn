namespace Exercise1_ScientistsManagement
{
    public class NhaKhoaHoc : NhaQuanly
    {
        private int soBaiBao;
        public NhaKhoaHoc() : base()
        {
            soBaiBao = 0;
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhap so bai bao cong bo:");
            soBaiBao = Convert.ToInt32(Console.ReadLine());
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("so bai bao cong bo:" + soBaiBao);
            Console.WriteLine("Luong nha khoa hoc: " + TongLuong());
        }

    }
}