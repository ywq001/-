using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.OtherAssignments
{
    public class Person
    {
        public int age = 18;
    }

    //声明一个委托：打水（ProvideWater），可以接受一个Person类的参数，返回值为int类型
    public delegate int ProvideWater(Person person);


}
