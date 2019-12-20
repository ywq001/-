using NUnit.Framework;
using CSharp;
using ConsoleApp1;
using System.Collections.Generic;

namespace CsharpTest
{
    public class DoubleLinkedTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void InsertAfter()
        {
            DoubleLinked<int> old = new DoubleLinked<int>(1);
            DoubleLinked<int> current = new DoubleLinked<int>(2);
            current.InsertAfter(old);
            Assert.AreEqual(current.Previous,old);
            Assert.AreEqual(old.Next, current);
            DoubleLinked<int> current2 = new DoubleLinked<int>(3);
            current2.InsertAfter(old);
            Assert.AreEqual(old.Next, current2);
            Assert.AreEqual(current2.Next, current);
        }
        [Test]
        public void IsertBefore()
        {
            DoubleLinked<int> old = new DoubleLinked<int>(1);
            DoubleLinked<int> current = new DoubleLinked<int>(2);
            current.IsertBefore(old);
            Assert.AreEqual(old.Previous, current);
            Assert.AreEqual(current.Next, old);
            DoubleLinked<int> current1 = new DoubleLinked<int>(3);
            current1.IsertBefore(old);
            Assert.AreEqual(old.Previous, current1);
            Assert.AreEqual(current1.Previous, current);
            Assert.AreEqual(current1.Next, old);
            Assert.AreEqual(current.Next, current1);
            
        }

        [Test]
        public static void Delete()
        {
            DoubleLinked<int> old = new DoubleLinked<int>(1);
            DoubleLinked<int> current = new DoubleLinked<int>(2);
            DoubleLinked<int> current2 = new DoubleLinked<int>(3);
            DoubleLinked<int> current3 = new DoubleLinked<int>(4);
            DoubleLinked<int> current4 = new DoubleLinked<int>(5);
            old.IsertBefore(current);
            current2.IsertBefore(old);
            current3.IsertBefore(current2);
            current4.IsertBefore(current3);
            DoubleLinked<int>.Delete(old);
            Assert.AreEqual(current2.Next, current);
            Assert.AreEqual(current.Previous, current2);
            DoubleLinked<int>.Delete(current);
            Assert.AreEqual(current2.Next, null);
            DoubleLinked<int>.Delete(current4);
            Assert.AreEqual(current3.Previous, null);

        }
        [Test]
        public static void Swap()
        {
            DoubleLinked<int> old = new DoubleLinked<int>(1);
            DoubleLinked<int> current = new DoubleLinked<int>(2);
            DoubleLinked<int> current1 = new DoubleLinked<int>(3);
            DoubleLinked<int> current2 = new DoubleLinked<int>(4);
            DoubleLinked<int> current3 = new DoubleLinked<int>(5);
            DoubleLinked<int> current4 = new DoubleLinked<int>(6);
            old.IsertBefore(current);
            current1.IsertBefore(old);
            current2.IsertBefore(current1);
            current3.IsertBefore(current2);
            current4.IsertBefore(current3);
            DoubleLinked<int>.Swap(old, current1);
            Assert.AreEqual(old.Next, current1);
            Assert.AreEqual(current1.Previous, old);
            Assert.AreEqual(current.Previous, current1);
            Assert.AreEqual(current2.Next, old);
            DoubleLinked<int>.Swap(current4, current3);
            Assert.AreEqual(current3.Previous, null);
            Assert.AreEqual(current3.Next, current4);
            Assert.AreEqual(current4.Previous, current3);
            Assert.AreEqual(current4.Next, current2);
        }
        [Test]
        public void FindBy()
        {
            DoubleLinked<int> d1 = new DoubleLinked<int>(1);
            DoubleLinked<int> d2 = new DoubleLinked<int>(2);
            DoubleLinked<int> d3 = new DoubleLinked<int>(3);
            DoubleLinked<int> d4 = new DoubleLinked<int>(4);
            DoubleLinked<int> d5 = new DoubleLinked<int>(5);
            d1.InsertAfter(d2);
            d2.InsertAfter(d3);
            d3.InsertAfter(d4);
            d4.InsertAfter(d3);
            d5.InsertAfter(d4);

            Assert.AreEqual(d1.FindBy(2), d2);
            Assert.AreEqual(d2.FindBy(3), d3);
            
        }
    }

    public class homeworktest
    {

        [Test]
        public void GetMax()
        {
            double[] scoers = new double[] { 68.5, 67.5, 96.5, 87.5, 56.5, 80 };

            Assert.AreEqual(homework.GetMax(scoers), 96.5);
        }

        [Test]
        public void PrimeNumber()
        {

            Assert.AreEqual(homework.PrimeNumber(10), new List<int> { 3, 5, 7 });
        }
        [Test]
        public void BinarySeek()
        {
            int[] scoers = new int[] { 65, 67, 78, 79, 87, 89, 91, 93, 95 };
            Assert.AreEqual(homework.BinarySeek(scoers, 87), 4);
        }
        [Test]
        public void Push()
        {
            homework wx = new homework();
            wx.Push(1);
            Assert.AreEqual(wx.Pop(), 1);
            Assert.AreEqual(wx.Pop(), null);
        }
    }

    public class GuessMe
    {
        [Test]
        public void guess()
        {
            Assert.AreEqual(OtherAssignment.guess(10, 10, 2, out bool needBreak), "你真牛逼");
            Assert.AreEqual(OtherAssignment.guess(10, 10, 6, out bool need), "不错嘛");
            Assert.AreEqual(OtherAssignment.guess(10, 10, 9, out bool a), "还可以");
            Assert.AreEqual(OtherAssignment.guess(10, 8, 5, out bool b), "小了");
            Assert.AreEqual(OtherAssignment.guess(10, 15, 5, out bool c), "大了");
            Assert.AreEqual(OtherAssignment.guess(10, 15, 10, out bool d), "(～￣(OO)￣)ブ");

        }
    }
}