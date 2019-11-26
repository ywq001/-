using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    class Article:Content
    {
        //发布时棒棒币减少
        public override void Issue()
        {
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
    }
}
