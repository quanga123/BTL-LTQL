namespace BTL_LTQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_LoaiHang : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MatHangs",
                c => new
                    {
                        MaMH = c.String(nullable: false, maxLength: 20),
                        TenMH = c.String(nullable: false),
                        DonGia = c.Single(nullable: false),
                        HinhAnh = c.String(),
                        TenLoaiMH = c.String(),
                    })
                .PrimaryKey(t => t.MaMH);
            
            CreateIndex("dbo.CTHDs", "MaMH");
            AddForeignKey("dbo.CTHDs", "MaMH", "dbo.MatHangs", "MaMH", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CTHDs", "MaMH", "dbo.MatHangs");
            DropIndex("dbo.CTHDs", new[] { "MaMH" });
            DropTable("dbo.MatHangs");
        }
    }
}
