using Tyuiu.SinitsinDV.Sprint6.Task3.V24.Lib;
namespace Tyuiu.SinitsinDV.Sprint6.Task3.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[,] matrix = new int[5, 5]
            {
                {-17, -6, 10, 5, 3},
                {-10, -14, 10, -7, -3},
                {-19, 9, 8, -17, -9},
                {-19, -5, -9, -18, 14},
                {17, 12, 11, 12, 2}
            };
            var res = ds.Calculate(matrix);
            int[,] wait = new int[5, 5]
            {
                {-17, -6, 10, 5, 3},
                {0, 0, 0, -7, -3},
                {-19, 9, 8, -17, -9},
                {-19, -5, -9, -18, 14},
                {17, 12, 11, 12, 2}
            };
            Assert.AreEqual(0, matrix[1, 0]);
            Assert.AreEqual(0, matrix[1, 1]);
            Assert.AreEqual(0, matrix[1, 2]);
            Assert.AreEqual(-7, matrix[1, 3]);
            Assert.AreEqual(-3, matrix[1, 4]);







        }
    }
}