using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using PMCLibrary.BAL.Actions;
using PMCLibrary.BAL.Model;

namespace AspWebForms.MemberView
{
  public partial class Index : Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      if (!IsPostBack)
      {
        BindData();
        BindData1();
      }
    }


    private void BindDropDown()
    {
      ddlPlan.DataSource = new PlanAction().Get();
      ddlPlan.DataValueField = "PlanId";
      ddlPlan.DataTextField = "PlanName";
      ddlPlan.DataBind();
    }

    private void BindData()
    {
      gvMember.DataSource = new MemberAction().Get();
      gvMember.DataBind();
    }


    private void BindData1()
    {
      GridView1.DataSource = new MemberAction().Get();
      GridView1.DataBind();
    }

    //protected void btnEdit_Click(object sender, EventArgs e)
    //{

    //    ModalPopupExtender1.Show();
    //}

    //protected void btnDelte_Click(object sender, EventArgs e)
    //{

    //}
    protected void gvMember_RowCommand(object sender, GridViewCommandEventArgs e)
    {
      var index = Convert.ToInt32(e.CommandArgument);
      if (e.CommandName == "EditRow")
      {
        //Get the value of command argument, i.e cuurent row index.

        var row = gvMember.Rows[index];

        firstname.Text = row.Cells[1].Text;
        lastname.Text = row.Cells[2].Text;
        dob.Text = row.Cells[3].Text;
        gender.Text = row.Cells[4].Text;
        username.Text = row.Cells[5].Text;
        BindDropDown();

        var lbl = (Label) row.FindControl("lblName");
        ddlPlan.SelectedIndex = ddlPlan.Items.IndexOf(ddlPlan.Items.FindByText(lbl.Text));

        ViewState["Mem_id"] = gvMember.DataKeys[index].Value;

        ModalPopupExtender1.Show();
      }
      else if (e.CommandName == "DeleteRow")
      {
        ViewState["Mem_id"] = gvMember.DataKeys[index].Value;
      }
    }

    protected void btnOkay_Click(object sender, EventArgs e)
    {
      var obj = new MemberModel();

      obj.FirstName = firstname.Text;
      obj.Lastname = lastname.Text;
      obj.Dob = dob.Text;
      obj.Gender = gender.Text;
      obj.Username = username.Text;

      obj.PlanId = Convert.ToInt32(ddlPlan.SelectedValue);
      obj.MemberId = Convert.ToInt32(ViewState["Mem_id"]);

      var result = new MemberAction().Update(obj);
      BindData();
      udp.Update();
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
     
    }
  }
}