using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    public class CheckPassword
    {
        private static bool _testPassword;

        //判读是否符合数字要求
        public static bool TestNumber(string password)
        {
            int number;
            byte[] intAsciiCode = Encoding.Default.GetBytes(password);
            for (int i = 0; i < intAsciiCode.Length; i++)
            {
                number = intAsciiCode[i];
                if (number >= 48 && number <= 57)
                {
                    _testPassword = true;
                    break;
                }
                else
                {
                    _testPassword = false;
                }
            }
            return _testPassword;
        }

        //判读是否符合大写字母要求
        public static bool TestUpper(string password)
        {
            int number;
            byte[] intAsciiCode = Encoding.Default.GetBytes(password);
            for (int i = 0; i < intAsciiCode.Length; i++)
            {
                number = intAsciiCode[i];
                if (number >= 65 && number <= 90)
                {
                    _testPassword = true;
                    break;
                }
                else
                {
                    _testPassword = false;
                }
            }
            return _testPassword;
        }

        //判读是否符合小写字母要求
        public static bool TestLower(string password)
        {
            int number;
            byte[] intAsciiCode = Encoding.Default.GetBytes(password);
            for (int i = 0; i < intAsciiCode.Length; i++)
            {
                number = intAsciiCode[i];
                if (number >= 97 && number <= 122)
                {
                    _testPassword = true;
                    break;
                }
                else
                {
                    _testPassword = false;
                }
            }
            return _testPassword;
        }

        //判读是否符合符合要求
        public static bool TestSymbol(string password)
        {
            int number;
            byte[] intAsciiCode = Encoding.Default.GetBytes(password);
            for (int i = 0; i < intAsciiCode.Length; i++)
            {
                number = intAsciiCode[i];
                if (number == 126 || number == 33 || number == 64 || number == 40 || number == 41 || number == 43 || number == 45)
                {
                    _testPassword = true;
                    break;
                }
                if (number == 63 || number == 64 || number == 94 || number == 95 || (number >= 35 && number <= 38))
                {
                    _testPassword = true;
                }
                else
                {
                    _testPassword = false;
                }
            }
            return _testPassword;
        }

        //最后将前面4个方法放在最终方法中做集中判断
        public static bool AllJudgment(string code)
        {
            if (TestNumber(code)&&TestUpper(code)&&TestLower(code)&&TestSymbol(code))
            {
                _testPassword = true;
            }
            else
            {
                _testPassword = false;
            }
            return _testPassword;
        }
    }
}
