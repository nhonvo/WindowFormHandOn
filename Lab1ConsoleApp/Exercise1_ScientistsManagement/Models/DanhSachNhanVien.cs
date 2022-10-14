namespace Exercise1_ScientistsManagement
{
    public class DanhSachNhanVien
    {
        public const int NHAN_VIEN = 1;
        public const int NHA_QUAN_LY = 2;
        public List<NhanVien> NhanViens = new List<NhanVien>();
        public int Count = 0;
        public int Type = 0;
        public void NhapDanhSach(int Type)
        {
            NhanVien nv;
            Console.WriteLine("Nhap so luong nhan vien:");
            Count = Convert.ToInt32(Console.ReadLine());
            if (Type == NHAN_VIEN)
            {
                for (int i = 0; i < Count; i++)
                {
                    nv = new NhanVienObj();
                    nv.Nhap();
                    NhanViens.Add(nv);
                }
            }
            else if (Type == NHA_QUAN_LY)
            {
                for (int i = 0; i < Count; i++)
                {
                    nv = new NhaQuanly();
                    nv.Nhap();
                    NhanViens.Add(nv);
                }
            }
            else
            {
                for (int i = 0; i < Count; i++)
                {
                    nv =new NhaKhoaHoc();
                    nv.Nhap();
                    NhanViens.Add(nv);
                }
            }
        }
        public void XuatDanhSach()
        {
           foreach (var nv in NhanViens)
           {   
                nv.Xuat();
           }
        }
    }
}