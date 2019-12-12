using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    interface IApprovalOppose
    {

        void Agree(User voter);

        void Disagree(User voter);
    }
}
