using Tyuiu.NikiforovFA.Sprint0.Task2.V0.Lib;
namespace Tyuiu.NikiforovFA.Sprint0.Task2.V0.test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMassageValid()
        {
            var name = "Федор";
            var res = DataService.GetMassage(name);
            Assert.AreEqual("Привет, Федор ", res);
        }
    }
}