using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    class Problem
    {
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
        private DateTime pulishDetatime;
        public DateTime PulishDetatime
        {
            get { return pulishDetatime; }
            set { pulishDetatime = value; }
        }
        private Problem author;
        public Problem Author
        {
            get { return author; }
            set { Author = value; }
        }
        internal static void Publish()
        {

        }

    }
}
