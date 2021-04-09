namespace BTL_LTQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_MatHang : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CTHDs",
                c => new
                    {
                        MaHD = c.String(nullable: false, maxLength: 20),
                        MaMH = c.String(nullable: false, maxLength: 20),
                        SoLuong = c.Int(nullable: false),
                        DonGia = c.Single(nullable: false),
                        GiamGia = c.Single(nullable: false),
                    })
                .PrimaryKey(t => new { t.MaHD, t.MaMH })
                .ForeignKey("dbo.HoaDons", t => t.MaHD, cascadeDelete: true)
                .Index(t => t.MaHD);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CTHDs", "MaHD", "dbo.HoaDons");
            DropIndex("dbo.CTHDs", new[] { "MaHD" });
            DropTable("dbo.CTHDs");
        }
    }
}
