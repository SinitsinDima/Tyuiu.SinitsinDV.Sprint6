using Tyuiu.SinitsinDV.Sprint6.Task2.V8.Lib;
namespace Tyuiu.SinitsinDV.Sprint6.Task2.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetMassFunction()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            var res = ds.GetMassFunction(startValue, stopValue);
            double[] wait = { -11.22, -8.65, -4.76, -6.47, -2.98, 0, 1.82, 3.55, 6.99, 7.74, 9.03 };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}