using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    //让User类无法被继承
    sealed class User:Entity,ISendMessage,IChat
    {
        internal int HelpMoney { get; set; }

        private string Name;
        public string name 
        {
            get 
            {
                return Name;
            }
            set
            {
                if (value == "admin")
                {
                    Name = "系统管理员";
                }
                Name = value;
            }
        }
        
        private string Password;
        public string passwoed 
        {
            get
            {
                return Password;
            }
            private set
            {
                Password = value;
            }
        }
        private User invitedBy;
        public User InvitedBy
        {
            get { return invitedBy; }
            set { invitedBy = value; }
        }


        void changePasword(string Password)
        {
            this.Password = Password;
        }

        internal static void Register(string Name, User Password, string InvitedBy)
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
            this.Name = name;
        }

        void ISendMessage.Send()
        {
            Console.WriteLine("实现ISendMessage接口方法");
        }
        void IChat.Send()
        {
            Console.WriteLine("实现IChat接口方法");
        }

    }
}
