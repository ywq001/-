using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Text;
using CSharp;
using System.Data;
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


        //将用户名和密码存入数据库：Register()
        internal void Register()
        {
            SqlParameter pUserName = new SqlParameter("@Name", Name);
            SqlParameter pPassword = new SqlParameter("@Password", Password);
            DbParameter[] parameters = new DbParameter[] { pUserName, pPassword };
            _dbHelper.ExecuteNonQuery(
                @"INSERT Register VALUES(@Name,@_password)",
                parameters);
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
            SqlParameter pUserName = new SqlParameter("@Name", Name);
            SqlParameter pPassword = new SqlParameter("@Password", Password);
            DbParameter[] parameters = new DbParameter[] { pUserName, pPassword };
            object reader = _dbHelper.ExecuteScalar(
                @"SELECT * FROM Register WHERE Username=@Name AND Password=@Password",
                parameters);
            if (reader==null)
            {
                Console.WriteLine("用户名或密码输入不正确");
                return false;
            }
            else
            {
                LatestLogonTime = DateTime.Now;
                Console.WriteLine("登录成功");
                return true;
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
