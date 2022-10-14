namespace RapPhimNew.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterLenghTaiKhoan_Ten : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.TaiKhoans", "TenDangNhap", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TaiKhoans", "TenDangNhap", c => c.String());
        }
    }
}
