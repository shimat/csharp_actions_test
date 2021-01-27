using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Class1 : IEquatable<Class1>
    {
        private readonly int x;

        public Class1(int x)
        {
            this.x = x;
        }

        public bool Equals(Class1 c)
        {
            return x == c.x;
        }
    }
}
