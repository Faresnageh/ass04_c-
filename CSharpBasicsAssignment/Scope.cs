using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace CSharpBasicsAssignment
{
    internal class Scope
    {
        private int _number = 100;
        public void Meth1()
        {
            Console.WriteLine(_number);
        }
        public void Meth2()
        {
            Console.WriteLine(_number);
        }
        public void MethLoc()
        {
            int localNumber = 20;
            Console.WriteLine(localNumber);
        }
    }
}
