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
            DoubleLinked old = new DoubleLinked();
            DoubleLinked current = new DoubleLinked();
            current.InsertAfter(old);
            Assert.AreEqual(current.Previous,old);
        }
    }
}