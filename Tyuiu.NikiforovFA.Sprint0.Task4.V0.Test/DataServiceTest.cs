using Tyuiu.NikiforovFA.Sprint0.Task4.V0.Lib;
namespace Tyuiu.NikiforovFA.Sprint0.Task4.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedAdditionValid()
        {
            Assert.AreEqual(10, DataService.Addition(5, 5));
        }
        public void CheckedSubtracktionValid()
        {
            Assert.AreEqual(5, DataService.Subtraction(10, 5));
        }
        public void CheckedMultiplicationValid()
        {
            Assert.AreEqual(50, DataService.Multiplication(10, 5));
        }
        public void CheckedDevisionValid()
        {
            Assert.AreEqual(2, DataService.Division(10, 5));
        }
    }
}