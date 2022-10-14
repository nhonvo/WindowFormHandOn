namespace RapPhimNew.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addtablekhachhanghoadonchitiet : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ChiTietHoaDons",
                c => new
                    {
                        MaChiTietHoaDon = c.Int(nullable: false, identity: true),
                        SoGhe = c.Int(nullable: false),
                        MaHoaDon = c.Int(nullable: false),
                        GiaVe = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.MaChiTietHoaDon)
                .ForeignKey("dbo.HoaDons", t => t.MaHoaDon, cascadeDelete: true)
                .Index(t => t.MaHoaDon);
            
            CreateTable(
                "dbo.HoaDons",
                c => new
                    {
                        MaHoaDon = c.Int(nullable: false, identity: true),
                        TongTien = c.Double(nullable: false),
                        NgayLap = c.DateTime(nullable: false),
                        MaKhachHang = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaHoaDon)
                .ForeignKey("dbo.KhachHangs", t => t.MaKhachHang, cascadeDelete: true)
                .Index(t => t.MaKhachHang);
            
            CreateTable(
                "dbo.KhachHangs",
                c => new
                    {
                        MaKhachHang = c.Int(nullable: false, identity: true),
                        TenKhachHang = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.MaKhachHang);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ChiTietHoaDons", "MaHoaDon", "dbo.HoaDons");
            DropForeignKey("dbo.HoaDons", "MaKhachHang", "dbo.KhachHangs");
            DropIndex("dbo.HoaDons", new[] { "MaKhachHang" });
            DropIndex("dbo.ChiTietHoaDons", new[] { "MaHoaDon" });
            DropTable("dbo.KhachHangs");
            DropTable("dbo.HoaDons");
            DropTable("dbo.ChiTietHoaDons");
        }
    }
}
