namespace Legato.DAL.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class New_2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BannedTokens",
                c => new
                    {
                        Token = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Token);
            
            CreateTable(
                "dbo.CompromisedAttempts",
                c => new
                    {
                        AttemptId = c.Int(nullable: false, identity: true),
                        CompromisedToken = c.String(nullable: false),
                        RequestIP = c.String(),
                        Username = c.String(nullable: false),
                        RequestDateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.AttemptId);
            
            CreateTable(
                "dbo.TokenStorage",
                c => new
                    {
                        Token = c.String(nullable: false, maxLength: 256),
                        IssuedTo = c.String(nullable: false),
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
                        IsAuthenticated = c.Boolean(nullable: false),
                        UserRoleId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UserRoles", t => t.UserRoleId)
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
            DropForeignKey("dbo.UserRoleUserClaims", "UserClaim_ClaimId", "dbo.UserClaims");
            DropForeignKey("dbo.UserRoleUserClaims", "UserRole_RoleId", "dbo.UserRoles");
            DropIndex("dbo.UserRoleUserClaims", new[] { "UserClaim_ClaimId" });
            DropIndex("dbo.UserRoleUserClaims", new[] { "UserRole_RoleId" });
            DropIndex("dbo.Users", new[] { "UserRoleId" });
            DropTable("dbo.UserRoleUserClaims");
            DropTable("dbo.Users");
            DropTable("dbo.UserRoles");
            DropTable("dbo.UserClaims");
            DropTable("dbo.TokenStorage");
            DropTable("dbo.CompromisedAttempts");
            DropTable("dbo.BannedTokens");
        }
    }
}
