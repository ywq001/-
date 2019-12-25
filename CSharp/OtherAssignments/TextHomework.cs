using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CSharp.OtherAssignments
{
    class TextHomework
    {
        public static void Do()
        {
            string path = "E:\\Temp\\新建文件夹\\email.txt";
            string email = File.ReadAllText(path);
            string[] Email = email.Split(';');
            StringBuilder joinEmail = new StringBuilder();
            for (int i = 0; i < Email.Length; i++)
            {
                if (Email.Count(c => c == Email[i]) == 1)
                {
                    joinEmail.Append(Email[i] + ";");
                    if (i % 30 == 0)
                    {
                        joinEmail.Append(Environment.NewLine);
                    }
                }
            }
            File.AppendAllText(path, joinEmail.ToString());
        }
    }
}
