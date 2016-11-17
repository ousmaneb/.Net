using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PMCLibrary.BAL.Actions;
using PMCLibrary.BAL.Model;

namespace AspWebForms.MemberView
{
    public partial class Insert : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                BindDropDown();
      
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
            MemberModel model = new MemberModel(Convert.ToInt32(ddlPlan.SelectedValue),
                                                   txtFirstName.Text,
                                                   txtLastName.Text,
                                                   txtDateOfBith.Text,
                                                   txtGender.Text,
                                                   txtUserName.Text);
            bool result = new MemberAction().Insert(model);
        }
    }
}