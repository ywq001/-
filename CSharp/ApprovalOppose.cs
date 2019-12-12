using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    interface ApprovalOppose
    {
        Content target { get; set; }
        User Voter { get; set; }

        bool AgreeOrNot { get; set; }

        void Agree(User voter);

        void Disagree(User voter);
    }
}
