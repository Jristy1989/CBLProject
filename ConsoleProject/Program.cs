using ConsoleProject.Interator;
using ConsoleProject.MyTest;
using ConsoleProject.Test;
using ConsoleProject.VerifyProxy;
using System;
using System.Collections;
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
            Stack mystack = new Stack();
            MyNode mystack1 = new MyNode()
            {
                ID = 1,
                StackName = "CBL"
            };
            mystack.Push(mystack1);

            MyNode mystack2 = new MyNode()
            {
                ID = 2,
                StackName = "ZK"
            };
            mystack.Push(mystack2);



            MyNode mystack3 = new MyNode()
            {
                ID = 2,
                StackName = "CL"
            };
            mystack.Push(mystack3);
            var item1=mystack.Pop();
            var item2=mystack.Pop();
            var item3=mystack.Pop();
            int ed=0;

            //StackTest.Test();
            //QueueArrayTest.Test();
            //dynamic helloWorld = new ConsoleProject.KingAOP.HelloWorld();
            //helloWorld.HelloWorldCall();
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
