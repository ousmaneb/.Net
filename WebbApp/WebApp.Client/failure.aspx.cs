using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.Client
{
  /// <summary>
  /// 
  /// </summary>
  public partial class failure : System.Web.UI.Page
  {
    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {
      var uri = Request.UrlReferrer != null ? Request.UrlReferrer.AbsoluteUri : string.Empty;

      if (string.IsNullOrWhiteSpace(uri))
      {
        Response.Redirect("~/default.aspx");
      }
      else if (!uri.ToLower().Contains("default.aspx"))
      {
        Response.Redirect("~/default.aspx");
      }
    }
  }
}
