using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PMCLibrary.BAL.Actions;

namespace AspWebForms.MemberView
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
            gvMember.DataSource = new MemberAction().Get();
            gvMember.DataBind();
        }
    }
}