using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Assignment01;

namespace Assignment01test
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void GetLength_Input3_Returns3()
        {
            //Arrange
            int length = 3;
            int width = 1;

            //Tesing the GetLength() Method (Test Case: 1)
            int expectedResult = length;

            Rectangle test_Rectangle = new Rectangle(length, width);

            //Act
            int actualResult = test_Rectangle.Getlength();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetLength_Input21_Returns21()
        {
            //Arrange
            int length = 21;
            int width = 1;

            //Tesing the GetLength() Method (Test Case: 1)
            int expectedResult = length;

            Rectangle test_Rectangle = new Rectangle(length, width);

            //Act
            int actualResult = test_Rectangle.Getlength();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetLength_Input10_Returns10()
        {
            //Arrange
            int length = 10;
            int width = 1;

            //Tesing the GetLength() Method (Test Case: 3)
            int expectedResult = length;

            Rectangle test_Rectangle = new Rectangle(length, width);

            //Act
            int actualResult = test_Rectangle.Getlength();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void SetLength_Input30_Returns30()
        {
            //Arrange
            int length = 30;
            int width = 1;

            //Tesing the SetLength() Method (Test Case: 1)
            int expectedResult = length;

            Rectangle test_Rectangle = new Rectangle(length, width);

            //Act
            int actualResult = test_Rectangle.SetLength(length);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void SetLength_Input53_Returns53()
        {
            //Arrange
            int length = 53;
            int width = 1;

            //Tesing the SetLength() Method (Test Case: 2)
            int expectedResult = length;

            Rectangle test_Rectangle = new Rectangle(length, width);

            //Act
            int actualResult = test_Rectangle.SetLength(length);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void SetLength_Input3_Returns3()
        {
            //Arrange
            int length = 3;
            int width = 1;

            //Tesing the SetLength() Method (Test Case: 3)
            int expectedResult = length;

            Rectangle test_Rectangle = new Rectangle(length, width);

            //Act
            int actualResult = test_Rectangle.SetLength(length);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }



        [Test]
        public void GetWidth_Input8_Returns8()
        {
            //Arrange
            int length = 1;
            int width = 8;

            //Tesing the GetWidth() Method (Test Case: 1)
            int expectedResult = width;

            Rectangle test_Rectangle = new Rectangle(length, width);

            //Act
            int actualResult = test_Rectangle.GetWidth();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetWidth_Input55_Returns55()
        {
            //Arrange
            int length = 1;
            int width = 55;

            //Tesing the GetWidth() Method (Test Case: 2)
            int expectedResult = width;

            Rectangle test_Rectangle = new Rectangle(length, width);

            //Act
            int actualResult = test_Rectangle.GetWidth();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetWidth_Input40_Returns40()
        {
            //Arrange
            int length = 1;
            int width = 40;

            //Tesing the GetWidth() Method (Test Case: 3)
            int expectedResult = width;

            Rectangle test_Rectangle = new Rectangle(length, width);

            //Act
            int actualResult = test_Rectangle.GetWidth();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void SetWidth_Input73_Returns73()
        {
            //Arrange
            int length = 1;
            int width = 73;

            //Tesing the SetWidth() Method (Test Case: 1)
            int expectedResult = width;

            Rectangle test_Rectangle = new Rectangle(length, width);

            //Act
            int actualResult = test_Rectangle.SetWidth(width);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void SetWidth_Input66_Returns66()
        {
            //Arrange
            int length = 1;
            int width = 66;

            //Tesing the SetWidth() Method (Test Case: 2)
            int expectedResult = width;

            Rectangle test_Rectangle = new Rectangle(length, width);

            //Act
            int actualResult = test_Rectangle.SetWidth(width);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void SetWidth_Input34_Returns34()
        {
            //Arrange
            int length = 1;
            int width = 34;

            //Tesing the SetWidth() Method (Test Case: 3)
            int expectedResult = width;

            Rectangle test_Rectangle = new Rectangle(length, width);

            //Act
            int actualResult = test_Rectangle.SetWidth(width);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetPerimeter_Input7and3_Returns20()
        {
            //Arrange
            int length = 7;
            int width = 3;

            //Tesing the GetPerimeter() Method (Test Case: 1)
            int expectedResult = 2 * (length + width);

            Rectangle test_Rectangle = new Rectangle(length, width);

            //Act
            int actualResult = test_Rectangle.GetPerimeter();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetPerimeter_Input5and4_Returns18()
        {
            //Arrange
            int length = 5;
            int width = 4;

            //Tesing the GetPerimeter() Method (Test Case: 2)
            int expectedResult = 2 * (length + width);

            Rectangle test_Rectangle = new Rectangle(length, width);

            //Act
            int actualResult = test_Rectangle.GetPerimeter();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetPerimeter_Input8and4_Returns24()
        {
            //Arrange
            int length = 8;
            int width = 4;

            //Tesing the GetPerimeter() Method (Test Case: 3)
            int expectedResult = 2 * (length + width);

            Rectangle test_Rectangle = new Rectangle(length, width);

            //Act
            int actualResult = test_Rectangle.GetPerimeter();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetArea_Input4and5_Returns20()
        {
            //Arrange
            int length = 4;
            int width = 5;

            //Tesing the GetArea() Method (Test Case: 1)
            int expectedResult = length * width;

            Rectangle test_Rectangle = new Rectangle(length, width);

            //Act
            int actualResult = test_Rectangle.GetArea();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetArea_Input6and7_Returns42()
        {
            //Arrange
            int length = 6;
            int width = 7;

            //Tesing the GetArea() Method (Test Case: 2)
            int expectedResult = length * width;

            Rectangle test_Rectangle = new Rectangle(length, width);

            //Act
            int actualResult = test_Rectangle.GetArea();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetArea_Input15and10_Returns150()
        {
            //Arrange
            int length = 15;
            int width = 10;

            //Tesing the GetArea() Method (Test Case: 3)
            int expectedResult = length * width;

            Rectangle test_Rectangle = new Rectangle(length, width);

            //Act
            int actualResult = test_Rectangle.GetArea();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

    }
}

