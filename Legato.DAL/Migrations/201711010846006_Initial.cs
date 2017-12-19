namespace Legato.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Vendors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Bass",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StringNumber = c.Byte(nullable: false),
                        Soundbox = c.String(nullable: false),
                        Model = c.String(nullable: false),
                        Mensura = c.Short(nullable: false),
                        Price = c.Int(nullable: false),
                        ImgPath = c.String(),
                        Vendor_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Vendors", t => t.Vendor_Id, cascadeDelete: true)
                .Index(t => t.Vendor_Id);
            
            CreateTable(
                "dbo.AcousticClassic",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StringType = c.String(nullable: false),
                        Model = c.String(nullable: false),
                        Mensura = c.Short(nullable: false),
                        Price = c.Int(nullable: false),
                        ImgPath = c.String(),
                        Vendor_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Vendors", t => t.Vendor_Id, cascadeDelete: true)
                .Index(t => t.Vendor_Id);
            
            CreateTable(
                "dbo.Electric",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StringNumber = c.Byte(nullable: false),
                        HasTremoloBar = c.Boolean(nullable: false),
                        Soundbox = c.String(nullable: false),
                        StringCaliber = c.Short(nullable: false),
                        Model = c.String(nullable: false),
                        Mensura = c.Short(nullable: false),
                        Price = c.Int(nullable: false),
                        ImgPath = c.String(),
                        Vendor_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Vendors", t => t.Vendor_Id, cascadeDelete: true)
                .Index(t => t.Vendor_Id);
            
            CreateTable(
                "dbo.AcousticWestern",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StringNumber = c.Byte(nullable: false),
                        StringCaliber = c.Short(nullable: false),
                        Model = c.String(nullable: false),
                        Mensura = c.Short(nullable: false),
                        Price = c.Int(nullable: false),
                        ImgPath = c.String(),
                        Vendor_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Vendors", t => t.Vendor_Id, cascadeDelete: true)
                .Index(t => t.Vendor_Id);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AcousticWestern", "Vendor_Id", "dbo.Vendors");
            DropForeignKey("dbo.Electric", "Vendor_Id", "dbo.Vendors");
            DropForeignKey("dbo.AcousticClassic", "Vendor_Id", "dbo.Vendors");
            DropForeignKey("dbo.Bass", "Vendor_Id", "dbo.Vendors");
            DropIndex("dbo.AcousticWestern", new[] { "Vendor_Id" });
            DropIndex("dbo.Electric", new[] { "Vendor_Id" });
            DropIndex("dbo.AcousticClassic", new[] { "Vendor_Id" });
            DropIndex("dbo.Bass", new[] { "Vendor_Id" });
            DropTable("dbo.AcousticWestern");
            DropTable("dbo.Electric");
            DropTable("dbo.AcousticClassic");
            DropTable("dbo.Vendors");
            DropTable("dbo.Bass");
        }
    }
}
