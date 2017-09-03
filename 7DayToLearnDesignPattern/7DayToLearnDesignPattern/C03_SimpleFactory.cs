using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7DayToLearnDesignPattern
{
    // 簡單工廠模式 Simple Factory
    namespace C03_SimpleFactory
    {
        public interface Adventurer
        {
            string getType();
        }

        //弓箭手
        public class Archer : Adventurer
        {
            public String getType()
            {
                Console.WriteLine("我是弓箭手");
                return this.GetType().Name;
            }
        }

        //鬥士
        public class Warrior : Adventurer
        {
            public String getType()
            {
                Console.WriteLine("我是鬥士");
                return this.GetType().Name;
            }
        }

        public class TrainingCamp
        {
            public static Adventurer trainAdventurer(String type)
            {
                switch (type)
                {
                    case "Archer":
                        Console.WriteLine("訓練一個弓箭手");
                        return new Archer();
                    case "Warrior":
                        Console.WriteLine("訓練一個鬥士");
                        return new Warrior();
                    default:
                        return null;
                }
            }
        }

        public class Test
        {
            public static void TestFunction()
            {
                Adventurer memberA = TrainingCamp.trainAdventurer("Archer");
                Adventurer memberB = TrainingCamp.trainAdventurer("Warrior");
                Assert.AreEqual(memberA.getType(), "Archer");
                Assert.AreEqual(memberB.getType(), "Warrior");
                Console.ReadLine();
            }

        }
    }
}
