using Exercise1_ScientistsManagement;

DanhSachNhanVien ds = new DanhSachNhanVien();
NhanVien nv;
int option = 0;
do
{
    Console.WriteLine("Chon loai nhan vien: ");
    Console.WriteLine("1. Nhan vien phong thi nghiem.");
    Console.WriteLine("2. Nha quan ly.");
    Console.WriteLine("3. Nha khoa hoc.");
    Console.WriteLine("4. Xuat danh sach.");
    Console.Write("Chon: ");
    option = Convert.ToInt32(Console.ReadLine());
    switch (option)
    {
        case 1:
            ds.NhapDanhSach(1);
            break;
        case 2:
            nv = new NhaQuanly();
            ds.NhapDanhSach(2);
            break;
        case 3:
            ds.NhapDanhSach(3);
            break;
        case 4:
            ds.XuatDanhSach();
            break;
        case 0:
            return 0;
        default:
            break;
    }
} while (true);