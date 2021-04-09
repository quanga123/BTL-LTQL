namespace BTL_LTQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_NhanVien : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LoaiHangs",
                c => new
                    {
                        MaLoai = c.String(nullable: false, maxLength: 5),
                        TenLoai = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.MaLoai);
            
            AddColumn("dbo.MatHangs", "LoaiHang_MaLoai", c => c.String(maxLength: 5));
            CreateIndex("dbo.MatHangs", "LoaiHang_MaLoai");
            AddForeignKey("dbo.MatHangs", "LoaiHang_MaLoai", "dbo.LoaiHangs", "MaLoai");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MatHangs", "LoaiHang_MaLoai", "dbo.LoaiHangs");
            DropIndex("dbo.MatHangs", new[] { "LoaiHang_MaLoai" });
            DropColumn("dbo.MatHangs", "LoaiHang_MaLoai");
            DropTable("dbo.LoaiHangs");
        }
    }
}
