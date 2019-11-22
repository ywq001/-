using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    class Article:Content
    {
         
        public override void moneyAmount(int reward)
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
                value = title;
            }
        }
    }
}
