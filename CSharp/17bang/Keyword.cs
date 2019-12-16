﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    class Keyword
    {
        public string Content { get; set; }//关键字内容
        public int Used { get; set; }//关键字使用次数
        public Keyword Upper { get; set; }//关键字的上一级
        internal List<Article> Articles { get; set; }//关键字对应多个文章
        
    }
}
