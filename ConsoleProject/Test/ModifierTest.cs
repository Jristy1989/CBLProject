using ConsoleProject.Modifier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleProject.Test
{
    public class ModifierTest
    {
        public void Invoke()
        {
            /*访问*/
            InternalClass internalTest = new InternalClass();
            int y = InternalClass.y;
            int x = InternalClass.x;
            internalTest.Invoke();
            int z=internalTest.z;
            int h = internalTest.h;

            /*赋值引用*/
            InternalClass.y = 20;
            InternalClass.x = 10;
            internalTest.z = 30;
            internalTest.h = 40;


            B b = new B();
            b.Invoke();
        }
    }
}
