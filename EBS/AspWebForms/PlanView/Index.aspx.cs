using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using PMCLibrary.BAL.Actions;
using PMCLibrary.BAL.Model;

namespace AspWebForms.PlanView
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
            gvPlan.DataSource = new PlanAction().Get();
            gvPlan.DataBind();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            BindData(Convert.ToInt32(txtsearch.Text));
        }

        private void BindData(int v)
        {
            GridView1.DataSource = new PlanAction().Get(v);
            GridView1.DataBind();
        }

        private void BindData1()
        {
            GridView1.DataSource = new PlanAction().Get();
            GridView1.DataBind();
        }




    protected void gvPlan_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            var index = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "EditRow")
            {
                //Get the value of command argument, i.e cuurent row index.
                var row = gvPlan.Rows[index];


                //ddlPlan.Text = row.Cells[1].Text;
                descr.Text = row.Cells[2].Text;
                dectVal.Text = row.Cells[3].Text;

                BindDropDown();
                var lbl = (Label) row.FindControl("lblName");
                ddlPlan.SelectedIndex = ddlPlan.Items.IndexOf(ddlPlan.Items.FindByText(lbl.Text));

                ViewState["Plan_id"] = gvPlan.DataKeys[index].Value;

                ModalPopupExtender1.Show();
            }
            else if (e.CommandName == "DeleteRow")
            {
                ViewState["PlanId"] = gvPlan.DataKeys[index].Value;
            }
        }


        protected void btnOkay_Click(object sender, EventArgs e)
        {
            var obj = new PlanModel();


            obj.Descr = descr.Text;
            obj.DetuctibleValue = Convert.ToDouble(dectVal.Text);

            obj.PlanName = ddlPlan.SelectedItem.Text;
            obj.PlanId = Convert.ToInt32(ViewState["Plan_id"]);

            var result = new PlanAction().Update(obj);
            BindData();
            udp.Update();
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
        }
    }
}