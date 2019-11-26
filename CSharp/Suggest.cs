using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    class Suggest:Content
    {
        public override void Issue()//如果发布Suggest，不需要消耗帮帮币
        {
            //

        }
        public Suggest(string kind):base(kind)
        {
        }
        public void moneyAmount(int reward)
        {
            Console.WriteLine("获得棒棒币奖励" + reward + "枚");
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
        public override void Agree()
        {
            Author.HelpMoney += 1;
        }
        public override void Disagree()
        {
            Author.HelpMoney -= 1;
        }
    }
}
