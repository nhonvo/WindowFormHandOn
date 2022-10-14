namespace RapPhimNew.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTable_TaiKhoan : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TaiKhoans",
                c => new
                    {
                        MaTaiKhoan = c.Int(nullable: false, identity: true),
                        TenTaiKhoan = c.String(),
                        MatKhau = c.String(),
                    })
                .PrimaryKey(t => t.MaTaiKhoan);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TaiKhoans");
        }
    }
}
