using Legato.DAL.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Legato.DAL.Tests
{
    /*
        Test class for testing ValidateBassStringNumberAttribute
        Valid values: 1, 4, 5, 7, 8, 10 
    */
    [TestClass]
    public class TestValidateBassStringNumberAttribute
    {
        private static ValidateBassStringNumberAttribute _validationAttribute = new ValidateBassStringNumberAttribute();

        [DataTestMethod]
        [DataRow((byte)1)]
        [DataRow((byte)4)]
        [DataRow((byte)5)]
        [DataRow((byte)7)]
        [DataRow((byte)8)]
        [DataRow((byte)10)]
        public void ValidateStringsGetTrue(byte strings)
        {
            Assert.IsTrue(_validationAttribute.IsValid(strings));
        }

        [DataTestMethod]
        [DataRow((byte)0)]
        [DataRow((byte)2)]
        [DataRow((byte)6)]
        [DataRow((byte)11)]
        [DataRow((byte)15)]
        [DataRow((byte)20)]
        public void ValidateStringsGetFalse(byte strings)
        {
            Assert.IsFalse(_validationAttribute.IsValid(strings));
        }
    }
}
