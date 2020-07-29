using System;
using System.Collections.Generic;
using System.Text;

namespace ZqCSharpDesignPattern.CreationalPattern.A0501_PrototypePattern
{
    class A0501PrototypePattern : CodeFramework
    {
        protected override void RunCode()
        {
            Test01();
            Test02();
        }

        /*
         * 【01】浅拷贝
         * 类Worker中的Colleague类型字段是类类型，即引用类型
         * 对worker进行浅拷贝时，拷贝的Colleague字段是引用，即对引用拷贝了副本（从HashCode可看出，两个相同）
         * 所以，对其中一个进行修改，会影响另一个。
         * 
         * 【02】string类型
         * string是特殊的引用类型
         * string是具有值类型特点的引用类型
         * string具有字符串的不可变性特点
         * 
         * 【03】对于值类型，HashCode显示的是值类型的值
         */
        private void Test02()
        {
            Worker w1 = new Worker() { Name = "zoro", Age = 20, Score = 100 };
            w1.SetColleague("AAAA", "HeBei", 4);
            Console.WriteLine("修改前的w1的信息");
            w1.ShowInfo();

            Worker w2 = (Worker)w1.Clone();
            Console.WriteLine("修改前的w2的信息");
            w2.ShowInfo();

            Console.WriteLine($"w1.Hash={w1.GetHashCode()}，w2.Hash={w2.GetHashCode()}");
            Console.WriteLine($"w1.Colleague.Hash={w1.Colleague.GetHashCode()}，w2.Colleague.Hash={w2.Colleague.GetHashCode()}");
            Console.WriteLine($"w1.Name.Hash={w1.Name.GetHashCode()}，w2.Name.Hash={w2.Name.GetHashCode()}");
            Console.WriteLine($"w1.Age.Hash={w1.Age.GetHashCode()}，w2.Age.Hash={w2.Age.GetHashCode()}");

            Console.WriteLine();

            Console.WriteLine("修改后----------------------");
            Console.WriteLine();

            w2.Name = "wwww";
            w2.Age = 80;
            w2.SetColleague("XXXX", "BeiJing", 5);
            Console.WriteLine("修改后的w1的信息");
            w1.ShowInfo();
            Console.WriteLine("修改后的w2的信息");
            w2.ShowInfo();

            Console.WriteLine($"w1.Hash={w1.GetHashCode()}，w2.Hash={w2.GetHashCode()}");
            Console.WriteLine($"w1.Colleague.Hash={w1.Colleague.GetHashCode()}，w2.Colleague.Hash={w2.Colleague.GetHashCode()}");
            Console.WriteLine($"w1.Name.Hash={w1.Name.GetHashCode()}，w2.Name.Hash={w2.Name.GetHashCode()}");
            Console.WriteLine($"w1.Age.Hash={w1.Age.GetHashCode()}，w2.Age.Hash={w2.Age.GetHashCode()}");

            /*
            输出结果：
            修改前的w1的信息
            姓名：zoro，年龄：20，分数：100
            学习经历：在位于HeBei的AAAA学校，学习4年。

            修改前的w2的信息
            姓名：zoro，年龄：20，分数：100
            学习经历：在位于HeBei的AAAA学校，学习4年。

            w1.Hash=58225482，w2.Hash=54267293
            w1.Colleague.Hash=18643596，w2.Colleague.Hash=18643596
            w1.Name.Hash=-725858786，w2.Name.Hash=-725858786
            w1.Age.Hash=20，w2.Age.Hash=20

            修改后----------------------

            修改后的w1的信息
            姓名：zoro，年龄：20，分数：100
            学习经历：在位于BeiJing的XXXX学校，学习5年。

            修改后的w2的信息
            姓名：wwww，年龄：80，分数：100
            学习经历：在位于BeiJing的XXXX学校，学习5年。

            w1.Hash=58225482，w2.Hash=54267293
            w1.Colleague.Hash=18643596，w2.Colleague.Hash=18643596
            w1.Name.Hash=-725858786，w2.Name.Hash=-1204033931
            w1.Age.Hash=20，w2.Age.Hash=80             
             */
        }

        /*
         * 浅拷贝
         * 针对类类型中的字段，仅包含值类型和string引用类型
         * 
         */
        private void Test01()
        {
            Student s1 = new Student() { Name="zoro", Age =20, Score=100};
            s1.ShowInfo();

            Student s2 = (Student)s1.Clone();
            s2.ShowInfo();

            s2.Name = "aaa";
            s2.Age = 50;
            s1.ShowInfo();
            s2.ShowInfo();

            /*
            输出结果：
            姓名：zoro，年龄：20，分数：100
            姓名：zoro，年龄：20，分数：100
            姓名：zoro，年龄：20，分数：100
            姓名：aaa，年龄：50，分数：100             
             */
        }

        protected override void TestDescription()
        {
            Console.WriteLine("【原型模式 - 01：浅拷贝】");
        }
    }
}
