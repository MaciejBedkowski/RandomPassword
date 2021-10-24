using Microsoft.VisualStudio.TestTools.UnitTesting;
using RandomPasswordGenerator;

namespace Password.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CorrectLength()
        {
            string password;
            int passwordLength = 12;

            password = GeneratePassword.CreatePassword(passwordLength, true, true, true, true);

            Assert.AreEqual(passwordLength, password.Length);
        }
    }
}
