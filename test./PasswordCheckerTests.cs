using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryPassword;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryPassword.Tests
{
    [TestClass()]
    public class PasswordCheckerTests
    {
        [TestMethod()]
        public void Check_8Symbols_ReturnTrue()
        {
            //Arrange
            string password = "ASqw12$$";
            bool expected = true;
            //act
            bool actual =
                PasswordChecker.validatePassword(password);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]

        public void Check_4Symbols_ReturnsFalse()
        {
            //Arrange
            string password = "Aq1$";
            //bool expected = false;
            //act
            bool actual =
                PasswordChecker.validatePassword(password);
            //assert
            Assert.IsFalse(actual);
            
        }
        [TestMethod()]

        public void Check_21Symbols_ReturnsFalse()
        {
            //Arrange
            string password = "1234567890qwertyuiopz";
            //bool expected = false;
            //act
            bool actual =
                PasswordChecker.validatePassword(password);
            //assert
            Assert.IsFalse(actual);

        }

        [TestMethod()]
        
        public void Check_digits_ReturnsTrue()
        {
            //Arrange
            string password = "ASqw12$$";
            bool expected = true;
            //act
            bool actual =
                PasswordChecker.validatePassword(password);
            //assert
          
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]

        public void Check_notdigits_ReturnsFalse()
        {
            //Arrange
            string password = "qwerty";
            //bool expected = false;
            //act
            bool actual =
                PasswordChecker.validatePassword(password);
            //assert
            Assert.IsFalse(actual);

        }



        [TestMethod()]

        public void Check_low_ReturnsTrue()
        {
            //Arrange
            string password = "ASqw12$$";
            bool expected = true;
            //act
            bool actual =
                PasswordChecker.validatePassword(password);
            //assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]

        public void Check_notlow_ReturnsFalse()
        {
            //Arrange
            string password = "QWERTY";
            //bool expected = false;
            //act
            bool actual =
                PasswordChecker.validatePassword(password);
            //assert
            Assert.IsFalse(actual);

        }


        [TestMethod()]

        public void Check_up_ReturnsTrue()
        {
            //Arrange
            string password = "ASqw12$$";
            bool expected = true;
            //act
            bool actual =
                PasswordChecker.validatePassword(password);
            //assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]

        public void Check_notup_ReturnsFalse()
        {
            //Arrange
            string password = "qwerty";
            //bool expected = false;
            //act
            bool actual =
                PasswordChecker.validatePassword(password);
            //assert
            Assert.IsFalse(actual);

        }


        [TestMethod()]

        public void Check_specsymbols_ReturnsTrue()
        {
            //Arrange
            string password = "ASqw12$$";
            bool expected = true;
            //act
            bool actual =
                PasswordChecker.validatePassword(password);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]

        public void Check_notspecsymbols_ReturnsFalse()
        {
            //Arrange
            string password = "qwerty";
            //bool expected = false;
            //act
            bool actual =
                PasswordChecker.validatePassword(password);
            //assert
            Assert.IsFalse(actual);

        }


    }
}
