using Legato.DAL.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Legato.DAL.Tests
{
    /*
        Test class for testing TestValidateSoundboxAttribute
        Valid values: 6, 7, 8, 10, 12
    */
    [TestClass]
    public class TestValidateStringNumberAttribute
    {
        private static ValidateStringNumberAttribute _validationAttribute = new ValidateStringNumberAttribute();

        [DataTestMethod]
        [DataRow((byte)6)]
        [DataRow((byte)7)]
        [DataRow((byte)8)]
        [DataRow((byte)10)]
        [DataRow((byte)12)]
        public void ValidateStringNumberGetTrue(byte strings)
        {
            Assert.IsTrue(_validationAttribute.IsValid(strings));
        }

        [DataTestMethod]
        [DataRow((byte)0)]
        [DataRow((byte)1)]
        [DataRow((byte)3)]
        [DataRow((byte)4)]
        [DataRow((byte)5)]
        [DataRow((byte)11)]
        [DataRow((byte)13)]
        public void ValidateStringNumberGetFalse(byte strings)
        {
            Assert.IsFalse(_validationAttribute.IsValid(strings));
        }
    }
}
