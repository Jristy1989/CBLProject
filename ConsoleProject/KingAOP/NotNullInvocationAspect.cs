using KingAOP.Aspects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleProject.KingAOP
{
    class NotNullInvocationAspect : MethodInterceptionAspect
    {
        public override void OnInvoke(MethodInterceptionArgs args)
        {
            if (args.Arguments.Any(arg => arg == null)) Console.WriteLine("\n" + args.Method + " can't be called because some of args is null");

            else args.Proceed();
        }
    }
}
