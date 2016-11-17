using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PMCLibrary.BAL.Actions;

namespace AspWebForms.PlanView
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                BindData();
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
            gvPlan.DataSource = new PlanAction().Get(v);
            gvPlan.DataBind();
        }
    }
}
