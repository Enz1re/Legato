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
            var guitars = _repoProvider.ElectricGuitarRepository.GetAll();
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
        [DataTestMethod]
        [DataRow("lucero", 2)]
        [DataRow("kremona", 1)]
        [DataRow("lyons", 1)]
        [DataRow("rogue", 0)]
        [DataRow("yamaha", 0)]
        public void GetAcousticClassicalGuitarsWithQuantity(string vName, int quantity)
        {
            var guitars = _repoProvider.AcousticClassicalGuitarRepository.FindByVendor(vName);
            Assert.AreEqual(guitars.Count(), quantity);
        }

        [DataTestMethod]
        [DataRow("rogue", 4)]
        [DataRow("lucero", 0)]
        [DataRow("kremona", 0)]
        [DataRow("lyons", 0)]
        [DataRow("yamaha", 0)]
        public void GetAcousticWesternGuitarsWithQuantity(string vName, int quantity)
        {
            var guitars = _repoProvider.AcousticWesternGuitarRepository.FindByVendor(vName);
            Assert.AreEqual(guitars.Count(), quantity);
        }
        
        [DataTestMethod]
        [DataRow("friedman", 1)]
        [DataRow("the loar", 1)]
        [DataRow("b.c. rich", 1)]
        [DataRow("rogue", 1)]
        [DataRow("lucero", 0)]
        [DataRow("mitchell", 0)]
        [DataRow("kremona", 0)]
        [DataRow("lyons", 0)]
        [DataRow("yamaha", 0)]
        public void GetElectricGuitarsWithQuantity(string vName, int quantity)
        {
            var guitars = _repoProvider.ElectricGuitarRepository.FindByVendor(vName);
            Assert.AreEqual(guitars.Count(), quantity);
        }

        [DataTestMethod]
        [DataRow("b.c. rich", 1)]
        [DataRow("hofner", 1)]
        [DataRow("mitchell", 1)]
        [DataRow("rogue", 1)]
        [DataRow("lucero", 0)]
        [DataRow("the loar", 0)]
        [DataRow("kremona", 0)]
        [DataRow("lyons", 0)]
        [DataRow("yamaha", 0)]
        public void GetBassGuitarsWithQuantity(string vName, int quantity)
        {
            var guitars = _repoProvider.BassGuitarRepository.FindByVendor(vName);
            Assert.AreEqual(guitars.Count(), quantity);
        }
    }
}
