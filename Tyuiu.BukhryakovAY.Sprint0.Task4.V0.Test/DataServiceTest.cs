using Tyuiu.BukhryakovAY.Sprint0.Task4.V0.Lib;
namespace Tyuiu.BukhryakovAY.Sprint0.Task4.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedAdditionValid()
        {
            Assert.AreEqual(10, DataService.Addition(5, 5));
        }
        public void CheckedSubtractionValid()
        {
            Assert.AreEqual(5, DataService.Subtruction(10, 5));
        }
        public void CheckedMultiplicateValid()
        {
            Assert.AreEqual(75, DataService.Multiplication(15, 5));
        }
        public void CheckedDivisionValid()
        {
            Assert.AreEqual(5, DataService.Division(50, 10));
        }
    }
}
