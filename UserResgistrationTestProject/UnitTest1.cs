using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegistrationProblem;
using System;

namespace UserResgistrationTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow("Ayushi","^[A-Z]{1}[a-z]{2,}$","Valid")]
        [DataRow("Srivastava","^[A-Z]{1}[a-z]{2,}$", "Valid")]
        [DataRow("abc.xyz@bl.co.in", "^[a-z]{3,}[.a-z]*@[a-z]{2,}.[a-z]{2,}[.a-z]*$", "Valid")]
        [DataRow("+91 9999555511",@"^[+]?[0-9]{2}\s[0-9]{10}$", "Valid")]
        public void CheckValidationFor_FirstName_LastName_Email_Mobile_Password(string input, string pattern, string expected)
        {
                //Arrange
                PatternTest patternObj = new PatternTest();
                //Act
                string actual = patternObj.ValidatePattern(input, pattern);
                //Assert
                Assert.AreEqual(expected, actual);
        }
        
    }
}
