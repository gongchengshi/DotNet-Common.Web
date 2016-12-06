using System.Text.RegularExpressions;

namespace Gongchengshi.Web
{
   /// <summary>
   /// Methods to remove HTML from strings.
   /// </summary>
   public static class HtmlRemoval
   {
      private static string StripTagsRegex(string source)
      {
         return Regex.Replace(source, "<.*?>", string.Empty);
      }

      private static readonly Regex _htmlRegex = new Regex("<.*?>", RegexOptions.Compiled);

      private static string StripTagsRegexCompiled(string source)
      {
         return _htmlRegex.Replace(source, string.Empty);
      }

      private static string StripTagsCharArray(string source)
      {
         var array = new char[source.Length];
         var arrayIndex = 0;
         var inside = false;

         foreach (char c in source)
         {
            if (c == '<')
            {
               inside = true;
               continue;
            }
            if (c == '>')
            {
               inside = false;
               continue;
            }
            if (!inside)
            {
               array[arrayIndex] = c;
               arrayIndex++;
            }
         }
         return new string(array, 0, arrayIndex);
      }

      public static string StripTags(string source)
      {
         return StripTagsCharArray(source);
      }
   }
}
