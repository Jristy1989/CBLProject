using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject.Decorator
{
    public class RepositoryFactory
    {
        //public static IRepository<T> Create<T>()
        //{
        //    var repository = new Repository<T>();
        //    var dynamicProxy = new DynamicProxy<IRepository<T>>(repository);
        //    return dynamicProxy.GetTransparentProxy() as IRepository<T>;
        //}

        //public static IRepository<T> Create<T>()
        //{
        //    var repository = new Repository<T>();
        //    var decoratedRepository =
        //      (IRepository<T>)new DynamicProxy<IRepository<T>>(
        //      repository).GetTransparentProxy();
        //    // Create a dynamic proxy for the class already decorated
        //    decoratedRepository =
        //      (IRepository<T>)new AuthenticationProxy<IRepository<T>>(
        //      decoratedRepository).GetTransparentProxy();
        //    return decoratedRepository;
        //}

        //public static IRepository<T> Create<T>()
        //{
        //    var repository = new Repository<T>();
        //    var dynamicProxy = new DynamicProxy<IRepository<T>>(repository)
        //    {
        //        Filter = m => !m.Name.StartsWith("Get")
        //    };
        //    return dynamicProxy.GetTransparentProxy() as IRepository<T>;
        //}
        private static void Log(string msg, object arg = null)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(msg, arg);
            Console.ResetColor();
        }
        public static IRepository<T> Create<T>()
        {
            var repository = new Repository<T>();
            var dynamicProxy = new DynamicProxy<IRepository<T>>(repository);
            dynamicProxy.BeforeExecute += (s, e) => Log(
              "Before executing '{0}'", e.MethodName);
            dynamicProxy.AfterExecute += (s, e) => Log(
              "After executing '{0}'", e.MethodName);
            dynamicProxy.ErrorExecuting += (s, e) => Log(
              "Error executing '{0}'", e.MethodName);
            dynamicProxy.Filter = m => !m.Name.StartsWith("Get");
            return dynamicProxy.GetTransparentProxy() as IRepository<T>;
        }
    }
}
