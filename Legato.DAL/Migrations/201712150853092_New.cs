namespace Legato.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class New : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Bass", name: "Vendor_Id", newName: "VendorId");
            RenameColumn(table: "dbo.AcousticClassic", name: "Vendor_Id", newName: "VendorId");
            RenameColumn(table: "dbo.Electric", name: "Vendor_Id", newName: "VendorId");
            RenameColumn(table: "dbo.AcousticWestern", name: "Vendor_Id", newName: "VendorId");
            RenameIndex(table: "dbo.Bass", name: "IX_Vendor_Id", newName: "IX_VendorId");
            RenameIndex(table: "dbo.AcousticClassic", name: "IX_Vendor_Id", newName: "IX_VendorId");
            RenameIndex(table: "dbo.Electric", name: "IX_Vendor_Id", newName: "IX_VendorId");
            RenameIndex(table: "dbo.AcousticWestern", name: "IX_Vendor_Id", newName: "IX_VendorId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.AcousticWestern", name: "IX_VendorId", newName: "IX_Vendor_Id");
            RenameIndex(table: "dbo.Electric", name: "IX_VendorId", newName: "IX_Vendor_Id");
            RenameIndex(table: "dbo.AcousticClassic", name: "IX_VendorId", newName: "IX_Vendor_Id");
            RenameIndex(table: "dbo.Bass", name: "IX_VendorId", newName: "IX_Vendor_Id");
            RenameColumn(table: "dbo.AcousticWestern", name: "VendorId", newName: "Vendor_Id");
            RenameColumn(table: "dbo.Electric", name: "VendorId", newName: "Vendor_Id");
            RenameColumn(table: "dbo.AcousticClassic", name: "VendorId", newName: "Vendor_Id");
            RenameColumn(table: "dbo.Bass", name: "VendorId", newName: "Vendor_Id");
        }
    }
}
