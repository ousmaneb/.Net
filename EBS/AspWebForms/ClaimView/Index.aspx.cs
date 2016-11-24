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
            ddlMember.DataSource = new MemberAction().Get();
            ddlMember.DataValueField = "MemberId";
            ddlMember.DataTextField = "FirstName";
            ddlMember.DataBind();
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
                Label lbl = (Label) row.FindControl("lblName");
                ddlMember.SelectedIndex = ddlMember.Items.IndexOf(ddlMember.Items.FindByText(lbl.Text));
                //txtUnitPrice.Text = row.Cells[3].Text;
                ViewState["Claim_id"] = gvClaim.DataKeys[index].Value;

                ModalPopupExtender1.Show();
            }
            else if (e.CommandName == "DeleteRow")
            {
                ViewState["Id"] = gvClaim.DataKeys[index].Value;
            }
        }

        protected void btnOkay_Click(object sender, EventArgs e)
        {
            ClaimModel obj = new ClaimModel();
            obj.ClaimDate = txtClaimDate.Text;
            obj.DueDate = txtDueDate.Text;
            obj.ClaimAmount = Convert.ToInt32(txtAmount.Text);

            obj.MemberId = Convert.ToInt32(ddlMember.SelectedValue);
            obj.ClaimId = Convert.ToInt32(ViewState["Claim_id"]);

            var result = new ClaimAction().Update(obj);
            BindData();
            udp.Update();
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
        }
    }
}