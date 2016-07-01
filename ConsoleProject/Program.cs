using ConsoleProject.Test;
using ConsoleProject.VerifyProxy;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic helloWorld = new ConsoleProject.KingAOP.HelloWorld();
            helloWorld.HelloWorldCall();
            //ModifierTest modifier = new ModifierTest();
            //modifier.Invoke();
            //DecoratorTest decorator = new DecoratorTest();
            //decorator.Invoke();
            //OrderAOPTest orderaop = new OrderAOPTest();
            //orderaop.Invoke();
            Console.Read();
        }
    }
}
