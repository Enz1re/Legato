using Legato.DAL.Models;
using System.Data.Entity;


namespace Legato.DAL
{
    class DatabaseInitializer : CreateDatabaseIfNotExists<GuitarContext>
    {
        protected override void Seed(GuitarContext context)
        {
            context.ClassicAcousticGuitars.Add(new AcousticClassicalGuitarModel { Vendor = "Lucero", Model = "LC100", Mensura = 647, StringType = "Nylon", StockPrice = 1275 });
            context.ClassicAcousticGuitars.Add(new AcousticClassicalGuitarModel { Vendor = "Lucero", Model = "LFN200Sce", StringType = "Nylon", Mensura = 650, StockPrice = 1366 });
            context.ClassicAcousticGuitars.Add(new AcousticClassicalGuitarModel { Vendor = "Lyons", Model = "Classroom", StringType = "Nylon", Mensura = 646, StockPrice = 1420 });
            context.ClassicAcousticGuitars.Add(new AcousticClassicalGuitarModel { Vendor = "Kremona", Model = "Verea Cutaway", StringType = "Fluorocarbon", Mensura = 640, StockPrice = 1171 });

            context.WesternAcousticGuitars.Add(new AcousticWesternGuitarModel { Vendor = "Rogue", Model = "RA-090 Dreadnought", Mensura = 648, StringCaliber = 9, StringNumber = 6, StockPrice = 1217 });
            context.WesternAcousticGuitars.Add(new AcousticWesternGuitarModel { Vendor = "Rogue", Model = "RA-090 Concert Cutaway", Mensura = 648, StringCaliber = 9, StringNumber = 6, StockPrice = 1333 });
            context.WesternAcousticGuitars.Add(new AcousticWesternGuitarModel { Vendor = "Rogue", Model = "RA-090 Dreadnought Cutaway", Mensura = 648, StringCaliber = 8, StringNumber = 6, StockPrice = 1290 });
            context.WesternAcousticGuitars.Add(new AcousticWesternGuitarModel { Vendor = "Rogue", Model = "RA-090 Dreadnought 12 String", Mensura = 648, StringCaliber = 10, StringNumber = 12, StockPrice = 1405 });

            context.ElectroGuitars.Add(new ElectroGuitarModel { Vendor = "Rogue", Model = "RR100 Rocketeer", HasTremoloBar = true, Soundbox = "Humbucker", StringCaliber = 9, StringNumber = 6, Mensura = 647, StockPrice = 2883 });
            context.ElectroGuitars.Add(new ElectroGuitarModel { Vendor = "Friedman", Model = "Vintage-T HH Mapple Fingerboard", HasTremoloBar = false, Soundbox = "Humbucker", StringNumber = 6, StringCaliber = 9, Mensura = 646, StockPrice = 77850 });
            context.ElectroGuitars.Add(new ElectroGuitarModel { Vendor = "B.C. Rich", Model = "Warbeast", HasTremoloBar = true, Soundbox = "Humbucker", StringCaliber = 10, StringNumber = 6, Mensura = 647, StockPrice = 12109 });
            context.ElectroGuitars.Add(new ElectroGuitarModel { Vendor = "The Loar", Model = "LH-302T", HasTremoloBar = false, Soundbox = "Single", StringCaliber = 9, StringNumber = 6, Mensura = 646, StockPrice = 15780 });

            context.BassGuitars.Add(new BassGuitarModel { Vendor = "Rogue", Model = "LX205B", Soundbox = "Single", StringNumber = 5, Mensura = 702, StockPrice = 3748 });
            context.BassGuitars.Add(new BassGuitarModel { Vendor = "Hofner", Model = "Shorty", Soundbox = "Single", StringNumber = 4, Mensura = 703, StockPrice = 7566 });
            context.BassGuitars.Add(new BassGuitarModel { Vendor = "Mitchell", Model = "MB200 Modern Rock Bass", Soundbox = "Humbucker", StringNumber = 4, Mensura = 699, StockPrice = 5766 });
            context.BassGuitars.Add(new BassGuitarModel { Vendor = "B.C. Rich", Model = "MK3B Mockingbird", Soundbox = "Single", StringNumber = 4, Mensura = 702, StockPrice = 11533 });

            context.SaveChanges();
        }
    }
}
