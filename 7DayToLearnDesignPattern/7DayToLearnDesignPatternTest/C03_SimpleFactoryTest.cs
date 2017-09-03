using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _7DayToLearnDesignPattern.C03_SimpleFactory;

namespace _7DayToLearnDesignPatternTest
{
    namespace C03_SimpleFactoryTest
    {
        [TestClass]
        public class UnitTest1
        {
            [TestMethod]
            public void TestMethod1()
            {
                Adventurer memberA = TrainingCamp.trainAdventurer("Archer");
                Adventurer memberB = TrainingCamp.trainAdventurer("Warrior");
                Assert.AreEqual(memberA.getType(), "Archer");
                Assert.AreEqual(memberB.getType(), "Warrior");
            }
        }
    }
}
