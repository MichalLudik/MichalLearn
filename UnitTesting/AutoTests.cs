using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;

namespace UnitTesting
{
    [TestFixture]
    class AutoTests
    {
        [Test]
        public void Startujeme()
        {
            Auto skoda = new Auto("skoda","biela");
            Assert.AreEqual(skoda.Nastartuj(),"vrci");
        }

        [Test]
        public void Startujeme2()
        {
            var auto = new Mock<IAuto>();
            var autoObjekt = auto.Object;

            auto.Setup(x => x.Nastartuj()).Returns("Halo");
            autoObjekt.Nastartuj();

            auto.Verify(x=>x.Nastartuj(),Times.AtLeastOnce);
            Assert.AreNotEqual(autoObjekt.Nastartuj(),"vrci");
        }

        [Test]
        public void VypocetSpotreby()
        {
            var auto = new Mock<IAuto>();

            auto.Setup(x => x.Spotreba(It.IsAny<int>(), It.IsAny<int>())).Returns(6);

            Assert.AreEqual(6,auto.Object.Spotreba(It.IsAny<int>(), It.IsAny<int>()));
            

        }
    }
}
