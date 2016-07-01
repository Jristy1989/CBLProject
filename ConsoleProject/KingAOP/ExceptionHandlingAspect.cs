using KingAOP.Aspects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject.KingAOP
{
    class ExceptionHandlingAspect : OnMethodBoundaryAspect
    {
        public override void OnException(MethodExecutionArgs args)
        {
            var str = new StringBuilder();
            str.AppendLine();
            str.Append(args.Exception.Message);
            str.AppendLine();

            if (args.Instance != null)
            {
                var instType = args.Instance.GetType();
                str.AppendFormat("Type = {0}; ", instType.Name);
                foreach (var property in instType.GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly))
                {
                    str.AppendFormat("{0} = {1}; ", property.Name, property.GetValue(args.Instance, null));
                }
            }
            str.AppendLine();
            Console.WriteLine(str.ToString());

            args.FlowBehavior = FlowBehavior.RethrowException;
        }
    }
}