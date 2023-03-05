using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegistrationProblem;
using System;

namespace UserResgistrationTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [TestCategory("Validation")]
        [DataRow("Ayushi", "^[A-Z]{1}[a-z]{2,}$", "Valid")]//First name
        [DataRow("Srivastava", "^[A-Z]{1}[a-z]{2,}$", "Valid")]//Last name
        [DataRow("abc.xyz@bl.co.in", "^[a-z]{3,}[.a-z]*@[a-z]{2,}.[a-z]{2,}[.a-z]*$", "Valid")]//Email
        [DataRow("+91 9999555511", @"^[+]?[0-9]{2}\s[0-9]{10}$", "Valid")]//Mobile number
        [DataRow("ahjhjA@5hg", "^(?=.*[A-Z])(?=.*[0-9])(?=.*[@#$?^&]).{8,}$", "Valid")]//Password
        [DataRow("ahjhjA5hg", "^(?=.*[A-Z])(?=.*[0-9])(?=.*[@#$?^&]).{8,}$", "Invalid")]//Password
        public void CheckValidationFor_FirstName_LastName_Email_Mobile_Password(string input, string pattern, string expected)
        {
                //Arrange
                PatternTest patternObj = new PatternTest();
                //Act
                string actual = patternObj.ValidatePattern(input, pattern);
                //Assert
                Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("Validation")]
        public void CheckValidationForMultipleEmails()
        {
            //Arrange
            string[] input = {"abc@yahoo.com,","abc-100@yahoo.com,","abc.100@yahoo.com","abc111@abc.com,","abc-100@abc.net,","abc.100@abc.com.au","abc.100@abc.com.au","abc@1.com,","abc@gmail.com.com"};
            string pattern = "^[a-z]{3,}[.+-a-z0-9]*@[a-z0-9]{1,}.[a-z]{2,}[.,a-z]*$";
            string expected = "Valid";
            PatternTest patternObj = new PatternTest();
            foreach (string email in input)
            {
                //Act
                string actual = patternObj.ValidatePattern(email, pattern);
                //Assert
                Assert.AreEqual(expected, actual);
            }
        }

        [TestMethod]
        [TestCategory("Exception")]
        [DataRow("Ayushi", "^[A-Z]{1}[a-z]{2,}$", "Valid")]//First name
        [DataRow("", "^[A-Z]{1}[a-z]{2,}$", "Input is empty")]//Last name
        [DataRow(null, @"^[+]?[0-9]{2}\s[0-9]{10}$", "Input is null")]//Mobile number
        public void CheckValidationFor_FirstName_LastName_Email_Mobile_Password_UsingException(string input, string pattern, string expected)
        {
            try
            {
                //Arrange
                PatternTest patternObj = new PatternTest();
                //Act
                string actual = patternObj.ValidatePattern(input, pattern);
                //Assert
                Assert.AreEqual(expected, actual);
            }
            catch(CustomException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
        [TestMethod]
        [TestCategory("Lambda Validation")]
        [DataRow("Ayushi", "^[A-Z]{1}[a-z]{2,}$", "Valid")]//First name
        [DataRow("Srivastava", "^[A-Z]{1}[a-z]{2,}$", "Valid")]//Last name
        [DataRow("abc.xyz@bl.co.in", "^[a-z]{3,}[.a-z]*@[a-z]{2,}.[a-z]{2,}[.a-z]*$", "Valid")]//Email
        [DataRow("+91 9999555511", @"^[+]?[0-9]{2}\s[0-9]{10}$", "Valid")]//Mobile number
        [DataRow("ahjhjA@5hg", "^(?=.*[A-Z])(?=.*[0-9])(?=.*[@#$?^&]).{8,}$", "Valid")]//Password
        [DataRow("ahjhjA5hg", "^(?=.*[A-Z])(?=.*[0-9])(?=.*[@#$?^&]).{8,}$", "Invalid")]//Password
        public void CheckValidationFor_FirstName_LastName_Email_Mobile_Password_Using_LambdaExpression(string input, string pattern, string expected)
        {
            //Arrange
            PatternTest patternObj = new PatternTest();
            //Act
            string actual = patternObj.Validation_Lambda(input, pattern);
            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
