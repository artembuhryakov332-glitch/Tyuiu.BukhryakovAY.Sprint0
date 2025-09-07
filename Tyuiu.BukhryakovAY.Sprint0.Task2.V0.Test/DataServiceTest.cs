using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using Tyuiu.BukhryakovAY.Sprint0.Task2.V0.Lib;

namespace Tyuiu.BukhryakovAY.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
            public void ChechGetMessageValid()
            {
                var name = "Артем";
                var res = DataServise.GetMessage(name);
            Assert.AreEqual("Привет, Артем", res);
            }
    }
}
