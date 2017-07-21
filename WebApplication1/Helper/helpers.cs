using System;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Helpers
{
    public static class hp
    {
        public static string ShowH1(this HtmlHelper helper,  string text) {

            return "<h1>" + text + "</h1>";
        }

    }
}
