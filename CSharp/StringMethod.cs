using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    class StringMethod
    {
        //实现GetCount(string container, string target)方法，可以统计出container中有多少个target
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


        ///不使用string自带的Join()方法，定义一个mimicJoin()方法，
        ///能将若干字符串用指定的分隔符连接起来，
        ///比如：mimicJoin("-","a","b","c","d")，其运行结果为：a-b-c-d
        public static string mimicJoin(string symbol , string[] joint)
        {
            StringBuilder splice = new StringBuilder();
            for (int i = 0; i < joint.Length; i++)
            {
                splice.Append(joint[i]);
                if (i == joint.Length-1)
                {
                    break;
                }
                splice.Append(symbol);
            }
            string Splice = splice.ToString();
            return Splice;
        }

    }
}
