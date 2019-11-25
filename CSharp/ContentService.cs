using System;
using System.Collections.Generic;
using System.Text;
using CSharp;

namespace CSharp
{
    class ContentService
    {
        

        public int amount { get; set; }

        public void Publish(Content content)
        {
            content.Issue();
        }   
    }
}
