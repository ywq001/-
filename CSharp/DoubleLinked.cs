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

        public DoubleLinked(int value)
        {
            Value = value;
        }
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
            DoubleLinked after = this.Next;
            DoubleLinked before = this.Previous;
            if (this.Value==value)
            {
                return this;
            }
            while (!(after==null))
            {
                if (after.Value==value)
                {
                    return after;
                }
                else
                {
                    after = after.Next;
                }
            }
            while (!(before==null))
            {
                if (before.Value==value)
                {
                    return before;

                }
                else
                {
                    before = before.Previous;
                }
            }
            return null;
        }

        public void InsertAfter(DoubleLinked node)
        {
            if (node.Next == null)
            {
                node.Next = this;
                this.Previous = node;
            }
            else
            {
                this.Next = node.Next;
                this.Previous = node;
                node.Next = this;
                this.Next.Previous = this;
            }

        }

        public void IsertBefore(DoubleLinked node)
        {
            this.Next = node;
            if (node.Previous == null)
            {
                node.Previous = this;
                
            }
            else
            {
                this.Previous = node.Previous;
                node.Previous = this;
                this.Previous.Next = this;
            }
        }

        public static void Delete(DoubleLinked node)
        {
            if (node.IsHead && node.IsTail)
            {
                throw new Exception("最后一个无法删除");
            }
            if (node.Previous != null)
            {
                node.Previous.Next = node.Next;
            }
            if (node.Next != null)
            {
                node.Next.Previous = node.Previous;
            }
            node.Previous = null;
            node.Next = null;
        }

        public static void Swap(DoubleLinked a,DoubleLinked b)
        {
            DoubleLinked temp=b.Next;
            DoubleLinked Temp=b.Previous;
            DoubleLinked store = a.Next;
            DoubleLinked link = a.Previous;
            if (a==b)
            {
                throw new Exception("");
            }
            Delete(b);
            b.InsertAfter(a);
            Delete(a);
            if (link == null)
            {
                a.IsertBefore(temp);
            }
            else
            {
                if (store==b)
                {
                    a.InsertAfter(b);
                }
                else
                {
                    a.InsertAfter(Temp);
                }
            }
        }
    }
}
