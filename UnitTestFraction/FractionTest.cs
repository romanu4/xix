using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibraryFraction;

namespace UnitTestFraction
{
    [TestClass]
    public class FractionTest
    {
        /// <summary>
        /// должно вывести 1/10
        /// </summary>
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            string vxod = "1/10";
            string expected = "1/10";
            //Act
            string actual = Fraction.FixWrongResult(vxod);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// проверка на отсутствие букв
        /// </summary>
        [TestMethod]
        public void NoLetter()
        {
            //Arrange
            string vxod = "b/10";
            //Act
           Action actual = () => Fraction.FixWrongResult(vxod);
            //Assert
            Assert.ThrowsException<Exception>(actual);
        }
        /// <summary>
        /// должна быть дробь
        /// </summary>
        [TestMethod]
        public void FixWrongResult_MustBeenSlach_ReturnException()
        {
            //Arrange
            string vxod = "1010";
            //Act
            Action actual = () => Fraction.FixWrongResult(vxod);
            //Assert
            Assert.ThrowsException<Exception>(actual);
        }
        /// <summary>
        /// должно быть только 2 значения
        /// </summary>
        [TestMethod]
        public void NoMoreTwo()
        {
            //Arrange
            string vxod = "35/10/10/25";
            //Act
            Action actual = () => Fraction.FixWrongResult(vxod);
            //Assert
            Assert.ThrowsException<Exception>(actual);
        }
        /// <summary>
        /// проверка на наличие нетолько слеша
        /// </summary>
        [TestMethod]
        public void MustBeenNumber()
        {
            //Arrange
            string vxod = "/";
            //Act
            Action actual = () => Fraction.FixWrongResult(vxod);
            //Assert
            Assert.ThrowsException<Exception>(actual);
        }
        /// <summary>
        /// не пустое
        /// </summary>
        [TestMethod]
        public void Notnull()
        {
            //Arrange
            string vxod = "";
            //Act
            Action actual = () => Fraction.FixWrongResult(vxod);
            //Assert
            Assert.ThrowsException<Exception>(actual);
        }
    }
}
