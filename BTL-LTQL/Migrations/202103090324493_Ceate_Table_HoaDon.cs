namespace BTL_LTQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Ceate_Table_HoaDon : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HoaDons",
                c => new
                    {
                        MaHD = c.String(nullable: false, maxLength: 20),
                        MaKH = c.String(maxLength: 10, unicode: false),
                        MaNV = c.String(),
                        NgayLapHD = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.MaHD)
                .ForeignKey("dbo.KhachHangs", t => t.MaKH)
                .Index(t => t.MaKH);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.HoaDons", "MaKH", "dbo.KhachHangs");
            DropIndex("dbo.HoaDons", new[] { "MaKH" });
            DropTable("dbo.HoaDons");
        }
    }
}
