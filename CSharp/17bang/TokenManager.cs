using System;
using System.Collections.Generic;
using System.Text;
using CSharp;
namespace CSharp
{

//声明一个令牌（Token）枚举，包含值：SuperAdmin、Admin、Blogger、Newbie、Registered。
//声明一个令牌管理（TokenManager）类：
//使用私有的Token枚举_tokens存储所具有的权限
//暴露Add(Token)、Remove(Token)和Has(Token)方法，可以添加、删除和查看其权限
//将TokenManager作为User类的属性


    class TokenManager
    {
        private Token _tokens;


        public void Add(Token tokens)
        {
            _tokens = _tokens | tokens;
            
        }

        public void Remove(Token tokens)
        {
            if ((_tokens&tokens)==tokens)
            {
                _tokens = _tokens ^ tokens;
            }
            else
            {
                throw new Exception("");
            }
        }
        public Token Has()
        {
            return _tokens;
        }
    }
    [Flags]
    enum Token
    {
        SuperAdmin = 1,
        Admin = 2,
        Blogger = 4,
        Newbie = 8,
        Registered = 16
    }
}
