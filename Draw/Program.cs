using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw
{
    class Program
    {
        static void Main(string[] args)
        {
            ///参考一起帮的登录页面，绘制一个验证码图片，存放到当前项目中。验证码应包含：
            ///随机字符串
            ///混淆用的各色像素点
            ///混淆用的直线（或曲线）
            VerificationCode.GetVerificationCode();
        }
    }
}
