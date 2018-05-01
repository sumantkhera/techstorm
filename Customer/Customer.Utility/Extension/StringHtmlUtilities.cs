using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Customer.Utility.Extension
{
    public static class StringHtmlUtilities
    {
        private static string _htmlTags =
            "!DOCTYPE|a|abbr|acronym|address|applet|area|article|aside|audio|b|base|basefont|bdi|bdo|big|blockquote|body|br|button|canvas|caption|center|cite|code|col|colgroup|command|datalist|dd|del|details|dfn|dir|div|dl|dt|em|embed|fieldset|figcaption|figure|font|footer|form|frame|frameset|h1|h2|h3|h4|h6|h6|head|header|hgroup|hr|html|i|iframe|img|input|ins|kbd|keygen|label|legend|li|link|map|mark|menu|meta|meter|nav|noframes|noscript|object|ol|optgroup|option|output|p|param|pre|progress|q|rp|rt|ruby|s|samp|script|section|select|small|source|span|strike|strong|style|sub|summary|sup|table|tbody|td|textarea|tfoot|th|thead|time|title|tr|track|tt|u|ul|var|video|wbr|abbr|object";


        public static bool StringContainsHtmlTags(string str)
        {
            return Regex.IsMatch(str, $@"(?s)<\s?({_htmlTags}).*?", RegexOptions.IgnoreCase);
        }
        public static string RemoveHtml(string text)
        {
            var first = Regex.Replace(text, @"<(" + _htmlTags + @").*</(" + _htmlTags + @")>", string.Empty, RegexOptions.IgnoreCase);
            var second = Regex.Replace(first, @"</(" + _htmlTags + @")*?>", string.Empty, RegexOptions.IgnoreCase);

            return Regex.Replace(second, @"<(" + _htmlTags + @").*(</(" + _htmlTags + @")>)?", string.Empty, RegexOptions.IgnoreCase);
        }
    }
}
