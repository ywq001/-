using System;
using System.Collections.Generic;
using System.Text;
using CSharp;
namespace CSharp
{
    //让User类无法被继承
    internal sealed class User:Entity<int>,ISendMessage,IChat
    {
        internal List<string> sensitive = new List<string> { "admin", "17bang", "管理员" };
        internal int HelpMoney { get; set; }
        internal TokenManager TokenManager { get; set; }

        internal Role role { get;private set; }
        private string _name;
        //设计一个适用的机制，能确保用户（User）的昵称（Name）不能含有admin、17bang、管理员等敏感词。
        public string Name 
        {
            get 
            {
                return _name;
            }
            set
            {
                if (value == "Admin")
                {
                    value = "系统管理员";
                    _name = value;

                }
                else if (ExamineName(value))
                {
                    Console.WriteLine("用户名不能含有敏感词");
                }
                else
                {
                    Name = value;

                }
            }
        }

        private string[] password = new string[7];
        
        private User invitedBy;
        public User InvitedBy
        {
            get { return invitedBy; }
            set { invitedBy = value; }
        }


        void changePasword(string[] code)
        {
            this.password = code;
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
            this.Name = _name;
        }

        void ISendMessage.Send()
        {
            Console.WriteLine("实现ISendMessage接口方法");
        }
        void IChat.Send()
        {
            Console.WriteLine("实现IChat接口方法");
        }
        private bool result;
        private bool ExamineName(string value)
        {
            for (int i = 0; i < sensitive.Count; i++)
            {
                if (value.Contains(sensitive[i]))
                {
                    result = true;
                    break;
                }
                else
                {
                    continue;
                }
            }
            return result;
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
