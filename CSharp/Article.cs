using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    class Article:Content,ApprovalOppose
    {
        //发布时棒棒币减少
        public override void Issue()
        {
            if (Author == null)
            {
                throw new ArgumentException("不能没有作者");
            }
            _publishTime = DateTime.Now;//在发布时调用此方法为PublishTime赋值
            Author.HelpMoney -= 1;
            Console.WriteLine("棒棒币减少1");
        }
        public Article(string kind):base(kind)
        {
           
        }
        public void moneyAmount(int reward)
        {
            Console.WriteLine("获得打赏" + reward + "枚");
        }

        private string title;
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
        
        public void Agree(User voter)
        {
            Author.HelpMoney += 1;
        }
        public void Disagree(User voter)
        {
            Author.HelpMoney -= 1;
        }

    }
}
