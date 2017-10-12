using Legato.DAL.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Legato.DAL.Tests
{
    [TestClass]
    public class TestCaseInsensitiveStringEqualityComparer
    {
        private static CaseInsensitiveStringEqualityComparer _comparer = new CaseInsensitiveStringEqualityComparer();

        [DataTestMethod]
        [DataRow("", "")]
        [DataRow("a", "A")]
        [DataRow("aAaac", "AAAAC")]
        [DataRow("s0s0s0", "s0s0s0")]
        [DataRow("AbcdAbcdAbcd", "aBcdaBcdaBcd")]
        public void CompareStringsAndGetTrue(string s1, string s2)
        {
            Assert.IsTrue(_comparer.Equals(s1, s2));
        }

        [DataTestMethod]
        [DataRow("", "1")]
        [DataRow("a", "b")]
        [DataRow("aAaac", "AAAA")]
        [DataRow("s0s0s0", "s1s1s1")]
        [DataRow("AbcdAbcdAbcd", "AbcdAbcdAbc")]
        public void CompareStringsAndGetFalse(string s1, string s2)
        {
            Assert.IsFalse(_comparer.Equals(s1, s2));
        }
    }
}
