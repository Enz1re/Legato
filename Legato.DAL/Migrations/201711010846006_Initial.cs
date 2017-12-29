namespace Legato.DAL.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            #region Guitar tables

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

            #endregion

            #region User tables

            CreateTable(
                "dbo.BannedTokens",
                c => new
                {
                    Token = c.String(nullable: false, maxLength: 128),
                })
                .PrimaryKey(t => t.Token);

            CreateTable(
                "dbo.TokenStorage",
                c => new
                {
                    Token = c.String(nullable: false, maxLength: 128),
                    Expiry = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => t.Token);

            CreateTable(
                "dbo.UserClaims",
                c => new
                {
                    ClaimId = c.Int(nullable: false, identity: true),
                    ClaimName = c.String(nullable: false),
                })
                .PrimaryKey(t => t.ClaimId);

            CreateTable(
                "dbo.UserRoles",
                c => new
                {
                    RoleId = c.Int(nullable: false, identity: true),
                    RoleName = c.String(nullable: false),
                })
                .PrimaryKey(t => t.RoleId);

            CreateTable(
                "dbo.Users",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Username = c.String(nullable: false),
                    EncryptedPassword = c.String(nullable: false),
                    UserRoleId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UserRoles", t => t.UserRoleId, cascadeDelete: true)
                .Index(t => t.UserRoleId);

            CreateTable(
                "dbo.UserRoleUserClaims",
                c => new
                {
                    UserRole_RoleId = c.Int(nullable: false),
                    UserClaim_ClaimId = c.Int(nullable: false),
                })
                .PrimaryKey(t => new { t.UserRole_RoleId, t.UserClaim_ClaimId })
                .ForeignKey("dbo.UserRoles", t => t.UserRole_RoleId, cascadeDelete: true)
                .ForeignKey("dbo.UserClaims", t => t.UserClaim_ClaimId, cascadeDelete: true)
                .Index(t => t.UserRole_RoleId)
                .Index(t => t.UserClaim_ClaimId);

            #endregion
        }

        public override void Down()
        {
            #region Guitar changes

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

            #endregion

            #region User changes

            DropForeignKey("dbo.Users", "UserRoleId", "dbo.UserRoles");
            DropForeignKey("dbo.UserRoleUserClaims", "UserRole_RoleId", "dbo.UserClaims");
            DropForeignKey("dbo.UserRoleUserClaims", "UserClaim_ClaimId", "dbo.UserRoles");

            DropIndex("dbo.BannedTokens", new[] { "Token" });
            DropIndex("dbo.TokenStorage", new[] { "Token" });
            DropIndex("dbo.UserClaims", new[] { "ClaimId" });
            DropIndex("dbo.UserRoles", new[] { "VendorId" });
            DropIndex("dbo.Users", new[] { "RoleId" });
            DropIndex("dbo.UserRoleUserClaims", new[] { "UserRole_RoleId", "UserClaim_ClaimId" });

            DropTable("dbo.BannedTokens");
            DropTable("dbo.TokenStorage");
            DropTable("dbo.UserClaims");
            DropTable("dbo.UserRoles");
            DropTable("dbo.Users");
            DropTable("dbo.UserRoleUserClaims");

            #endregion
        }
    }
}
