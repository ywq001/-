﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    //观察一起帮的求助（Problem）、文章（Article）和意见建议（Suggest），根据他们的特点，抽象出一个父类：
    //内容（Content）Content中有一个字段：kind，记录内容的种类（problem/article/suggest等），
    //只能被子类使用确保每个Content对象都有kind的非空值
    //Content中的createTime，不能被子类使用，
    //但只读属性PublishTime使用它为外部提供内容的发布时间其他方法和属性请自行考虑，尽量贴近一起帮的功能实现。
//    实例化文章和意见建议，调用他们：
//继承自父类的属性和方法
//自己的属性和方法

    abstract class Content
    {
        internal protected string kind;



        private DateTime createTime=DateTime.Now;



        public DateTime PublishTime
        {
            get
            {
                return createTime;
            }
            private set
            {
                createTime = value;
            }
        }
        private string keyword;
        public string Keyword
        {
            get
            {
                return keyword;
            }
            set
            {
                keyword = value;
            }
        }

        private User author;
        public User Author
        {
            get
            {
                return author;
            }
            set
            {
                author = value;
            }
        }
        
       
        
    }
}
