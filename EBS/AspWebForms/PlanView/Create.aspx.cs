//using PCOLibrary.BAL.Actions;
using PMCLibrary.BAL.Actions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PMCLibrary.BAL.Actions.Interface;
using PMCLibrary.BAL.Model;

namespace AspWebForms.PlanView
{
  public partial class Create : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnCreate_Click(object sender, EventArgs e)
    {
     
      IAction<PlanModel> actionobj = new PlanAction();
      PlanModel model = new PlanModel();
      model.PlanName = txtPlanName.Text;
      model.Descr = txtDescr.Text;
      model.DetuctibleValue = Convert.ToDouble(txtDetuc.Text);
      lblResult.Text = actionobj.Insert(model).ToString();
    }
  }
}