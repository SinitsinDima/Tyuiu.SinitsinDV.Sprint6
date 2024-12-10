using Tyuiu.SinitsinDV.Sprint6.Task7.V28.Lib;
namespace Tyuiu.SinitsinDV.Sprint6.Task7.V28.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void TestMethod1()
    {
        string[] paths = { @"c:\Users", "ִלטענטי", "InPutFileTask7V28.csv" };
        string fullPath = Path.Combine(paths);

        FileInfo fileInfo = new FileInfo(fullPath);
        bool fileExist = fileInfo.Exists;
        bool wait = true;
        Assert.AreEqual(wait, fileExist);
    }
}