using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    interface ApprovalOppose
    {
        void Agree(User voter);

        void Disagree(User voter);
    }
}
