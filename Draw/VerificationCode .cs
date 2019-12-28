﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;

namespace Draw
{
    class VerificationCode
    {
        ///参考一起帮的登录页面，绘制一个验证码图片，存放到当前项目中。验证码应包含：
        ///随机字符串
        ///混淆用的各色像素点
        ///混淆用的直线（或曲线）
        public static void GetVerificationCode()
        {
            
            string[] randomCharacter = { "1", "2", "3", "4", "a", "b", "e", "f", "g", "h", "l" };
            string getRandom = string.Empty;
            Random random = new Random();
            for (int i = 0; i < 4; i++)
            {
                int randomIndex = random.Next(11);
                getRandom += randomCharacter[randomIndex];
            }
            Bitmap image = new Bitmap(200, 200);
            Graphics g = Graphics.FromImage(image);
            g.Clear(Color.AliceBlue);
            PointF pointF = new PointF(50, 60);
            for (int i = 0; i < 10; i++)
            {
                int x = random.Next(0, 180);
                int y = random.Next(0, 180);
                int z = random.Next(0, 180);
                g.DrawLine(new Pen(Color.Blue), new Point(x, y), new Point(y, z));
                g.DrawLine(new Pen(Color.Yellow), new Point(x, z), new Point(z, y));
            }
            g.DrawString(
                getRandom,
                new Font("宋体", 30),
                new SolidBrush(Color.DarkRed),
                pointF);
            for (int i = 0; i < 100; i++)
            {
                int X = random.Next(0, 190);
                int Y = random.Next(0, 190);
                image.SetPixel(X, Y, Color.Red);
                image.SetPixel(Y, X, Color.Yellow);
            }
            
            image.Save(@"E:\新建文件夹\验证码.jpg", ImageFormat.Jpeg);
        }
    }
}
