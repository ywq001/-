using System;
using System.Collections.Generic;
using System.Text;
using CSharp;


namespace CSharp
{
    //让User类无法被继承
    internal sealed class User:Entity<int>,ISendMessage,IChat
    {
        internal IList<string> sensitive = new List<string> { "admin", "17bang", "管理员" };
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
                    _name = value;

                }
            }
        }

        private string password;
        
        private User invitedBy;
        public User InvitedBy
        {
            get { return invitedBy; }
            set { invitedBy = value; }
        }

        ///确保用户（User）的密码（Password）：
        ///长度不低于6
        ///必须由大小写英语单词、数字和特殊符号（~!@#$%^&*()_+）组成
        void changePasword(string code)
        {
          
            if (code.Length<6)
            {
                Console.WriteLine("密码长度太低");
            }
            else
            {
                if (CheckPassword.AllJudgment(code))
                {
                    this.password = code;
                }
                else
                {
                    Console.WriteLine("密码不符合规范");
                }
            }
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
