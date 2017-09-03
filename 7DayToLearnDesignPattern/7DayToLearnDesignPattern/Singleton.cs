using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// **************************************************
//
// 多執行緒的情況下可能會有問題。
//
// **************************************************
namespace _7DayToLearnDesignPattern
{
    // 單例模式 Singleton
    class SingletonGreed
    {
        // 一開始就建立實體物件
        private static SingletonGreed instance = new SingletonGreed();

        // private constructor，使其他程式無法使用new來取得新的實體物件
        private SingletonGreed() { }

        // 提供方法來獲得實體物件
        private static SingletonGreed getInstance()
        {
            return instance;
        }
    }

    // 單例模式2，使用時才建立物件
    class SingletonGreed2
    {
        // 先不建立實體物件
        private static SingletonGreed2 instance;

        // private constructor，使其他程式無法使用new來取得新的實體物件
        private SingletonGreed2() { }

        // 提供方法來獲得實體物件
        private static SingletonGreed2 getInstance()
        {
            // 第一次被呼叫時，instance為null，建立物件
            if (instance == null)
            {
                instance = new SingletonGreed2();
            }
            return instance;
        }
    }
}
