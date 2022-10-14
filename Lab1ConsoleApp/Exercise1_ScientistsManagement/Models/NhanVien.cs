namespace Exercise1_ScientistsManagement
{
    public abstract class NhanVien
    {
        protected string? hoTen;
        protected int namSinh;
        protected string? chucVu;
        protected string? bangCap;
        public abstract float TongLuong();
        public NhanVien()
        {
            hoTen = "";
            namSinh = 2002;
            chucVu = "NhanVien";
            bangCap = "Dai Hoc";
        }
        public virtual void Nhap()
        {
            Console.WriteLine("Nhap ho ten:");
            hoTen = Console.ReadLine();

            Console.WriteLine("Nhap nam sinh:");
            namSinh = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nhap chuc vu:");
            chucVu = Console.ReadLine();

            Console.WriteLine("Nhap bang cap:");
            bangCap = Console.ReadLine();
        }
        public virtual void Xuat()
        {
            Console.WriteLine(hoTen+" "+ namSinh +" "+ chucVu +" "+ bangCap);
        }
    }
}