using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PMCLibrary.BAL.Actions;
//using PMCLibrary.BAL.Actions;
using PMCLibrary.BAL.Model;

namespace AspWebForms.ClaimView
{
  public partial class Create : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      if (!IsPostBack)
      {
        BindDropDown();


        Calendar1.EndDate = DateTime.Today;
        Calendar2.StartDate = DateTime.Today;
      }
    }


    private void BindDropDown()
    {
      ddlClaim.DataSource = new MemberAction().Get();
      ddlClaim.DataValueField = "MemberId";
      ddlClaim.DataTextField = "MemberId";
      ddlClaim.DataBind();
    }

    protected void btnCreate_Click(object sender, EventArgs e)
    {


      int val;
      var r = int.TryParse(txtAmount.Text, out val);
      if (!r)
        return;

      var model = new ClaimModel(Convert.ToInt32(ddlClaim.SelectedValue),
        Convert.ToDateTime(txtClaimDate.Text),
        Convert.ToDateTime(txtDueDate.Text),
        Convert.ToDouble(txtAmount.Text));



      var result = new ClaimAction().Insert(model);

      if (result == true)
        lblResult.Text = "Claim Has Been Added Successfully! ";
      else
        lblResult.Text = "Claim Is Not Added ";
    }
  }
}