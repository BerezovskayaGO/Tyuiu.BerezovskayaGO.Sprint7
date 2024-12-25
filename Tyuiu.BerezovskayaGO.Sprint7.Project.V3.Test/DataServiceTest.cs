using Tyuiu.BerezovskayaGO.Sprint7.Project.V3.Lib;
namespace Tyuiu.BerezovskayaGO.Project.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string path = @"C:\Users\Admin\source\repos\Tyuiu.BerezovskayaGO.Sprint7\Tyuiu.BerezovskayaGO.Sprint7.Project.V3\bin\Debug\net8.0-windows\DataSprint7\Inform.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            Assert.AreEqual(true, fileExist);
        }
    }
}