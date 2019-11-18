using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    class User
    {
        internal string Name;
        string Password;
        string InvitedBy;

        internal static void Register(string Name, string Password, string InvitedBy)
        {
            Console.WriteLine("用户名:"+Name);
            Console.WriteLine("密码："+Password);
            Console.WriteLine("邀请人："+InvitedBy);
        }

        internal static void Login(string Name, string Password)
        {
            Console.WriteLine("用户名："+Name);
            Console.WriteLine("密码："+Password);
        }

        internal User()
        {
            Console.WriteLine("无参构造函数被调用");

        }

        internal User(string Name)
        {
            this.Name = Name;
        }

    }
}
