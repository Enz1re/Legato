using Legato.DAL.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Legato.DAL.Tests
{
    /*
        Test class for testing ValidateClassicalGuitarStringTypeAttribute
        Valid values: "Nylon", "Fluorocarbon"
    */
    [TestClass]
    public class TestValidateClassicalGuitarStringTypeAttribute
    {
        private static ValidateClassicalGuitarStringTypeAttribute _validationAttribute = new ValidateClassicalGuitarStringTypeAttribute();

        [DataTestMethod]
        [DataRow("Nylon")]
        [DataRow("Fluorocarbon")]
        public void ValidateStringTypeGetTrue(string stringType)
        {
            Assert.IsTrue(_validationAttribute.IsValid(stringType));
        }

        [DataTestMethod]
        [DataRow("")]
        [DataRow("Nilon")]
        [DataRow("Steel")]
        [DataRow("Metal")]
        [DataRow("Florocarbon")]
        public void ValidateStringTypeGetFalse(string stringType)
        {
            Assert.IsFalse(_validationAttribute.IsValid(stringType));
        }
    }
}
