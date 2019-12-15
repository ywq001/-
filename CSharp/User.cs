using System;
using System.Collections.Generic;
using System.Text;
using CSharp;
namespace CSharp
{
    //让User类无法被继承
    internal sealed class User:Entity<int>,ISendMessage,IChat
    {
        internal int HelpMoney { get; set; }
        internal TokenManager TokenManager { get; set; }

        internal Role role { get;private set; }
        private string name;
        public string Name //设计一个适用的机制，能确保用户（User）的昵称（Name）不能含有admin、17bang、管理员等敏感词。
        {
            get 
            {
                return Name;
            }
            set
            {
                if (value.Contains("17bang")&&value.Contains("admin")&&value.Contains("管理员"))
                {
                    throw new ArgumentException("用户名中不能包含敏感词");
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

        internal static void Register()
        {
            
        }

        internal static void Login()
        {
            
        }

        internal User()
        {
           

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
    enum Role
    {
        Visited,
        Registered,
        Published,
        Admin
    }
}
