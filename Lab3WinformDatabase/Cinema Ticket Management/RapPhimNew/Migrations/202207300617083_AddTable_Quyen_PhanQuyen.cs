namespace RapPhimNew.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTable_Quyen_PhanQuyen : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PhanQuyens",
                c => new
                    {
                        MaPhanQuyen = c.Int(nullable: false, identity: true),
                        MaTaiKhoan = c.Int(nullable: false),
                        MaQuyenTruyCap = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaPhanQuyen)
                .ForeignKey("dbo.QuyenTruyCaps", t => t.MaQuyenTruyCap, cascadeDelete: true)
                .ForeignKey("dbo.TaiKhoans", t => t.MaTaiKhoan, cascadeDelete: true)
                .Index(t => t.MaTaiKhoan)
                .Index(t => t.MaQuyenTruyCap);
            
            CreateTable(
                "dbo.QuyenTruyCaps",
                c => new
                    {
                        MaQuyen = c.Int(nullable: false, identity: true),
                        Ten = c.String(),
                    })
                .PrimaryKey(t => t.MaQuyen);
            
            AlterColumn("dbo.TaiKhoans", "TenHienThi", c => c.String());
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PhanQuyens", "MaTaiKhoan", "dbo.TaiKhoans");
            DropForeignKey("dbo.PhanQuyens", "MaQuyenTruyCap", "dbo.QuyenTruyCaps");
            DropIndex("dbo.PhanQuyens", new[] { "MaQuyenTruyCap" });
            DropIndex("dbo.PhanQuyens", new[] { "MaTaiKhoan" });
            AlterColumn("dbo.TaiKhoans", "TenHienThi", c => c.Int(nullable: false));
            DropTable("dbo.QuyenTruyCaps");
            DropTable("dbo.PhanQuyens");
        }
    }
}
