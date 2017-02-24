

using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace Kalkulacka.Test
{
    [TestFixture]
    public class KalkulackaTests
    {
        [Test]
        public void TestAddTwoNumbers()
        {
            Assert.AreEqual(Kalkulacka.AddNumbers(1, 2),9);
        }
    }
}
