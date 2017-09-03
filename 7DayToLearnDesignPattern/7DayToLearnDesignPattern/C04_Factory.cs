using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7DayToLearnDesignPattern
{
    // 工廠模式 Factory
    namespace C04_Factory
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

        public interface TrainingCamp
        {
            Adventurer trainAdventurer();
        }

        // 弓箭手訓練營
        public class ArcherTrainingCamp : TrainingCamp
        {
            public Adventurer trainAdventurer()
            {
                Console.WriteLine("訓練一個弓箭手");
                return new Archer();
            }
        }

        // 鬥士訓練營
        public class WarriorTrainingCamp : TrainingCamp
        {
            public Adventurer trainAdventurer()
            {
                Console.WriteLine("訓練一個鬥士");
                return new Warrior();
            }
        }

        public class Test
        {
            public static void TestFunction()
            {
                Console.WriteLine("==========工廠模式測試==========");
                TrainingCamp trainingCamp = new ArcherTrainingCamp();
                Adventurer memberA = trainingCamp.trainAdventurer();
                trainingCamp = new WarriorTrainingCamp();
                Adventurer memberB = trainingCamp.trainAdventurer();
                Assert.AreEqual(memberA.getType(), "Archer");
                Assert.AreEqual(memberB.getType(), "Warrior");
                Console.ReadLine();
            }

        }
    }
}
