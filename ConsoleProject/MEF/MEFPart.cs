using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject.MEF
{
    public class MEFPart
    {
        [Import("chinese_hello")]
        public Person oPerson { set; get; }

        [Import("american_hello")]
        public Lazy<Person> oPerson2 { set; get; }

        public  MEFPart()
        {
            var oProgram = new MEFPart();
            oProgram.MyComposePart();

            var strRes = oProgram.oPerson.SayHello("李磊");
            var strRes2 = oProgram.oPerson2.Value.SayHello("Lilei");
            Console.WriteLine(strRes);

            Console.Read();
        }
        void MyComposePart()
        {
            var catalog = new AssemblyCatalog(Assembly.GetExecutingAssembly());
            var container = new CompositionContainer(catalog);

            //将部件（part）和宿主程序添加到组合容器

            container.ComposeParts(this);
        }
    }

    public interface Person
    {
        string SayHello(string name);
    }
    [Export("chinese_hello", typeof(Person))]
    public class Chinese : Person
    {
        public string SayHello(string name)
        {
            return "你好：" + name;
        }
    }

    [Export("american_hello", typeof(Person))]
    public class American : Person
    {
        public string SayHello(string name)
        {
            return "Hello:" + name;
        }
    }
}
