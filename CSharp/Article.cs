﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    class Article:Content
    {
        public override void Issue()
        {
            new HelpMoney().Usable -= 1;

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
