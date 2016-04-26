using ConsoleProject.Decorator;
using ConsoleProject.Interface;
using System;
using System.Security.Principal;
using System.Threading;

namespace ConsoleProject.Test
{
    public class DecoratorTest : IBaseTest
    {
        public void Invoke()
        {
            //Console.WriteLine("***\r\n Begin program - no logging\r\n");
            //IRepository<Customer> customerRepository =
            //  new Repository<Customer>();
            //var customer = new Customer
            //{
            //    Id = 1,
            //    Name = "Customer 1",
            //    Address = "Address 1"
            //};
            //customerRepository.Add(customer);
            //customerRepository.Update(customer);
            //customerRepository.Delete(customer);
            //Console.WriteLine("\r\nEnd program - no logging\r\n***");
            //Console.ReadLine();
            Console.WriteLine("***\r\n Begin program - logging with dynamic proxy\r\n");
            // IRepository<Customer> customerRepository =
            //   new Repository<Customer>();
            // IRepository<Customer> customerRepository =
            //   new LoggerRepository<Customer>(new Repository<Customer>());
            //IRepository<Customer> customerRepository =
            //  RepositoryFactory.Create<Customer>();
            //var customer = new Customer
            //{
            //    Id = 1,
            //    Name = "Customer 1",
            //    Address = "Address 1"
            //};
            //customerRepository.Add(customer);
            //customerRepository.Update(customer);
            //customerRepository.Delete(customer);
            //Console.WriteLine("\r\nEnd program - logging with dynamic proxy\r\n***");
            //Console.ReadLine();
            Console.WriteLine(
  "***\r\n Begin program - logging and authentication\r\n");
            Console.WriteLine("\r\nRunning as admin");
            Thread.CurrentPrincipal =
              new GenericPrincipal(new GenericIdentity("Administrator"),
              new[] { "ADMIN" });
            IRepository<Customer> customerRepository =
              RepositoryFactory.Create<Customer>();
            var customer = new Customer
            {
                Id = 1,
                Name = "Customer 1",
                Address = "Address 1"
            };
            customerRepository.Add(customer);
            customerRepository.Update(customer);
            customerRepository.Delete(customer);
            Console.WriteLine("\r\nRunning as user");
            Thread.CurrentPrincipal =
              new GenericPrincipal(new GenericIdentity("NormalUser"),
              new string[] { });
            customerRepository.Add(customer);
            customerRepository.Update(customer);
            customerRepository.Delete(customer);
            Console.WriteLine(
              "\r\nEnd program - logging and authentication\r\n***");
            Console.ReadLine();
        }
    }
}
