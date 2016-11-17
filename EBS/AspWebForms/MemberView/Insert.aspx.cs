using System;
using System.Web.UI;
using PMCLibrary.BAL.Actions;
using PMCLibrary.BAL.Model;

namespace AspWebForms.MemberView
{
  public partial class Insert : Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      if (!IsPostBack)
      {
        BindDropDown();
        
          
        Calendar1.EndDate = DateTime.Today;
      }
    }


    private void BindDropDown()
    {
      ddlPlan.DataSource = new PlanAction().Get();
      ddlPlan.DataValueField = "PlanId";
      ddlPlan.DataTextField = "PlanName";
      ddlPlan.DataBind();
    }

    protected void btnCreate_Click(object sender, EventArgs e)
    {
      var model = new MemberModel(Convert.ToInt32(ddlPlan.SelectedValue),
        txtFirstName.Text,
        txtLastName.Text,
        txtDateOfBirth.Text,
        txtGender.Text,
        txtUserName.Text);
      var result = new MemberAction().Insert(model);
    }
  }
}