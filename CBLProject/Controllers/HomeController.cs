using CBLProject.Models;
using Jil;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CBLProject.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult JsonIndex()
        {
            using (var output = new StringWriter())
            {
                JSON.Serialize(
                    new
                    {
                        MyInt = 1,
                        MyString = "hello world",
                    },
                    output
                );
                return Content(output.ToString());
            }
        }


        public ActionResult JsonIndex2()
        {
            using (var output = new StringWriter())
            {
                ValueKey vk = new ValueKey()
                {
                    Key="cbl",
                    Value="111"
                };
                List<ValueKey> list = new List<ValueKey>()
                {
                    vk
                };
                JSON.Serialize(
                    list,
                    output
                );

            
                return Content(output.ToString());
            }
        }
        public ActionResult JsonIndex3()
        {
            var myString= "[{\"Value\":\"111\",\"Key\":\"cbl\"}]";
            using (var input = new StringReader(myString))
            {
                var result = JSON.Deserialize<List<ValueKey>>(input);

                return Content(myString);
            }
        }

        public ActionResult JsonIndex5()
        {
            var casts = (int)JSON.DeserializeDynamic("123");
            int  a= JSON.DeserializeDynamic(@"{""A"":123}").A;
            var indexs = JSON.DeserializeDynamic(@"{""A"":123,""B"":""DSFD""}")["A"];
            foreach (var keyValue in JSON.DeserializeDynamic(@"{""A"":123,""B"":""DSFD""}")) {
                var d = keyValue.Value;
            }
            return Content(a.ToString());
        }
        public ActionResult JsonIndex6()
        {
            using (var output = new StringWriter())
            {
                //LegalUnion lu = new LegalUnion()
                //{
                //    FooInt = 123,
                //    FooString = "safasd"
                //};
                //JSON.Serialize(
                //    lu,
                //    output
                //);
                IllegalUnion iul = new IllegalUnion()
                {
                    FooUInt=1,
                    FooDouble=1.1
                };

                JSON.Serialize(
                    iul,
                    output
                );
                return Content(output.ToString());
            }
        }

    }
}