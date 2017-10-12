using Legato.DAL.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Legato.DAL.Tests
{
    /*
        Test class for testing TestValidateSoundboxAttribute
        Valid values: "Single", "Humbucker"
    */
    [TestClass]
    public class TestValidateSoundboxAttribute
    {
        private static ValidateSoundboxAttribute _validationAttribute = new ValidateSoundboxAttribute();

        [DataTestMethod]
        [DataRow("Single")]
        [DataRow("Humbucker")]
        public void ValidateSoundboxGetTrue(string soundbox)
        {
            Assert.IsTrue(_validationAttribute.IsValid(soundbox));
        }

        [DataTestMethod]
        [DataRow("")]
        [DataRow("Singl")]
        [DataRow("Rogue")]
        [DataRow("Hambucker")]
        public void ValidateSoundboxGetFalse(string soundbox)
        {
            Assert.IsFalse(_validationAttribute.IsValid(soundbox));
        }
    }
}
