using CBLProject.Models;
using System.Collections.Specialized;
using System.Web.Mvc;

namespace CBLProject.Controllers
{
    public class ReceiveController : Controller
    {
        // GET: Receive
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Echo_Multi_DataTypeArgumentGet()
        {
            NameValueCollection nameValueCollection = System.Web.HttpContext.Current.Request.QueryString;
            var parm1 = nameValueCollection["companyId"];
            var parm2 = nameValueCollection["productId"];
            return Content("Get ok");
        }
        [HttpPost]
        public ActionResult Echo_Multi_DataTypeArgumentPost()
        {
            NameValueCollection nameValueCollection = System.Web.HttpContext.Current.Request.Form;
            var parm1 = nameValueCollection["companyId"];
            var parm2 = nameValueCollection["productId"];
            return Content("Post ok");
        }
        //MVC中封装了NamevalueCollection到了NameValueCollectionProvider中对应FormValueProvider，同理Get就是QueryStringValueProviderProvider
        /*
        原理：
        */

        /// <summary>
        //單一數值型別:單一數值型別當Action函式，包含一個數值型別的函式參數時。
        //Model Binding核心會依照這個函式參數的「參數名稱」作為Key資料，來從NameValueCollectionValueProvider物件中取得對應的Value資料，
        //並且嘗試將Value資料轉型為函式參數的「參數型別」,當成功轉型之後就生成一個「函式參數」。
        //後續ASP.NET MVC就會使用這個函式參數執行Action函式，並且完成接續的工作流程來產生HTTP Response封包回傳給瀏覽器。
        /// </summary>
        /// <param name="companyId"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Echo_Multi_DataTypeArgument(string companyId)
        {
            this.ViewBag.CompanyId = companyId;
            return Content("Post ok");
        }

        /// <summary>
        /// 多個數值型別:當Action函式，包含多個數值型別的函式參數時。Model Binding核心透過生成單一數值型別的流程，
        /// 依序生成每個對應「參數名稱」的函式參數。後續ASP.NET MVC就會使用這些函式參數執行Action函式，
        /// 並且完成接續的工作流程來產生HTTP Response封包回傳給瀏覽器。
        /// </summary>
        /// <param name="companyId"></param>
        /// <param name="productId"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Echo_Multi_DataTypeArgument(string companyId, string productId)
        {
            this.ViewBag.CompanyId = companyId;
            this.ViewBag.ProductId = productId;
            return Content("Post ok");
        }

        public ActionResult IndexMulti()
        {
            return View();
        }
        /// <summary>
        /// 數值型別集合:當Action函式，包含數值型別集合的函式參數時。Model Binding核心會依照這個函式參數的「參數名稱」作為Prefix資料，
        /// 來從NameValueCollectionValueProvider物件中取得所有符合「Prefix資料[索引]」格式的一組Key資料。
        /// 接著Model Binding核心會先依照函式參數的「參數型別」建立一個集合，並且透過生成單一數值型別的流程，依序生成每個對應「Key資料」的資料，來做為這個集合的項目。
        /// 最後ASP.NET MVC就會使用這個集合作為函式參數來執行Action函式，並且完成接續的工作流程來產生HTTP Response封包回傳給瀏覽器。
        /// </summary>
        /// <param name="companyIdArray"></param>
        /// <param name="productIdArray"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Echo_Array_DataTypeArgumentMulti(string[] companyIdArray, string[] productIdArray)
        {
            return Content("Post ok");
        }
        public ActionResult IndexModel()
        {
            return View();
        }
        /// <summary>
        /// 單一參考型別:當Action函式，包含一個參考型別的函式參數時。Model Binding核心會先依照函式參數的「參數型別」建立一個物件，
        /// 並且依序將函式參數的「參數名稱」、物件的「屬性名稱」，組合成為「參數名稱.屬性名稱」格式的Key資料，接著透過生成單一數值型別的流程，
        /// 依序生成每個對應「Key資料」的物件屬性。最後ASP.NET MVC就會使用這個物件作為函式參數來執行Action函式，並且完成接續的工作流程來產生HTTP Response封包回傳給瀏覽器。
        /// </summary>
        /// <param name="company"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Echo_Single_ObjectTypeArgument(Company company)
        {
            return Content("Post ok");
        }

        public ActionResult IndexEcho()
        {
            return View();
        }
        /// <summary>
        /// 多個參考型別:當Action函式，包含多個參考型別的函式參數時。Model Binding核心透過生成單一參考型別的流程，依序生成每個對應「參數名稱」的函式參數。
        /// 後續ASP.NET MVC就會使用這些函式參數執行Action函式，並且完成接續的工作流程來產生HTTP Response封包回傳給瀏覽器。
        /// </summary>
        /// <param name="company"></param>
        /// <param name="product"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Echo_Multi_ObjectTypeArgument(Company company, Product product)
        {
            return Content("Post ok");
        }

        public ActionResult IndexArrayModel()
        {
            return View();
        }
        /// <summary>
        /// 參考型別集合:當Action函式，包含參考型別集合的函式參數時。Model Binding核心會依照這個函式參數的「參數名稱」作為Prefix資料，
        /// 來從NameValueCollectionValueProvider物件中取得所有符合「Prefix資料[索引]」格式的一組Key資料。
        /// 接著Model Binding核心會先依照函式參數的「參數型別」建立一個集合，並且透過生成單一參考型別的流程，依序生成每個對應「Key資料」的資料，來做為這個集合的項目。
        /// 最後ASP.NET MVC就會使用這個集合作為函式參數來執行Action函式，並且完成接續的工作流程來產生HTTP Response封包回傳給瀏覽器。
        /// </summary>
        /// <param name="company"></param>
        /// <param name="product"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Echo_Array_ObjectTypeArgument(Company[] companyArray, Product[] productArray)
        {
            return Content("Post ok");
        }
        public ActionResult IndexArrayMix()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Echo_Multi_MixTypeArgument(string companyId, Product product)
        {
            return Content("Post ok");
        }


        public ActionResult IndexArray_Mix()
        {
            return View();
        }
        /// <summary>
        /// 混合型別集合:當Action函式，包含多個數值型別集合、參考型別集合的函式參數時。
        /// Model Binding核心會依需透過生成數值型別集合、生成參考型別集合的流程，依序生成每個對應「參數名稱」的函式參數。
        /// 後續ASP.NET MVC就會使用這些函式參數執行Action函式，並且完成接續的工作流程來產生HTTP Response封包回傳給瀏覽器。
        /// </summary>
        /// <param name="companyIdArray"></param>
        /// <param name="productArray"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Echo_Array_MixTypeArgument(string[] companyIdArray, Product[] productArray)
        {
            return Content("Post ok");
        }
    }
}