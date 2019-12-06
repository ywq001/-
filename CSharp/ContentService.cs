using System;
using System.Collections.Generic;
using System.Text;
using CSharp;

namespace CSharp
{
    class ContentService
    {



        //如果发布Article，需要消耗一个帮帮币
        //如果发布Problem，需要消耗其设置悬赏数量的帮帮币
        //如果发布Suggest，不需要消耗帮帮币
        //根据传入的对象进行调用
        [HelpMoneyChanged(1)]
        public static void Publish(Content content)
        {
            content.Issue();
        }   
    }
}
