using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SuperSecret2
{
    public static class Util
    {
        public static string Truncate(this string source, int length)
        {
            return source.Length > length
                ? source.Substring(0, length)
                : source;
        }
    }
}