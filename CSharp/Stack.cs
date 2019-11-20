using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    class Stack
    {
        //作业: 自己实现 - 个模拟栈，增加如下功能:
        //●出栈Pop(),弹出栈顶数据
        //●入栈Push()， Push可以 - -次性压入多个数据;
        //●出入栈检查,
        //。如果压入的数据已超过栈的深度(最大容量)，提示“栈溢出”
        //。如果已弹出所有数据，提示“栈已空”

        //internal int top;
        internal int[] data = new int[5];
        //internal int size;

        

        public void Pop(int[] data)
        {
            int top = data.Length;
            if (!(data is null))
            {
                Console.WriteLine(data[top]);
            }

        }

        public void Push()
        {


        }

    }
}
