using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    class Article:Content,IApprovalOppose
    {
        //发布时棒棒币减少
        public List<Keyword> Keywords { get; set; }//文章有多个关键字
        public List<Comment> Comments { get; set; }//文章有多个评论

        public override void Publish()
        {
            if (Author == null)
            {
                throw new ArgumentException("不能没有作者");
            }
            _publishTime = DateTime.Now;//在发布时调用此方法为PublishTime赋值
            Author.HelpMoney += 1;
            
        }
        public Article(string kind):base(kind)
        {
           
        }
        public void moneyAmount(int reward)
        {
            Console.WriteLine("获得打赏" + reward + "枚");
        }

        private string title;
        ///确保文章（Content）的标题不能为null值，
        ///也不能为一个或多个空字符组成的字符串，
        ///而且如果标题前后有空格，也予以删除
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("标题不能为null或空值");
                }
                
                title = value.Trim();
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
