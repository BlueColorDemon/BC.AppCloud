using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace BC.AppCloud.Common
{
    public static class BcAppArticle
    {
        public static string GetStrByFilter(string sourceContent, string pattern, string replacement)
        {
            Regex reg = new Regex("NAME=(.+);");
            string modified = reg.Replace("", "NAME=WANG;");
            return "";
        }
    }
}