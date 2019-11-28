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
        private object[] stack;
        private int top;
        
        public Stack(int lenght)
        {
            stack = new object[lenght];
        }
        
        public void Push(params object[] element)
        {
            for (int i = 0; i < element.Length; i++)
            {
                if (top> stack.Length)
                {
                    Console.WriteLine("栈满了");
                }
                stack[top] = element[i];
                top++;
            }
        }

        public object Pop()
        {
            if (stack[0] == null)
            {
                Console.WriteLine("栈以空");
            }
            object temp = stack[top];
            stack[top] = null;
            return temp;
        }
    }
}
