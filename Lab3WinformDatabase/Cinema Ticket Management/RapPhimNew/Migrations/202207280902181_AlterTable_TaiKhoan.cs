namespace RapPhimNew.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterTable_TaiKhoan : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TaiKhoans", "TenDangNhap", c => c.String());
            AddColumn("dbo.TaiKhoans", "TenHienThi", c => c.Int(nullable: false));
            DropColumn("dbo.TaiKhoans", "TenTaiKhoan");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TaiKhoans", "TenTaiKhoan", c => c.String());
            DropColumn("dbo.TaiKhoans", "TenHienThi");
            DropColumn("dbo.TaiKhoans", "TenDangNhap");
        }
    }
}
