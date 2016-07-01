using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Proxies;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject.VerifyProxy
{
    //从ProxyAttribute继承，自动实现RealProxy植入
    [AttributeUsage(AttributeTargets.Class)]
    class SqlVerifyProxyAttribute : ProxyAttribute
    {
        //覆写CreateInstance函数，返回我们自建的代理
        public override MarshalByRefObject CreateInstance(Type serverType)
        {
            MarshalByRefObject obj = base.CreateInstance(serverType);
            SqlVerifyProxy proxy = new SqlVerifyProxy(serverType, obj);
            return (MarshalByRefObject)proxy.GetTransparentProxy();
        }
    }
}
