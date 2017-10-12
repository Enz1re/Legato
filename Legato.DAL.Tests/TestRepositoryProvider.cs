using Ninject;
using System.Linq;
using Legato.DAL.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Legato.DAL.Tests
{
    [TestClass]
    public class TestRepositoryProvider
    {
        private IRepositoryProvider _repoProvider;

        public TestRepositoryProvider()
        {
            var kernel = new StandardKernel(new LegatoTestDALDIModule());
            _repoProvider = kernel.Get<IRepositoryProvider>();
        }

        /*
         * Get all guitars
         */

        [TestMethod]
        public void ReturnFourAcousticClassicalGuitars()
        {
            var guitars = _repoProvider.AcousticClassicalGuitarRepository.GetAll();
            Assert.AreEqual(guitars.Count(), 4);
        }

        [TestMethod]
        public void ReturnFourAcousticWesternGuitars()
        {
            var guitars = _repoProvider.AcousticWesternGuitarRepository.GetAll();
            Assert.AreEqual(guitars.Count(), 4);
        }

        [TestMethod]
        public void ReturnFourElectricGuitars()
        {
            var guitars = _repoProvider.ElectroGuitarRepository.GetAll();
            Assert.AreEqual(guitars.Count(), 4);
        }

        [TestMethod]
        public void ReturnFourBassGuitars()
        {
            var guitars = _repoProvider.BassGuitarRepository.GetAll();
            Assert.AreEqual(guitars.Count(), 4);
        }

        /*
         * Get guitars by vendors
         */

        // Acoustic classical guitars
        [TestMethod]
        public void GetTwoLuceroAcousticClassicalGuitars()
        {
            var luceroGuitars = _repoProvider.AcousticClassicalGuitarRepository.FindByVendor("lucero");
            Assert.AreEqual(luceroGuitars.Count(), 2);
        }

        [TestMethod]
        public void GetOneKremonaAcousticClassicalGuitar()
        {
            var kremonaGuitars = _repoProvider.AcousticClassicalGuitarRepository.FindByVendor("kremona");
            Assert.AreEqual(kremonaGuitars.Count(), 1);
        }

        [TestMethod]
        public void GetOneLyonsAcousticClassicalGuitar()
        {
            var lyonsGuitars = _repoProvider.AcousticClassicalGuitarRepository.FindByVendor("lyons");
            Assert.AreEqual(lyonsGuitars.Count(), 1);
        }

        [TestMethod]
        public void GetNoRogueAcousticClassicalGuitars()
        {
            var rogueGuitars = _repoProvider.AcousticClassicalGuitarRepository.FindByVendor("rogue");
            Assert.AreEqual(rogueGuitars.Count(), 0);
        }

        [TestMethod]
        public void GetNoYamahaAcousticClassicalGuitars()
        {
            var yamahaGuitars = _repoProvider.AcousticClassicalGuitarRepository.FindByVendor("yamaha");
            Assert.AreEqual(yamahaGuitars.Count(), 0);
        }

        // Acoustic western guitars
        [TestMethod]
        public void GetFourRogueAcousticWesternGuitars()
        {
            var rogueGuitars = _repoProvider.AcousticWesternGuitarRepository.FindByVendor("rogue");
            Assert.AreEqual(rogueGuitars.Count(), 4);
        }

        [TestMethod]
        public void GetNoLuceroAcousticWesternGuitars()
        {
            var luceroGuitars = _repoProvider.AcousticWesternGuitarRepository.FindByVendor("lucero");
            Assert.AreEqual(luceroGuitars.Count(), 0);
        }

        [TestMethod]
        public void GetNoYamahaAcousticWesternGuitars()
        {
            var yamahaGuitars = _repoProvider.AcousticWesternGuitarRepository.FindByVendor("yamaha");
            Assert.AreEqual(yamahaGuitars.Count(), 0);
        }

        // Electric guitars
        [TestMethod]
        public void GetOneBCRichElectricGuitar()
        {
            var bcRichGuitars = _repoProvider.ElectroGuitarRepository.FindByVendor("b.c. rich");
            Assert.AreEqual(bcRichGuitars.Count(), 1);
        }

        [TestMethod]
        public void GetOneFriedmanElectricGuitar()
        {
            var friedmanGuitars = _repoProvider.ElectroGuitarRepository.FindByVendor("Friedman");
            Assert.AreEqual(friedmanGuitars.Count(), 1);
        }

        [TestMethod]
        public void GetOneRogueElectricGuitar()
        {
            var rogueGuitars = _repoProvider.ElectroGuitarRepository.FindByVendor("rogue");
            Assert.AreEqual(rogueGuitars.Count(), 1);
        }

        [TestMethod]
        public void GetOneTheLoarElectricGuitar()
        {
            var theLoarGuitars = _repoProvider.ElectroGuitarRepository.FindByVendor("The loar");
            Assert.AreEqual(theLoarGuitars.Count(), 1);
        }

        [TestMethod]
        public void GetNoYamahaElectricGuitars()
        {
            var yamahaGuitars = _repoProvider.ElectroGuitarRepository.FindByVendor("yamaha");
            Assert.AreEqual(yamahaGuitars.Count(), 0);
        }

        // Bass guitars
        [TestMethod]
        public void GetOneBCRichBassGuitar()
        {
            var bcRichGuitars = _repoProvider.BassGuitarRepository.FindByVendor("B.C. Rich");
            Assert.AreEqual(bcRichGuitars.Count(), 1);
        }

        [TestMethod]
        public void GetOneHofnerBassGuitar()
        {
            var hofnerGuitars = _repoProvider.BassGuitarRepository.FindByVendor("hofner");
            Assert.AreEqual(hofnerGuitars.Count(), 1);
        }

        [TestMethod]
        public void GetOneMitchellBassGuitar()
        {
            var mitchellGuitars = _repoProvider.BassGuitarRepository.FindByVendor("mitchell");
            Assert.AreEqual(mitchellGuitars.Count(), 1);
        }

        [TestMethod]
        public void GetOneRogueBassGuitar()
        {
            var rogueGuitars = _repoProvider.BassGuitarRepository.FindByVendor("rogue");
            Assert.AreEqual(rogueGuitars.Count(), 1);
        }

        [TestMethod]
        public void GetNoLuceroBassGuitars()
        {
            var luceroGuitars = _repoProvider.BassGuitarRepository.FindByVendor("lucero");
            Assert.AreEqual(luceroGuitars.Count(), 0);
        }

        [TestMethod]
        public void GetNoYamahaBassGuitars()
        {
            var yamahaGuitars = _repoProvider.BassGuitarRepository.FindByVendor("yamaha");
            Assert.AreEqual(yamahaGuitars.Count(), 0);
        }
    }
}
