//using PCOLibrary.BAL.Actions;

using System;
using System.Web.UI;
using PMCLibrary.BAL.Actions;
using PMCLibrary.BAL.Actions.Interface;
using PMCLibrary.BAL.Model;

namespace AspWebForms.PlanView
{
    public partial class Create : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            IAction<PlanModel> actionobj = new PlanAction();
            var model = new PlanModel();
            model.PlanName = txtPlanName.Text;
            model.Descr = txtDescr.Text;
            if (txtDetuc.Text == string.Empty)
                txtDetuc.Text = "";
            else
                model.DetuctibleValue = Convert.ToDouble(txtDetuc.Text);

            lblResult.Text = actionobj.Insert(model).ToString();
        }
    }
}