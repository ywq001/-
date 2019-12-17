using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    class StringMethod
    {
        public static int GetCount(string container, string target)
        {
            if (container.Contains(target))
            {
                string count = container.Replace(target, "");
                return (container.Length - count.Length) / target.Length;
            }
            else
            {
                return 0;
            }
        }
    }
}
