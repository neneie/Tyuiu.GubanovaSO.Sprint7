using Tyuiu.GubanovaSO.Sprint7.Project.V12.Lib;
namespace Tyuiu.GubanovaSO.Sprint7.Project.V12.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            string path = @"C:\DataSprint7\HUAWEIInPutFile.csv";

            string row = "BoDe-WDH9";
            int column = 1;
            string res = ds.CollectTextFromFile(path, row, column);


            string wait = "15,6";
            Assert.AreEqual(wait, res);
        }
        [Test]
        public void ValidCalcInt()
        {
            DataService ds = new DataService();

            string path = @"C:\DataSprint7\HUAWEIInPutFile.csv";

            int row = 1;
            int column = 1;
            string res = ds.CollectTextFromFileInt(path, row, column);


            string wait = "15,6";
            Assert.AreEqual(wait, res);
        }

    }
}