namespace Legato.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class New : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Bass", "Vendor_Id", "dbo.Vendors");
            DropForeignKey("dbo.AcousticClassic", "Vendor_Id", "dbo.Vendors");
            DropForeignKey("dbo.Electric", "Vendor_Id", "dbo.Vendors");
            DropForeignKey("dbo.AcousticWestern", "Vendor_Id", "dbo.Vendors");
            DropIndex("dbo.Bass", new[] { "Vendor_Id" });
            DropIndex("dbo.AcousticClassic", new[] { "Vendor_Id" });
            DropIndex("dbo.Electric", new[] { "Vendor_Id" });
            DropIndex("dbo.AcousticWestern", new[] { "Vendor_Id" });
            RenameColumn(table: "dbo.Bass", name: "Vendor_Id", newName: "VendorId");
            RenameColumn(table: "dbo.AcousticClassic", name: "Vendor_Id", newName: "VendorId");
            RenameColumn(table: "dbo.Electric", name: "Vendor_Id", newName: "VendorId");
            RenameColumn(table: "dbo.AcousticWestern", name: "Vendor_Id", newName: "VendorId");
            AlterColumn("dbo.Bass", "VendorId", c => c.Int());
            AlterColumn("dbo.AcousticClassic", "VendorId", c => c.Int());
            AlterColumn("dbo.Electric", "VendorId", c => c.Int());
            AlterColumn("dbo.AcousticWestern", "VendorId", c => c.Int());
            CreateIndex("dbo.Bass", "VendorId");
            CreateIndex("dbo.AcousticClassic", "VendorId");
            CreateIndex("dbo.Electric", "VendorId");
            CreateIndex("dbo.AcousticWestern", "VendorId");
            AddForeignKey("dbo.Bass", "VendorId", "dbo.Vendors", "Id");
            AddForeignKey("dbo.AcousticClassic", "VendorId", "dbo.Vendors", "Id");
            AddForeignKey("dbo.Electric", "VendorId", "dbo.Vendors", "Id");
            AddForeignKey("dbo.AcousticWestern", "VendorId", "dbo.Vendors", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AcousticWestern", "VendorId", "dbo.Vendors");
            DropForeignKey("dbo.Electric", "VendorId", "dbo.Vendors");
            DropForeignKey("dbo.AcousticClassic", "VendorId", "dbo.Vendors");
            DropForeignKey("dbo.Bass", "VendorId", "dbo.Vendors");
            DropIndex("dbo.AcousticWestern", new[] { "VendorId" });
            DropIndex("dbo.Electric", new[] { "VendorId" });
            DropIndex("dbo.AcousticClassic", new[] { "VendorId" });
            DropIndex("dbo.Bass", new[] { "VendorId" });
            AlterColumn("dbo.AcousticWestern", "VendorId", c => c.Int(nullable: false));
            AlterColumn("dbo.Electric", "VendorId", c => c.Int(nullable: false));
            AlterColumn("dbo.AcousticClassic", "VendorId", c => c.Int(nullable: false));
            AlterColumn("dbo.Bass", "VendorId", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.AcousticWestern", name: "VendorId", newName: "Vendor_Id");
            RenameColumn(table: "dbo.Electric", name: "VendorId", newName: "Vendor_Id");
            RenameColumn(table: "dbo.AcousticClassic", name: "VendorId", newName: "Vendor_Id");
            RenameColumn(table: "dbo.Bass", name: "VendorId", newName: "Vendor_Id");
            CreateIndex("dbo.AcousticWestern", "Vendor_Id");
            CreateIndex("dbo.Electric", "Vendor_Id");
            CreateIndex("dbo.AcousticClassic", "Vendor_Id");
            CreateIndex("dbo.Bass", "Vendor_Id");
            AddForeignKey("dbo.AcousticWestern", "Vendor_Id", "dbo.Vendors", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Electric", "Vendor_Id", "dbo.Vendors", "Id", cascadeDelete: true);
            AddForeignKey("dbo.AcousticClassic", "Vendor_Id", "dbo.Vendors", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Bass", "Vendor_Id", "dbo.Vendors", "Id", cascadeDelete: true);
        }
    }
}
