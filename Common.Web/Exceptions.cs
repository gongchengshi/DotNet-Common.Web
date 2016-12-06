using System;

namespace Gongchengshi.Web
{
   public class InvalidCookieValue : Exception
   {
      public InvalidCookieValue(string cookieName)
         : this(cookieName, null)
      { }

      public InvalidCookieValue(string cookieName, Exception innerException) :
         base(string.Format("Cookie does not contain a valid value for '{0}'", cookieName), innerException) { }
   }
}
