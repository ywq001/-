using NUnit.Framework;
using CSharp;

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
            DoubleLinked old = new DoubleLinked(1);
            DoubleLinked current = new DoubleLinked(2);
            current.InsertAfter(old);
            Assert.AreEqual(current.Previous,old);
            Assert.AreEqual(old.Next, current);
            DoubleLinked current2 = new DoubleLinked(3);
            current2.InsertAfter(old);
            Assert.AreEqual(old.Next, current2);
            Assert.AreEqual(current2.Next, current);
        }
        [Test]
        public void IsertBefore()
        {
            DoubleLinked old = new DoubleLinked(1);
            DoubleLinked current = new DoubleLinked(2);
            current.IsertBefore(old);
            Assert.AreEqual(old.Previous, current);
            Assert.AreEqual(current.Next, old);
            DoubleLinked current1 = new DoubleLinked(3);
            current1.IsertBefore(old);
            Assert.AreEqual(old.Previous, current1);
            Assert.AreEqual(current1.Previous, current);
            Assert.AreEqual(current1.Next, old);
            Assert.AreEqual(current.Next, current1);
            
        }

        [Test]
        public static void Delete()
        {
            DoubleLinked old = new DoubleLinked(1);
            DoubleLinked current = new DoubleLinked(2);
            DoubleLinked current2 = new DoubleLinked(3);
            DoubleLinked current3 = new DoubleLinked(4);
            DoubleLinked current4 = new DoubleLinked(5);
            old.IsertBefore(current);
            current2.IsertBefore(old);
            current3.IsertBefore(current2);
            current4.IsertBefore(current3);
            DoubleLinked.Delete(old);
            Assert.AreEqual(current2.Next, current);
            Assert.AreEqual(current.Previous, current2);
            DoubleLinked.Delete(current);
            Assert.AreEqual(current2.Next, null);
            DoubleLinked.Delete(current4);
            Assert.AreEqual(current3.Previous, null);

        }
        [Test]
        public static void Swap()
        {
            DoubleLinked old = new DoubleLinked(1);
            DoubleLinked current = new DoubleLinked(2);
            DoubleLinked current1 = new DoubleLinked(3);
            DoubleLinked current2 = new DoubleLinked(4);
            DoubleLinked current3 = new DoubleLinked(5);
            DoubleLinked current4 = new DoubleLinked(6);
            old.IsertBefore(current);
            current1.IsertBefore(old);
            current2.IsertBefore(current1);
            current3.IsertBefore(current2);
            current4.IsertBefore(current3);
            DoubleLinked.Swap(old, current1);
            Assert.AreEqual(old.Next, current1);
            Assert.AreEqual(current1.Previous, old);
            //Assert.AreEqual(current.Previous, current1);
            Assert.AreEqual(current2.Next, old);
        }
    }
}