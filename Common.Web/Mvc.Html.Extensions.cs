using System.Web.Mvc;

namespace Gongchengshi.Web
{
   public static class Html
   {
      public static MvcHtmlString ImageLink(this HtmlHelper htmlHelper, string imageUrl, string actionName, object routeValues = null)
      {
         var urlHelper = new UrlHelper(htmlHelper.ViewContext.RequestContext);

         var html = string.Format("<a href=\"{0}\"><image src=\"{1}\" /></a>", urlHelper.Action(actionName, routeValues), urlHelper.Content(imageUrl));

         return new MvcHtmlString(html);
      }
   }
}
