using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject
{
    class Program
    {
        [Import("chinese_hello")]
        public Person oPerson { get; set; }
        //static void Main(string[] args)
        //{
        //    var oProgram = new Program();
        //    oProgram.MyComposePart();
        //    var strRes = oProgram.oPerson.SayHello("李磊");
        //    Console.WriteLine(strRes);

        //    Console.Read();
        //}

        void MyComposePart()
        {
            var catalog = new AssemblyCatalog(Assembly.GetExecutingAssembly());
            var container = new CompositionContainer(catalog);

            //将部件（part）和宿主程序添加到组合容器
            container.ComposeParts(this);
        }
    }

}
