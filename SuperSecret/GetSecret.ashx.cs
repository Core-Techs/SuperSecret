using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SuperSecret
{
    /// <summary>
    /// Summary description for GetSecret
    /// </summary>
    public class GetSecret : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            context.Response.Cache.SetCacheability(HttpCacheability.NoCache);
            context.Response.ContentType = "text/plain";
            var id = context.Request["id"] ?? "";
            var secret = context.Cache.Remove(id);
            context.Response.Write(secret);
        }

        public bool IsReusable
        {
            get
            {
                return true;
            }
        }
    }
}