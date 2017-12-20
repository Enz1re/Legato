namespace Legato.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedUsers : DbMigration
    {
        public override void Up()
        {
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
        }
        
        public override void Down()
        {
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
        }
    }
}
