using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS_EFCodeFirst.Auth
{
    public class Logged:AuthorizeAttribute
    {
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            var user = httpContext.Session["User"];
            if (user != null)
            {
                return true;
            }

            return false;
        }
    }
}