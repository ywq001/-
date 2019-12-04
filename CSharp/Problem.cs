using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    internal class Problem:Content
    {
        //考虑求助的以下方法/属性，哪些适合实例，哪些适合静态，然后添加到类中：
        //    Publish()：发布一篇求助，并将其保存到数据库
        //    Load(int Id)：根据Id从数据库
        //    获取一条求助Delete()：删除某个求助
        //repoistory：可用于在底层实现上述方法和数据库的连接操作等


        // 将之前User/Problem/HelpMoney类的字段封装成属性，其中：
        //user.Password在类的外部只能改不能读
        //如果user.Name为“admin”，输入时修改为“系统管理员”
        //problem.Reward不能为负数
        

        private string title;
        public string Title
        {
            get { return title; }
            set { title = value; }
        }


        private string body;
        public string Body
        {
            get { return body; }
            set { body = value; }
        }
        private int reward;
        public int Reward
        {
            get { return reward; }
            set 
            {
                if (value<0)
                {
                    Console.WriteLine("reward不能为负数");
                }
                reward = value; 
            }
        }
        //private DateTime pulishDetatime;
        //public DateTime PulishDetatime
        //{
        //    get { return pulishDetatime; }
        //    set { pulishDetatime = value; }
        //}
        //private User author;
        //public User Author
        //{
        //    get { return author; }
        //    set { Author = value; }
        //}
        internal  void Publish()
        {
            Console.WriteLine("实例方法");
        }

       internal static void Load(int Id)
        {
            Console.WriteLine("静态的");
        }

        internal void Delete()
        {
            
        }

        public Problem(string kind) : base(kind)
        {

        }
        public override void Issue()
        {
            this.PublishTime = DateTime.Now;//在发布时调用此方法为PublishTime赋值
            Author.HelpMoney -= reward;
            Console.WriteLine("棒棒币减少"+reward);
        }
        
    }
}
