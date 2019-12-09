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

        //public DoubleLinked FindBy(int value)
        //{
            
        //}

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
            if (node.Previous == null)
            {
                node.Previous = this;
                this.Previous = null;
                this.Next = node;
            }
           
            else
            {
                this.Previous = node.Previous;
                this.Next = node;
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
                throw new ArgumentException("不能和自己进行交换");
            }
            if (store==b)
            {
                a.Next = temp;
                a.Previous = b;
                a.Previous.Next = b;
                a.Next.Previous = b;
                b.Next = a;
                b.Previous = link;
                b.Next.Previous = a;
                b.Previous.Next = a;
            }
            else if (link == b)
            {
                a.Next = b;
                a.Previous = Temp;
                a.Next.Previous = b;
                a.Previous.Next = b;
                b.Next = store;
                b.Previous = a;
                b.Previous.Next = a;
                b.Next.Previous = a;
            }
            else
            {
                a.Next = b.Next;
                a.Previous = b.Previous;
                a.Next.Previous = b;
                a.Previous.Next = b;
                b.Next = store;
                b.Previous = link;
                b.Next.Previous = a;
                b.Previous.Next = a;
            }
        }
    }
}
