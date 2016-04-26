using ConsoleProject.Interface;
using ConsoleProject.OrderAOP;
using ConsoleProject.OrderAOP.First;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject.Test
{
    public class OrderAOPTest : IBaseTest
    {
        public void Invoke()
        {
            Order order = new Order() { Id = 1, Name = "lee", Count = 10, Price = 100.00, Desc = "订单测试" };
            IOrderProcessor orderprocessor = new OrderProcessorDecorator(new OrderProcessor());
            orderprocessor.Submit(order);
            Console.ReadLine();
        }
    }
}
