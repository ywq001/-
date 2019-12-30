using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;
using CSharp;
using CSharp._17bang;


namespace CSharp
{
    //让User类无法被继承
    internal sealed class User : Entity<int>, ISendMessage, IChat
    {
        private DBHelper _dbHelper;

        public User()
        {
            if (_dbHelper == null)
            {
                _dbHelper = new DBHelper();
            }
        }

        internal IList<string> sensitive = new List<string> { "admin", "17bang", "管理员" };
        internal int HelpMoney { get; set; }
        internal TokenManager TokenManager { get; set; }

        private DateTime LatestLogonTime { get; set; }

        internal Role role { get; private set; }
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

        private string _password;
        ///确保用户（User）的密码（Password）：
        ///长度不低于6
        ///必须由大小写英语单词、数字和特殊符号（~!@#$%^&*()_+）组成
        public string Password
        {
            get { return _password; }
            set
            {
                if (value.Length < 6)
                {
                    Console.WriteLine("密码长度太低");
                }
                else
                {
                    if (CheckPassword.AllJudgment(value))
                    {
                        _password = value;
                    }
                    else
                    {
                        Console.WriteLine("密码不符合规范");
                    }
                }
            }
        }
        private User invitedBy;
        public User InvitedBy
        {
            get { return invitedBy; }
            set { invitedBy = value; }
        }

        
       
        internal static void Register()
        {
            
        }

        internal static void Login()
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

        //将用户名和密码存入数据库：Register()
        public void Save()
        {
            _dbHelper.ExecuteNonQuery(
                $"INSERT Register VALUES(N'{Name}',N'{_password}')");
        }

        public static void SaveSome(params User[] students)
        {
            using (DbConnection connection = new DBHelper().LongConnection)
            {
                for (int i = 0; i < students.Length; i++)
                {
                    students[i].Save();
                }
            }
        }

        //根据用户名和密码检查某用户能够成功登陆：Logon()
        public bool Logon()
        {
            DbDataReader reader = _dbHelper.ExecuteReader(
                $"SELECT * FROM Register WHERE Username=N'{Name}' AND Password=N'{Password}'");
            if (reader.HasRows == true)
            {
                LatestLogonTime = DateTime.Now;
                Console.WriteLine("登录成功");
                return true;
            }
            else
            {
                Console.WriteLine("用户名或密码输入不正确");
                return false;
            }
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
