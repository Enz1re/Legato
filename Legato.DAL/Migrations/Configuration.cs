namespace Legato.DAL.Migrations
{
    using Util;
    using Models;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<LegatoContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(LegatoContext context)
        {
            SeedGuitars(context);
            SeedUsers(context);
        }

        private void SeedGuitars(LegatoContext context)
        {
            var lucero = new VendorModel { Name = "Lucero" };
            var lyons = new VendorModel { Name = "Lyons" };
            var kremona = new VendorModel { Name = "Kremona" };
            var rogue = new VendorModel { Name = "Rogue" };
            var friedman = new VendorModel { Name = "Friedman" };
            var bcRich = new VendorModel { Name = "B.C. Rich" };
            var theLoar = new VendorModel { Name = "The Loar" };
            var hofner = new VendorModel { Name = "Hofner" };
            var mitchell = new VendorModel { Name = "Mitchell" };

            context.Vendors.Add(lucero);
            context.Vendors.Add(lyons);
            context.Vendors.Add(kremona);
            context.Vendors.Add(rogue);
            context.Vendors.Add(friedman);
            context.Vendors.Add(bcRich);
            context.Vendors.Add(theLoar);
            context.Vendors.Add(hofner);
            context.Vendors.Add(mitchell);

            // Seed test data
            for (int i = 0; i < 250; i++)
            {
                context.ClassicalAcousticGuitars.Add(new AcousticClassicalGuitarModel { Vendor = lucero, Model = "LC100", Mensura = 647, StringType = "Nylon", Price = 1275, ImgPath = "Content/img/Classical/lucero_lc100.png" });
                context.ClassicalAcousticGuitars.Add(new AcousticClassicalGuitarModel { Vendor = lucero, Model = "LFN200Sce", StringType = "Nylon", Mensura = 650, Price = 1366, ImgPath = "Content/img/Classical/lucero_lfn200sce.png" });
                context.ClassicalAcousticGuitars.Add(new AcousticClassicalGuitarModel { Vendor = lyons, Model = "Classroom", StringType = "Nylon", Mensura = 646, Price = 1420, ImgPath = "Content/img/Classical/lyons_classroom.png" });
                context.ClassicalAcousticGuitars.Add(new AcousticClassicalGuitarModel { Vendor = kremona, Model = "Verea Cutaway", StringType = "Fluorocarbon", Mensura = 640, Price = 1171, ImgPath = "Content/img/Classical/kremona_verea_cutaway.png" });

                context.WesternAcousticGuitars.Add(new AcousticWesternGuitarModel { Vendor = rogue, Model = "RA-090 Dreadnought", Mensura = 648, StringCaliber = 9, StringNumber = 6, Price = 1217, ImgPath = "Content/img/Western/rogue_ra_090_dreadnought.png" });
                context.WesternAcousticGuitars.Add(new AcousticWesternGuitarModel { Vendor = rogue, Model = "RA-090 Concert Cutaway", Mensura = 648, StringCaliber = 9, StringNumber = 6, Price = 1333, ImgPath = "Content/img/Western/rogue_ra_090_concert_cutaway.png" });
                context.WesternAcousticGuitars.Add(new AcousticWesternGuitarModel { Vendor = rogue, Model = "RA-090 Dreadnought Cutaway", Mensura = 648, StringCaliber = 8, StringNumber = 6, Price = 1290, ImgPath = "Content/img/Western/rogue_ra_090_dreadnought_cutaway.png" });
                context.WesternAcousticGuitars.Add(new AcousticWesternGuitarModel { Vendor = rogue, Model = "RA-090 Dreadnought 12 String", Mensura = 648, StringCaliber = 10, StringNumber = 12, Price = 1405, ImgPath = "Content/img/Western/rogue_ra_090_dreadnought_12_string.png" });

                context.ElectricGuitars.Add(new ElectricGuitarModel { Vendor = rogue, Model = "RR100 Rocketeer", HasTremoloBar = true, Soundbox = "Humbucker", StringCaliber = 9, StringNumber = 6, Mensura = 647, Price = 2883, ImgPath = "Content/img/Electric/rogue_rr100_rocketeer.png" });
                context.ElectricGuitars.Add(new ElectricGuitarModel { Vendor = friedman, Model = "Vintage-T HH Mapple Fingerboard", HasTremoloBar = false, Soundbox = "Humbucker", StringNumber = 6, StringCaliber = 9, Mensura = 646, Price = 77850, ImgPath = "Content/img/Electric/friedman_vintage_t_hh_mapple_fingerboard.png" });
                context.ElectricGuitars.Add(new ElectricGuitarModel { Vendor = bcRich, Model = "Warbeast", HasTremoloBar = true, Soundbox = "Humbucker", StringCaliber = 10, StringNumber = 6, Mensura = 647, Price = 12109, ImgPath = "Content/img/Electric/b_c_rich_warbeast.png" });
                context.ElectricGuitars.Add(new ElectricGuitarModel { Vendor = theLoar, Model = "LH-302T", HasTremoloBar = false, Soundbox = "Single", StringCaliber = 9, StringNumber = 6, Mensura = 646, Price = 15780, ImgPath = "Content/img/Electric/the_loar_lh_302t.png" });

                context.BassGuitars.Add(new BassGuitarModel { Vendor = rogue, Model = "LX205B", Soundbox = "Single", StringNumber = 5, Mensura = 702, Price = 3748, ImgPath = "Content/img/Bass/rogue_lx205b.png" });
                context.BassGuitars.Add(new BassGuitarModel { Vendor = hofner, Model = "Shorty", Soundbox = "Single", StringNumber = 5, Mensura = 703, Price = 7566, ImgPath = "Content/img/Bass/hofner_shorty.png" });
                context.BassGuitars.Add(new BassGuitarModel { Vendor = mitchell, Model = "MB200 Modern Rock Bass", Soundbox = "Humbucker", StringNumber = 4, Mensura = 699, Price = 5766, ImgPath = "Content/img/Bass/mitchell_mb200_modern_rock_bass.png" });
                context.BassGuitars.Add(new BassGuitarModel { Vendor = bcRich, Model = "MK3B Mockingbird", Soundbox = "Single", StringNumber = 4, Mensura = 702, Price = 11533, ImgPath = "Content/img/Bass/b_c_rich_mk3b_mockingbird.png" });
            }
        }

        private void SeedUsers(LegatoContext context)
        {
            var addGuitar = new UserClaim { ClaimName = "AddGuitar" };
            var removeGuitar = new UserClaim { ClaimName = "RemoveGuitar" };
            var editGuitar = new UserClaim { ClaimName = "EditGuitar" };
            var changeDisplayAmount = new UserClaim { ClaimName = "ChangeDisplayAmount" };
            var blockUser = new UserClaim { ClaimName = "BlockUser" };
            var getListOfUsers = new UserClaim { ClaimName = "GetListOfUsers" };
            var getCompromisedAttempts = new UserClaim { ClaimName = "GetCompromisedAttempts" };
            var removeCompromisedAttempts = new UserClaim { ClaimName = "RemoveCompromisedAttempts" };

            var user = new UserRole { RoleName = "User", UserClaims = new List<UserClaim>() };
            var admin = new UserRole { RoleName = "Admin", UserClaims = new List<UserClaim> { addGuitar, removeGuitar, editGuitar, blockUser } };
            var superuser = new UserRole
            {
                RoleName = "Superuser",
                UserClaims = new List<UserClaim>
                             {
                                 addGuitar,
                                 removeGuitar,
                                 editGuitar,
                                 blockUser,
                                 changeDisplayAmount,
                                 getListOfUsers,
                                 getCompromisedAttempts,
                                 removeCompromisedAttempts
                             }
            };

            context.UserClaims.Add(addGuitar);
            context.UserClaims.Add(removeGuitar);
            context.UserClaims.Add(editGuitar);
            context.UserClaims.Add(changeDisplayAmount);
            context.UserClaims.Add(blockUser);
            context.UserClaims.Add(getListOfUsers);
            context.UserClaims.Add(getCompromisedAttempts);
            context.UserClaims.Add(removeCompromisedAttempts);

            context.UserRoles.Add(user);
            context.UserRoles.Add(admin);
            context.UserRoles.Add(superuser);

            var adminPassword = Hashing.HashData("admin");
            var superuserPassword = Hashing.HashData("superuser");
            context.Users.Add(new UserModel { Username = "admin", EncryptedPassword = adminPassword, IsAuthenticated = false, UserRole = admin });
            context.Users.Add(new UserModel { Username = "superuser", EncryptedPassword = superuserPassword, IsAuthenticated = false, UserRole = superuser });
        }
    }
}
