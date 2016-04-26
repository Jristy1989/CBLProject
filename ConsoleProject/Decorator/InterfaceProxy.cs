using System;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Proxies;

namespace ConsoleProject.Decorator
{
    internal class InterfaceProxy : RealProxy
    {
        public InterfaceProxy(Type classToProxy)
          : base(classToProxy)
        { }

        public override IMessage Invoke(IMessage msg)
        {
            return msg;
        }
    }
}
