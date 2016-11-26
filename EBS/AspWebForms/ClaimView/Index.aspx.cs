using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using PMCLibrary.BAL.Actions;
using PMCLibrary.BAL.Model;

namespace AspWebForms.ClaimView
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
      ddlFirstName.DataSource = new MemberAction().Get();
      ddlFirstName.DataValueField = "MemberId";
      ddlFirstName.DataTextField = "FirstName";
      ddlFirstName.DataBind();


      ddlLastName.DataSource = new MemberAction().Get();
      ddlLastName.DataValueField = "MemberId";
      ddlLastName.DataTextField = "LastName";
      ddlLastName.DataBind();
    }

    private void BindData()
    {
      gvClaim.DataSource = new ClaimAction().Get();
      gvClaim.DataBind();
    }


    private void BindData1()
    {
      GridView1.DataSource = new ClaimAction().Get();
      GridView1.DataBind();
    }

    protected void gvClaim_RowCommand(object sender, GridViewCommandEventArgs e)
    {
      int index = Convert.ToInt32(e.CommandArgument);
      if (e.CommandName == "EditRow")
      {
        //Get the value of command argument, i.e cuurent row index.

       GridViewRow row = gvClaim.Rows[index];
        txtClaimDate.Text = row.Cells[1].Text;
        txtDueDate.Text = row.Cells[2].Text;
        txtAmount.Text = row.Cells[3].Text;
        BindDropDown();

        Label lbl1 = (Label) row.FindControl("lblFirstName");
        Label lbl2 = (Label) row.FindControl("lblLastName");


        ddlFirstName.SelectedIndex = ddlFirstName.Items.IndexOf(ddlFirstName.Items.FindByText(lbl1.Text));
        ddlLastName.SelectedIndex = ddlLastName.Items.IndexOf(ddlLastName.Items.FindByText(lbl2.Text));
      
        //txtUnitPrice.Text = row.Cells[3].Text;
        ViewState["Claim_id"] = gvClaim.DataKeys[index].Value;

        ModalPopupExtender1.Show();
      }
      else if (e.CommandName == "DeleteRow")
      {
        ViewState["Claim_id"] = gvClaim.DataKeys[index].Value;
      }
    }

    protected void btnOkay_Click(object sender, EventArgs e)
    {
      ClaimModel obj = new ClaimModel();

      obj.ClaimDate = txtClaimDate.Text;
      obj.DueDate = txtDueDate.Text;
      obj.ClaimAmount = Convert.ToDouble(txtAmount.Text);

      obj.Member.FirstName = ddlFirstName.SelectedItem.Text;
      obj.Member.Lastname = ddlLastName.SelectedItem.Text;

  
      obj.ClaimId = Convert.ToInt32(ViewState["Claim_id"]);

      bool result = new ClaimAction().Update(obj);
      BindData();
      udp.Update();
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
    }
  }
}