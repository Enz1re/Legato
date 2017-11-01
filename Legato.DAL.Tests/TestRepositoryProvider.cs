using Ninject;
using System.Linq;
using Legato.DAL.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

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
        [DataRow(2, "lucero")]
        [DataRow(1, "kremona")]
        [DataRow(1, "lyons")]
        [DataRow(0, "rogue")]
        [DataRow(0, "yamaha")]
        public void GetAcousticClassicalGuitarsWithQuantity(int quantity, object[] vNames)
        {
            var guitars = _repoProvider.AcousticClassicalGuitarRepository.FindByVendors(vNames as string[]);
            Assert.AreEqual(guitars.Count(), quantity);
        }

        [DataTestMethod]
        [DataRow(4, "rogue")]
        [DataRow(0, "lucero")]
        [DataRow(0, "kremona")]
        [DataRow(0, "lyons")]
        [DataRow(0, "yamaha")]
        public void GetAcousticWesternGuitarsWithQuantity(int quantity, object[] vNames)
        {
            var guitars = _repoProvider.AcousticWesternGuitarRepository.FindByVendors(vNames as string[]);
            Assert.AreEqual(guitars.Count(), quantity);
        }
        
        [DataTestMethod]
        [DataRow(1, "friedman")]
        [DataRow(1, "the loar")]
        [DataRow(1, "b.c. rich")]
        [DataRow(1, "rogue")]
        [DataRow(0, "lucero")]
        [DataRow(0, "mitchell")]
        [DataRow(0, "kremona")]
        [DataRow(0, "lyons")]
        [DataRow(0, "yamaha")]
        public void GetElectricGuitarsWithQuantity(int quantity, object[] vNames)
        {
            var guitars = _repoProvider.ElectricGuitarRepository.FindByVendors(vNames as string[]);
            Assert.AreEqual(guitars.Count(), quantity);
        }

        [DataTestMethod]
        [DataRow(1, "b.c. rich")]
        [DataRow(1, "hofner")]
        [DataRow(1, "mitchell")]
        [DataRow(1, "rogue")]
        [DataRow(0, "lucero")]
        [DataRow(0, "the loar")]
        [DataRow(0, "kremona")]
        [DataRow(0, "lyons")]
        [DataRow(0, "yamaha")]
        public void GetBassGuitarsWithQuantity(int quantity, object[] vNames)
        {
            var guitars = _repoProvider.BassGuitarRepository.FindByVendors(vNames as string[]);
            Assert.AreEqual(guitars.Count(), quantity);
        }
    }
}
