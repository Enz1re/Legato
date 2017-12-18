using Legato.DAL.Util;
using Legato.DAL.Models;
using System.Data.Entity;
using System.Collections.Generic;


namespace Legato.DAL
{
    class UserDbInitializer : CreateDatabaseIfNotExists<UserContext>
    {
        protected override void Seed(UserContext context)
        {
            var addGuitar = new UserClaim { ClaimName = "AddGuitar" };
            var removeGuitar = new UserClaim { ClaimName = "RemoveGuitar" };
            var editGuitar = new UserClaim { ClaimName = "EditGuitar" };
            var changeDisplayAmount = new UserClaim { ClaimName = "ChangeDisplayAmount" };

            var user = new UserRole { RoleName = "User", UserClaims = new List<UserClaim>() };
            var admin = new UserRole { RoleName = "Admin", UserClaims = new List<UserClaim> { addGuitar, removeGuitar, editGuitar } };
            var superuser = new UserRole { RoleName = "Superuser", UserClaims = new List<UserClaim> { addGuitar, removeGuitar, editGuitar, changeDisplayAmount } };

            context.UserClaims.Add(addGuitar);
            context.UserClaims.Add(removeGuitar);
            context.UserClaims.Add(editGuitar);
            context.UserClaims.Add(changeDisplayAmount);

            context.UserRoles.Add(user);
            context.UserRoles.Add(admin);
            context.UserRoles.Add(superuser);

            context.Users.Add(new UserModel { Username = "admin", EncryptedPassword = Hashing.HashData("admin"), UserRole = admin });
            context.Users.Add(new UserModel { Username = "superuser", EncryptedPassword = Hashing.HashData("superuser"), UserRole = superuser });
        }
    }
}
