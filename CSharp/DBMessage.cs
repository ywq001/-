﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    class DBMessage : ISendMessage
    {
        public void Send()
        {
            Console.WriteLine("实现接口方法");
        }
    }
}
