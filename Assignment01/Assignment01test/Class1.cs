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
        public void GetLength_Input2_Returns2()
        {
            //Arrange
            int length = 2;
            int width = 1;

            //Tesing the GetLength() Method (Test Case: 1)
            int expectedResult = length;

            Nav test_Rectangle = new Nav(length, width);

            //Act
            int actualResult = test_Rectangle.Getlength();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetLength_Input12_Returns12()
        {
            //Arrange
            int length = 12;
            int width = 1;

            //Tesing the GetLength() Method (Test Case: 1)
            int expectedResult = length;

            Nav test_Rectangle = new Nav(length, width);

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

            Nav test_Rectangle = new Nav(length, width);

            //Act
            int actualResult = test_Rectangle.Getlength();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void SetLength_Input10_Returns10()
        {
            //Arrange
            int length = 10;
            int width = 1;

            //Tesing the SetLength() Method (Test Case: 1)
            int expectedResult = length;

            Nav test_Rectangle = new Nav(length, width);

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

            Nav test_Rectangle = new Nav(length, width);

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

            Nav test_Rectangle = new Nav(length, width);

            //Act
            int actualResult = test_Rectangle.SetLength(length);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }



        [Test]
        public void GetWidth_Input5_Returns5()
        {
            //Arrange
            int length = 1;
            int width = 5;

            //Tesing the GetWidth() Method (Test Case: 1)
            int expectedResult = width;

            Nav test_Rectangle = new Nav(length, width);

            //Act
            int actualResult = test_Rectangle.GetWidth();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetWidth_Input15_Returns15()
        {
            //Arrange
            int length = 1;
            int width = 15;

            //Tesing the GetWidth() Method (Test Case: 2)
            int expectedResult = width;

            Nav test_Rectangle = new Nav(length, width);

            //Act
            int actualResult = test_Rectangle.GetWidth();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetWidth_Input50_Returns50()
        {
            //Arrange
            int length = 1;
            int width = 50;

            //Tesing the GetWidth() Method (Test Case: 3)
            int expectedResult = width;

            Nav test_Rectangle = new Nav(length, width);

            //Act
            int actualResult = test_Rectangle.GetWidth();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void SetWidth_Input13_Returns13()
        {
            //Arrange
            int length = 1;
            int width = 13;

            //Tesing the SetWidth() Method (Test Case: 1)
            int expectedResult = width;

            Nav test_Rectangle = new Nav(length, width);

            //Act
            int actualResult = test_Rectangle.SetWidth(width);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void SetWidth_Input33_Returns33()
        {
            //Arrange
            int length = 1;
            int width = 33;

            //Tesing the SetWidth() Method (Test Case: 2)
            int expectedResult = width;

            Nav test_Rectangle = new Nav(length, width);

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

            Nav test_Rectangle = new Nav(length, width);

            //Act
            int actualResult = test_Rectangle.SetWidth(width);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetPerimeter_Input2and3_Returns10()
        {
            //Arrange
            int length = 2;
            int width = 3;

            //Tesing the GetPerimeter() Method (Test Case: 1)
            int expectedResult = 2 * (length + width);

            Nav test_Rectangle = new Nav(length, width);

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

            Nav test_Rectangle = new Nav(length, width);

            //Act
            int actualResult = test_Rectangle.GetPerimeter();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetPerimeter_Input8and2_Returns20()
        {
            //Arrange
            int length = 8;
            int width = 2;

            //Tesing the GetPerimeter() Method (Test Case: 3)
            int expectedResult = 2 * (length + width);

            Nav test_Rectangle = new Nav(length, width);

            //Act
            int actualResult = test_Rectangle.GetPerimeter();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetArea_Input3and5_Returns15()
        {
            //Arrange
            int length = 3;
            int width = 5;

            //Tesing the GetArea() Method (Test Case: 1)
            int expectedResult = length * width;

            Nav test_Rectangle = new Nav(length, width);

            //Act
            int actualResult = test_Rectangle.GetArea();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetArea_Input6and4_Returns24()
        {
            //Arrange
            int length = 6;
            int width = 4;

            //Tesing the GetArea() Method (Test Case: 2)
            int expectedResult = length * width;

            Nav test_Rectangle = new Nav(length, width);

            //Act
            int actualResult = test_Rectangle.GetArea();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetArea_Input10and5_Returns50()
        {
            //Arrange
            int length = 10;
            int width = 5;

            //Tesing the GetArea() Method (Test Case: 3)
            int expectedResult = length * width;

            Nav test_Rectangle = new Nav(length, width);

            //Act
            int actualResult = test_Rectangle.GetArea();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

    }
}

