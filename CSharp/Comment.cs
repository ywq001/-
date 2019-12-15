using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    class Comment : IApprovalOppose
    {
        public string Body { get; set; }

        //public Appraise appraise { get; set; }
        public Article Article { get; set; }//每个评论都有对应的文章
        public User Author { get; set; }
        public void Agree(User voter)
        {
            Author.HelpMoney += 1;
        }
        public void Disagree(User voter)
        {
            Author.HelpMoney -= 1;
        }
        public Comment(Article article)//记录文章
        {
            this.Article = article;
        }
    }
}
