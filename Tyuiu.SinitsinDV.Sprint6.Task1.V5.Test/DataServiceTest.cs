using Tyuiu.SinitsinDV.Sprint6.Task1.V5.Lib;
namespace Tyuiu.SinitsinDV.Sprint6.Task1.V5.Test
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
            double[] wait = { 8.04, 6.68, 4.84, 1.76, 0.45, 0, -0.87, -2.42, -3.88, -6.83, -8.88 };
            CollectionAssert.AreEqual(wait, res);

        }
    }
}