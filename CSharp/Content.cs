using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    abstract class Content
    {
        protected Content kind;
        private DateTime createTime=DateTime.Now;



        public DateTime PublishTime
        {
            get
            {
                return createTime;
            }
            private set
            {
                createTime = value;
            }
        }
        private string keyword;
        public string Keyword
        {
            get
            {
                return keyword;
            }
            set
            {
                keyword = value;
            }
        }

        private User author;
        public User Author
        {
            get
            {
                return author;
            }
            set
            {
                author = value;
            }
        }
        public abstract void moneyAmount(int reward);
        private int reward;
        public int Reward
        {
            get
            {
                return reward;
            }
            set
            {
                reward = value;
            }
        }
    }
}
