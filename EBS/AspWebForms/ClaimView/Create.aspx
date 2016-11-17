<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Create.aspx.cs" Inherits="AspWebForms.ClaimView.Create" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
  <link href="../Content/bootstrap.min.css" rel="stylesheet"/>
  <link rel="stylesheet" type="text/css" href="../PlanView/StyleSheet.less"/>
  <script src="../scripts/bootstrap-datepicker.js"></script>

</head>
<body>
<h1 class="title1">Create New Claim</h1>


<form id="form1" runat="server">
  <asp:ScriptManager id="xyz" runat="server"></asp:ScriptManager>
  <div>
    <table class="table-hover">
      
      
          <tr>
        <td>
          <label class="text-uppercase">MemberId </label> &nbsp;
        </td>
        <td>
          <asp:DropDownList ID="ddlClaim" runat="server"></asp:DropDownList>
        </td>
      </tr>
      

      <tr>
        <td>
          <label class="text-uppercase">Claim Date </label> &nbsp;
        </td>
        <td>
          <asp:TextBox ID="txtClaimDate" runat="server"/>
         
          <ajaxToolkit:CalendarExtender ID="Calendar1" runat="server" TargetControlID="txtClaimDate"   Format="MM/dd/yyyy">
          </ajaxToolkit:CalendarExtender>
        </td>
      </tr>
      
            <tr>
        <td>
          <label class="text-uppercase">Due Date </label> &nbsp;
        </td>
        <td>
          <asp:TextBox ID="txtDueDate" runat="server"/>
         
          <ajaxToolkit:CalendarExtender ID="Calendar2" runat="server" TargetControlID="txtDueDate"   Format="MM/dd/yyyy">
          </ajaxToolkit:CalendarExtender>
        </td>
      </tr>
      
      


      <tr>
        <td>
          <label class="text-uppercase">Claim Amount </label> &nbsp;
        </td>
        <td>
          <asp:TextBox ID="txtAmount" runat="server"></asp:TextBox>
        </td>
      </tr>

    </table>
    <br/>
    <p class="t">
      <asp:Button ID="btnCreate" runat="server" CssClass="btn btn-primary" OnClick="btnCreate_Click" Text="Create"/>
      <asp:Label ID="lblResult" runat="server"></asp:Label>
    </p>
  </div>

  <a href="Index.aspx">/MemberView/Index.aspx</a><br/>
  <a href="../PlanView/Create.aspx">../PlanView/Create.aspx</a><br/>
  <a href="../PlanView/Index.aspx">../PlanView/Index.aspx</a>
</form>


</body>
</html>
