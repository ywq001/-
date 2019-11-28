using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    class Comment:ApprovalOppose
    {
        public User Author { get; set; }
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
