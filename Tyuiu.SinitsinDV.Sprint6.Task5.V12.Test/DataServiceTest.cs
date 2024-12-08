using Tyuiu.SinitsinDV.Sprint6.Task5.V12.Lib;
namespace Tyuiu.SinitsinDV.Sprint6.Task5.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void LoadFromDataFile()
        {
            string[] paths = { @"c:\Users", "ִלטענטי", "source", "repos", "Tyuiu.SinitsinDV.Sprint6", "Tyuiu.SinitsinDV.Sprint6.Task5.V12", "bin", "Debug", "InPutFileTask5V12.txt" };
            string fullPath = Path.Combine(paths);

            FileInfo fileInfo = new FileInfo(fullPath);
            bool fileExist = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExist);
        }
    }
}