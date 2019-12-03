using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    public class DoubleLinked
    {
        public DoubleLinked Previous { get;private set; }
        public DoubleLinked Next { get; private set; }

        public int Value { get; set; }
        public bool IsHead
        {
            get { return Previous == null; }
        }

        public bool IsTail
        {
            get { return Next == null; }
        }

        public DoubleLinked FindBy(int value)
        {
            return null;
        }

        public void InsertAfter(DoubleLinked node)
        {

        }

        public void IsertBefore()
        {

        }

        public void Delete()
        {

        }

        public void Swap(DoubleLinked a,DoubleLinked b)
        {

        }
    }
}
