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

            string path = @"C:\DataSprint7\Owner.csv";
            FileInfo info = new FileInfo(path);
            bool res = info.Exists;
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}
