using Legato.DAL.Models;
using System.Data.Entity;


namespace Legato.DAL.Tests
{
    class DatabaseInitializer : CreateDatabaseIfNotExists<GuitarContext>
    {
        protected override void Seed(GuitarContext context)
        {
            context.ClassicAcousticGuitars.Add(new AcousticClassicalGuitarModel { Vendor = "Lucero", Model = "LC100", Mensura = 647, StringType = "Nylon", Price = 1275, ImgPath = "Content/img/Classical/lucero_lc100.png" });
            context.ClassicAcousticGuitars.Add(new AcousticClassicalGuitarModel { Vendor = "Lucero", Model = "LFN200Sce", StringType = "Nylon", Mensura = 650, Price = 1366, ImgPath = "Content/img/Classical/lucero_lfn200sce.png" });
            context.ClassicAcousticGuitars.Add(new AcousticClassicalGuitarModel { Vendor = "Lyons", Model = "Classroom", StringType = "Nylon", Mensura = 646, Price = 1420, ImgPath = "Content/img/Classical/lyons_classroom.png" });
            context.ClassicAcousticGuitars.Add(new AcousticClassicalGuitarModel { Vendor = "Kremona", Model = "Verea Cutaway", StringType = "Fluorocarbon", Mensura = 640, Price = 1171, ImgPath = "Content/img/Classical/kremona_verea_cutaway.png" });

            context.WesternAcousticGuitars.Add(new AcousticWesternGuitarModel { Vendor = "Rogue", Model = "RA-090 Dreadnought", Mensura = 648, StringCaliber = 9, StringNumber = 6, Price = 1217, ImgPath = "Content/img/Western/rogue_ra_090_dreadnought.png" });
            context.WesternAcousticGuitars.Add(new AcousticWesternGuitarModel { Vendor = "Rogue", Model = "RA-090 Concert Cutaway", Mensura = 648, StringCaliber = 9, StringNumber = 6, Price = 1333, ImgPath = "Content/img/Western/rogue_ra_090_concert_cutaway.png" });
            context.WesternAcousticGuitars.Add(new AcousticWesternGuitarModel { Vendor = "Rogue", Model = "RA-090 Dreadnought Cutaway", Mensura = 648, StringCaliber = 8, StringNumber = 6, Price = 1290, ImgPath = "Content/img/Western/rogue_ra_090_dreadnought_cutaway.png" });
            context.WesternAcousticGuitars.Add(new AcousticWesternGuitarModel { Vendor = "Rogue", Model = "RA-090 Dreadnought 12 String", Mensura = 648, StringCaliber = 10, StringNumber = 12, Price = 1405, ImgPath = "Content/img/Western/rogue_ra_090_dreadnought_12_string.png" });

            context.ElectricGuitars.Add(new ElectricGuitarModel { Vendor = "Rogue", Model = "RR100 Rocketeer", HasTremoloBar = true, Soundbox = "Humbucker", StringCaliber = 9, StringNumber = 6, Mensura = 647, Price = 2883, ImgPath = "Content/img/Electric/rogue_rr100_rocketeer.png" });
            context.ElectricGuitars.Add(new ElectricGuitarModel { Vendor = "Friedman", Model = "Vintage-T HH Mapple Fingerboard", HasTremoloBar = false, Soundbox = "Humbucker", StringNumber = 6, StringCaliber = 9, Mensura = 646, Price = 77850, ImgPath = "Content/img/Electric/friedman_vintage_t_hh_mapple_fingerboard.png" });
            context.ElectricGuitars.Add(new ElectricGuitarModel { Vendor = "B.C. Rich", Model = "Warbeast", HasTremoloBar = true, Soundbox = "Humbucker", StringCaliber = 10, StringNumber = 6, Mensura = 647, Price = 12109, ImgPath = "Content/img/Electric/b_c_rich_warbeast.png" });
            context.ElectricGuitars.Add(new ElectricGuitarModel { Vendor = "The Loar", Model = "LH-302T", HasTremoloBar = false, Soundbox = "Single", StringCaliber = 9, StringNumber = 6, Mensura = 646, Price = 15780, ImgPath = "Content/img/Electric/the_loar_lh_302t.png" });

            context.BassGuitars.Add(new BassGuitarModel { Vendor = "Rogue", Model = "LX205B", Soundbox = "Single", StringNumber = 5, Mensura = 702, Price = 3748, ImgPath = "Content/img/Bass/rogue_lx205b.png" });
            context.BassGuitars.Add(new BassGuitarModel { Vendor = "Hofner", Model = "Shorty", Soundbox = "Single", StringNumber = 5, Mensura = 703, Price = 7566, ImgPath = "Content/img/Bass/hofner_shorty.png" });
            context.BassGuitars.Add(new BassGuitarModel { Vendor = "Mitchell", Model = "MB200 Modern Rock Bass", Soundbox = "Humbucker", StringNumber = 4, Mensura = 699, Price = 5766, ImgPath = "Content/img/Bass/mitchell_mb200_modern_rock_bass.png" });
            context.BassGuitars.Add(new BassGuitarModel { Vendor = "B.C. Rich", Model = "MK3B Mockingbird", Soundbox = "Single", StringNumber = 4, Mensura = 702, Price = 11533, ImgPath = "Content/img/Bass/b_c_rich_mk3b_mockingbird.png" });
        }
    }
}
