using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    abstract class Entity
    {
        private int id;
        public int Id
        {
            get
            {
                return id;
            }
            private set
            {
                id = value;
            }
        }
    }
}
