namespace Exercise1_ScientistsManagement
{
    public class NhanVienObj : NhanVien
    { 
        private float luongCoBan;
        public NhanVienObj() : base(){}
        public override float TongLuong()=> luongCoBan;
        public override void Nhap() {
            base.Nhap();
        }
        public override void Xuat(){
            base.Xuat();
            Console.WriteLine("Luong nhan vien phong thi nghiem : "+ luongCoBan);
        }
    }
}