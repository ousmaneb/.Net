using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.Client.Controls
{
  /// <summary>
  /// 
  /// </summary>
  public partial class Login : System.Web.UI.UserControl
  { 
    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {
      if (Request.QueryString["user"] == null)
      {
        return;
      }

      if (bool.Parse(Request.QueryString["user"]))
      {
        login_button.Visible = false;
        logout_panel.Visible = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void login_button_Click(object sender, EventArgs e)
    {
      login_panel.Visible = !login_panel.Visible;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void submit_login_Click(object sender, EventArgs e)
    {
      Response.Redirect("~/default.aspx?user=true");
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void logout_button_Click(object sender, EventArgs e)
    {
      Response.Redirect("~/default.aspx");
    }
  }
}
