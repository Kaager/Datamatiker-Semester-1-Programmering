using Pr15_Disaheim;
using System.Globalization;
using static Microsoft.TestPlatform.AdapterUtilities.HierarchyConstants;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        Book b1, b2, b3;
        Amulet a1, a2, a3;

        [TestInitialize]
        public void Init()
        {
            // Forcing the culture to be the one we use in the tests
            Thread.CurrentThread.CurrentCulture = new CultureInfo("da-DK");

            b1 = new Book("1");
            b2 = new Book("2", "Falling in Love with Yourself");
            b3 = new Book("3", "Spirits in the Night", 123.55);

            a1 = new Amulet("11");
            a2 = new Amulet("12", Level.High);
            a3 = new Amulet("13", Level.Low, "Capricorn");
        }

        [TestMethod]
        public void BookConstructorWithOneParameter()
        {
            Assert.AreEqual("ItemId: 1, Title: , Price: 0", b1.ToString());
        }
        [TestMethod]
        public void BookConstructorWithTwoParameters()
        {
            Assert.AreEqual("ItemId: 2, Title: Falling in Love with Yourself, Price: 0", b2.ToString());
        }
        [TestMethod]
        public void BookConstructorWithThreeParameters()
        {
            Assert.AreEqual("ItemId: 3, Title: Spirits in the Night, Price: 123,55", b3.ToString());
        }

        [TestMethod]
        public void AmuletConstructorWithOneParameter()
        {
            Assert.AreEqual("ItemId: 11, Quality: Medium, Design: ", a1.ToString());
        }
        [TestMethod]
        public void AmuletConstructorWithTwoParameters()
        {
            Assert.AreEqual("ItemId: 12, Quality: High, Design: ", a2.ToString());
        }
        [TestMethod]
        public void AmuletConstructorWithThreeParameters()
        {
            Assert.AreEqual("ItemId: 13, Quality: Low, Design: Capricorn", a3.ToString());
        }
    }


}
