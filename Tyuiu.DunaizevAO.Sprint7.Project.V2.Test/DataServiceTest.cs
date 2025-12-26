using Tyuiu.DunaizevAO.Sprint7.Project.V2.Lib;

namespace Tyuiu.DunaizevAO.Sprint7.Project.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFile()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint7\TestFile.csv";

            string[,] result = ds.LoadFile(path);

            string wait = "15;25;84;21";
            string res = $"{result[0, 0]};{result[0, 1]};{result[0, 2]};{result[0, 3]}";

            Assert.AreEqual(wait, res);
        }
    }
}
