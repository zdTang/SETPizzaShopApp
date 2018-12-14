using System.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SETPizzaShopApp
{
    /// <summary>
    /// Summary description for server
    /// </summary>
    public class server : IHttpHandler
    {

        
        public void ProcessRequest(HttpContext context)
        {
            string strType = context.Request.Params["type"];// parse parameters




            context.Response.ContentType = "text/plain";
            context.Response.Write("Hello World");
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}