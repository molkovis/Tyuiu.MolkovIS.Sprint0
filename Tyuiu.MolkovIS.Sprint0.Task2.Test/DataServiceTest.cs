using Tyuiu.MolkovIS.Sprint0.Task2.V0.Lib;

namespace Tyuiu.MolkovIS.Sprint0.Task2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessage()
        {
            string name = "Иван";
            string res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Иван", res);

        }
    }
}
