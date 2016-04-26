using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject.Modifier
{
    public class InternalClass
    {
        internal static int x = 1;
        public static int y = 2;
        public int z = 3;
        internal int h =4;

        public void Invoke()
        {

        }
    }
    class A
    {
        protected int x = 123;
    }
    class B : A
    {
        public void Invoke()
        {
            A a = new A();
            B b = new B();

            // Error CS1540, because x can only be accessed by
            // classes derived from A.
            // a.x = 10; 

            // OK, because this class derives from A.
            b.x = 10;
        }
        private void Test()
        {

        }
    }
}
