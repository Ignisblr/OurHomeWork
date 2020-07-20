using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OurCreatures;

namespace OurCreatures.UnitTests
{
    [TestClass]
    public class CafeGirlTests
    {
        [TestMethod]
        public void GetSalary_PanIsSad_ReturnsTrue()
        {
            //Arrange
            PolishPan polishPan = new PolishPan();
            polishPan.SetGoodMood("had sex two hours ago");

            CafeGirl cafeGirl = new CafeGirl("Polina", polishPan);

            //Act
            string result = cafeGirl.GetSalary();

            //Assert
            Assert.AreEqual("spoko", result);
        }

        [TestMethod]
        public void GetSalary_PanIsSad_ReturnsFalse()
        {
            //Arrange
            PolishPan polishPan = new PolishPan();
            polishPan.SetBadMood("hadn`t sex by whole mounth");

            CafeGirl cafeGirl = new CafeGirl("Janina", polishPan);

            //Act
            string result = cafeGirl.GetSalary();

            //Assert
            Assert.AreEqual("mało", result);
        }

        [TestMethod]
        public void GetDriver_ReturnsPolishPan()
        {
            //Arrange
            CafeGirl cafeGirl = new CafeGirl("Lisa");

            //Act
            cafeGirl.SetDriver(new PolishPan() { Name = "Jacek" });
            var result = cafeGirl.GetDriver();

            //Assert
            Assert.AreEqual(new PolishPan().GetType(), result.GetType());
        }
    }
}
