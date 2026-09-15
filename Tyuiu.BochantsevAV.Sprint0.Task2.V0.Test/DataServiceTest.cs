using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.BochantsevAV.Sprint0.Task2.V0.Lib;



namespace Tyuiu.BochantsevAV.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Артем";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Артем", res);
        }
    }
}
