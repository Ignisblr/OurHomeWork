using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OurCreatures;

namespace OurCreatures.UnitTests
{
    [TestClass]
    public class CafeGirlTests
    {
        [TestMethod]
        public void GetSalary_ReturnsTrue()
        {
            //Arrange
            var polishPan = new PolishPan();
            polishPan.SetGoodMood("had sex two hours ago");

            var cafeGirl = new CafeGirl("Polina", polishPan);

            //Act
            var result = cafeGirl.GetSalary();

            //Assert
            Assert.AreEqual(result, "spoko");
        }

        [TestMethod]
        public void GetSalary_ReturnsFalse()
        {
            //Arrange
            var polishPan = new PolishPan();
            polishPan.SetBadMood("hadn`t sex by whole mounth");

            var cafeGirl = new CafeGirl("Janina", polishPan);

            //Act
            var result = cafeGirl.GetSalary();

            //Assert
            Assert.AreEqual(result, "mało");
        }
    }
}
