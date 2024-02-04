using Лабораторная_работа__9;
namespace Lab9.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void UnaryPlusTest()
        {
            //Arrange
            Rectangle rec = new Rectangle(10, 200);

            //Act
            rec++;

            //Assert
            Assert.AreEqual(11, rec.Length);
            Assert.AreEqual(201, rec.Width);
        }

        [TestMethod]
        public void UnaryMinusTest()
        {
            //Arrange
            Rectangle rec = new Rectangle(10, 200);

            //Act
            rec--;

            //Assert
            Assert.AreEqual(9, rec.Length);
            Assert.AreEqual(199, rec.Width);
        }

        [TestMethod]
        public void BinaryPlusTest()
        {
            //Arrange
            Rectangle rec = new Rectangle(10, 200);

            //Act
            rec = rec + 13;

            //Assert
            Assert.AreEqual(23, rec.Length);
            Assert.AreEqual(213, rec.Width);
        }

        [TestMethod]
        public void BinaryMinusTest()
        {
            //Arrange
            Rectangle rec = new Rectangle(20, 200);

            //Act
            rec = rec - 10;

            //Assert
            Assert.AreEqual(10, rec.Length);
            Assert.AreEqual(190, rec.Width);
        }

        [TestMethod]
        public void NoNegativeTest()
        {
            //Arrange
            //Act
            Rectangle rec = new Rectangle(-10, -200);
            Rectangle expected = new Rectangle(0, 0);
            //Assert
            Assert.AreEqual(expected, rec);
        }

        [TestMethod]
        public void SquareTest() //проверка на квадрат
        {
            //Arrange
            Rectangle rec = new Rectangle(200, 200);

            //Act
            bool square = rec;
            bool t = true;

            //Assert
            Assert.AreEqual(t, square);
        }

        [TestMethod]
        public void AddSizeTest()
        {
            //Arrange
            Rectangle rec = new Rectangle(10, 200);

            //Act
            rec.AddSize(rec.Length, rec.Width, 4);

            //Assert
            Assert.AreEqual(40, rec.Length);
            Assert.AreEqual(800, rec.Width);
        }

        [TestMethod]
        public void StaticAddSizeTest()
        {
            //Arrange
            Rectangle rec = new Rectangle(10, 200);

            //Act
            Rectangle.AddSize(rec, 4);

            //Assert
            Assert.AreEqual(40, rec.Length);
            Assert.AreEqual(800, rec.Width);
        }

        [TestMethod]
        public void NoParametrsTest() //конструктор без параметров
        {
            //Arrange
            Rectangle rec = new Rectangle();

            //Act
            Rectangle rectest = new Rectangle(0,0);
            //Assert
            Assert.AreEqual(rectest.Length, rec.Length);
            Assert.AreEqual(rectest.Width, rec.Width);
        }

        [TestMethod]
        public void AreaCircleTest()
        {
            //Arrange
            Rectangle rec = new Rectangle(10, 10);

            //Act
            double area = rec.AreaCircle;
            double area2 = (double)rec;
            //Assert
            Assert.AreEqual(area, area2);

        }

        [TestMethod]
        public void CopyConstructorTest()
        {
            //Arrange
            Rectangle rec = new Rectangle(10, 20);

            //Act
            Rectangle rec2 = new Rectangle(rec);
            //Assert
            Assert.AreEqual(rec2, rec);
        }
        [TestMethod]
        public void BinaryPlusTest2()
        {
            //Arrange
            Rectangle rec = new Rectangle(10, 20);

            //Act
            rec = 100 + rec;
            //Assert
            Assert.AreEqual(110, rec.Length);
            Assert.AreEqual(120, rec.Width);
        }
        [TestMethod]
        public void BinaryMinusTest2()
        {
            //Arrange
            Rectangle rec = new Rectangle(10, 20);

            //Act
            rec = 100 - rec;
            //Assert
            Assert.AreEqual(90, rec.Length);
            Assert.AreEqual(80, rec.Width);
        }

        [TestMethod]
        public void ArrayConcructorTest() 
        {
            //Arrange
            RectangleArray arr = new RectangleArray();
            //Act
            //Assert
            Assert.AreEqual(0, arr.Length);
        }

        [TestMethod]
        public void ArrayConcructorTest2()
        {
            RectangleArray arr = new RectangleArray(153);
            Assert.AreEqual(153, arr.Length);
        }

        [TestMethod]
        public void ArrayConcructorTest3()
        {
            RectangleArray arr = new RectangleArray(15);
            RectangleArray arr2 = new RectangleArray(arr);
            Assert.AreEqual(arr2.Length, arr.Length);
        }

        [TestMethod]
        public void ArrayIndexTest() 
        { 
            RectangleArray arr = new RectangleArray(5);
            arr[1] = new Rectangle(1, 1);
            Rectangle rec = new Rectangle(1, 1);
            Assert.AreEqual(arr[1], rec);
        }

        [TestMethod]
        public void AverageCircleTest()
        {
            //Arrange
            RectangleArray array = new RectangleArray(10);

            //Act
            double area = Program.AverageCircle(array);
            double areaCircle;
            double sumAreas = 0;
            double averageCircle;
            for (int i = 0; i < array.Length; i++)
            {
                areaCircle = Math.PI * Math.Pow(Math.Sqrt(array[i].Width * array[i].Width * array[i].Length * array[i].Length) / 2, 2);
                sumAreas += areaCircle;
            }
            averageCircle = sumAreas / array.Length;
            //Assert
            Assert.AreEqual(area, averageCircle);
        }
    }
}