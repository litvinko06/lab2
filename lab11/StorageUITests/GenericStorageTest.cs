using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework.Legacy;
using static Microsoft.ApplicationInsights.MetricDimensionNames.TelemetryContext;

namespace StorageUITests
{
    public class GenericStorageTest
    {
        private Item item;
        GenericStorage storage = new GenericStorage();

        [SetUp]
        public void TestSetup()
        {
            item = new Item();
            item.Name = "Mouses";
            item.Amount = 10;
            
            storage.Add(item);
        }

        [Test]
        public void MousesNameMousesTest()
        {
            string expected = "Mouses";
            string actual = item.Name;

            ClassicAssert.AreEqual(expected, actual);
        }

        [Test]
        public void MousesAMount10Test()
        {
            int expected = 10;
            int actual = item.Amount;

            ClassicAssert.AreEqual(expected, actual);
        }

        [Test]
        public void MousesAmountUpdateTo20Test()
        {
            item.Amount = 20;
            storage.Update(item);
            int expected = 20;
            int actual = item.Amount;

            ClassicAssert.AreEqual(expected, actual);
        }

        [Test]
        public void DeleteMousesTest()
        {
            int id = item.Id;
            storage.Delete(id);
            Item? expected = null;
            Item? actual = storage.GetById(id);

            ClassicAssert.AreEqual(expected, actual);
        }
    }
}