using System;
using System.Collections.Generic;
using System.Text;

namespace ZqCSharpDesignPattern.BehavioralPattern.C0902_MementoPattern
{
    class C0902MementoPattern : CodeFramework
    {
        protected override void RunCode()
        {
            Test01();
        }

        private void Test01()
        {
            Originator o1 = new Originator();
            Caretaker c1 = new Caretaker();

            o1.Name = "张三";
            o1.Age = 20;
            o1.ShowInfo();

            //保存信息
            c1.SetMemento(o1.CreateMemento());

            o1.Name = "李四";
            o1.Age = 25;
            o1.ShowInfo();

            //保存信息
            c1.SetMemento(o1.CreateMemento());

            o1.Name = "赵五";
            o1.Age = 25;
            o1.ShowInfo();

            //保存信息
            c1.SetMemento(o1.CreateMemento());

            o1.Name = "ZORO";
            o1.Age = 22;
            o1.ShowInfo();

            //保存信息
            c1.SetMemento(o1.CreateMemento());

            o1.Name = "KKCC";
            o1.Age = 28;
            o1.ShowInfo();

            //保存信息
            c1.SetMemento(o1.CreateMemento());

            o1.Name = "ZZZZ";
            o1.Age = 28;
            o1.ShowInfo();

            //保存信息
            c1.SetMemento(o1.CreateMemento());

            //恢复信息
            o1.SetMemento(c1.GetMemento());
            o1.ShowInfo();

            o1.SetMemento(c1.GetMemento());
            o1.ShowInfo();

            o1.SetMemento(c1.GetMemento());
            o1.ShowInfo();

            o1.SetMemento(c1.GetMemento());
            o1.ShowInfo();

            o1.SetMemento(c1.GetMemento());
            o1.ShowInfo();

            o1.SetMemento(c1.GetMemento());
            o1.ShowInfo();

            /*
            【信息如下】：姓名张三，年龄20。
            保存信息成功，当前已保存了1条信息。
            【信息如下】：姓名李四，年龄25。
            保存信息成功，当前已保存了2条信息。
            【信息如下】：姓名赵五，年龄25。
            保存信息成功，当前已保存了3条信息。
            【信息如下】：姓名ZORO，年龄22。
            保存信息成功，当前已保存了4条信息。
            【信息如下】：姓名KKCC，年龄28。
            保存信息成功，当前已保存了5条信息。
            【信息如下】：姓名ZZZZ，年龄28。
            保存失败，最多允许保存5个。
            【信息如下】：姓名KKCC，年龄28。
            【信息如下】：姓名ZORO，年龄22。
            【信息如下】：姓名赵五，年龄25。
            【信息如下】：姓名李四，年龄25。
            【信息如下】：姓名张三，年龄20。
            【信息如下】：姓名，年龄-1。
             */
        }

        protected override void TestDescription()
        {
            Console.WriteLine("【备忘录模式 - 01】");
        }
    }
}
