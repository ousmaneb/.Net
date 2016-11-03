using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApp.Domain;
using WebApp.Domain.Models;

namespace WebApp.Client
{
  public partial class _default : System.Web.UI.Page
  {
    private static DomainHelper dh = new DomainHelper();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {
      if (IsPostBack)
      {

      }
      else
      {

      }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void add_btn_Click(object sender, EventArgs e)
    {
      //var contact = new Contact(first_txt.Text, last_txt.Text, address_txt.Text);
      //var task = await dh.AddContactAsync(contact);

      //if (task)
      //{
      //  Response.Redirect("~/success.aspx");
      //}
      //else
      //{
      //  Response.Redirect("~/failure.aspx");
      //}

      success_panel.Visible = !success_panel.Visible;
    }
  }
}
