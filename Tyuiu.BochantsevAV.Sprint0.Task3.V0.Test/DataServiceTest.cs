using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.BochantsevAV.Sprint0.Task3.V0.Lib;


namespace Tyuiu.BochantsevAV.Sprint0.Task3.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedValid() 
        {
            Assert.AreEqual(10, DataService.Sum(5, 5));
        }
    }
}
