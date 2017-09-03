using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7DayToLearnDesignPattern
{
    // 抽象工廠模式 Abstract Factory
    namespace C05_AbstractFactory
    {
        // 上衣界面
        public abstract class Clothes
        {
            protected int def; //防禦力

            public void setDef(int val)
            {
                def = val;
            }

            public void display()
            {
                Console.WriteLine(this.GetType().Name + " def = " + def);
            }
        }

        // 盔甲 - 鬥士上衣
        public class Armor : Clothes
        {

        }

        // 皮甲 - 弓箭手上衣
        public class Leather : Clothes
        {

        }

        public abstract class Weapon
        {
            protected int atk; // 攻擊力
            protected int range; // 攻擊範圍

            public void setAtk(int val)
            {
                atk = val;
            }

            public void setRange(int val)
            {
                range = val;
            }

            public void display()
            {
                Console.WriteLine(this.GetType().Name + " atk = " + atk + ", range = " + range);
            }
        }

        // 長劍 - 鬥士武器
        public class LongSword : Weapon
        {

        }

        // 弓 - 弓箭手武器
        public class Bow : Weapon
        {

        }

        // 武器工廠界面
        public interface EquipFactory
        {
            Weapon productWeapon();
            Clothes productClothes();
        }

        // 鬥士裝備工廠
        public class WarriorEquipFactory : EquipFactory
        {
            public Weapon productWeapon()
            {
                Weapon product = new LongSword();
                product.setAtk(10);
                product.setRange(1);
                return product;
            }

            public Clothes productClothes()
            {
                Clothes product = new Armor();
                product.setDef(10);
                return product;
            }
        }

        // 弓箭手裝備工廠
        public class ArcherEquipFactory : EquipFactory
        {
            public Weapon productWeapon()
            {
                Weapon product = new Bow();
                product.setAtk(10);
                product.setRange(10);
                return product;
            }

            public Clothes productClothes()
            {
                Clothes product = new Leather();
                product.setDef(5);
                return product;
            }
        }

        // ##################################################
        //
        // 以下部分與抽象裝備工廠無關
        //
        // ##################################################

        public abstract class Adventurer
        {
            protected Weapon weapon;
            protected Clothes clothes;

            public abstract void display();

            public void setWeapon(Weapon item)
            {
                weapon = item;
            }

            public void setClothes(Clothes item)
            {
                clothes = item;
            }
        }

        //弓箭手
        public class Archer : Adventurer
        {
            public override void display()
            {
                Console.WriteLine("我是弓箭手，裝備：");
                weapon.display();
                clothes.display();

            }
        }

        //鬥士
        public class Warrior : Adventurer
        {
            public override void display()
            {
                Console.WriteLine("我是鬥士，裝備：");
                weapon.display();
                clothes.display();
            }
        }

        // 工廠界面 - 冒險者訓練營
        public interface TrainingCamp
        {
            Adventurer trainAdventurer();
        }

        // 實體工廠 - 弓箭手訓練營
        public class ArcherTrainingCamp : TrainingCamp
        {
            private static EquipFactory factory = new ArcherEquipFactory();

            public Adventurer trainAdventurer()
            {
                Console.WriteLine("訓練一個弓箭手");
                Archer archer = new Archer();

                archer.setWeapon(factory.productWeapon());
                archer.setClothes(factory.productClothes());

                return archer;
            }
        }

        // 實體工廠 - 鬥士訓練營
        public class WarriorTrainingCamp : TrainingCamp
        {
            private static EquipFactory factory = new WarriorEquipFactory();

            public Adventurer trainAdventurer()
            {
                Console.WriteLine("訓練一個鬥士");
                Warrior warrior = new Warrior();

                warrior.setWeapon(factory.productWeapon());
                warrior.setClothes(factory.productClothes());

                return warrior;
            }
        }

        public class Test
        {
            public static void TestFunction()
            {
                Console.WriteLine("==========抽象工廠模式測試==========");
                TrainingCamp trainingCamp = new ArcherTrainingCamp();
                Adventurer archer = trainingCamp.trainAdventurer();

                trainingCamp = new WarriorTrainingCamp();
                Adventurer warrior = trainingCamp.trainAdventurer();
                archer.display();
                warrior.display();
                Console.ReadLine();
            }

        }
    }
}
