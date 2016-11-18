<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Insert.aspx.cs" Inherits="AspWebForms.MemberView.Insert" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title></title>
  <link href="../Content/bootstrap.min.css" rel="stylesheet"/>
  <link rel="stylesheet" type="text/css" href="../PlanView/StyleSheet.less"/>
  <script src="../scripts/bootstrap-datepicker.js"></script>


</head>
<body>
<h1 class="title1">Create New Member</h1>


<form id="form1" runat="server">
  <asp:ScriptManager id="xyz" runat="server"></asp:ScriptManager>
  <div>
    <table class="table-hover">

      <tr>
        <td>
          <label class="text-uppercase">First Name:</label>
        </td>
        <td>
          <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
           <asp:RegularExpressionValidator ID="regFirstName" runat="server"
                                          ControlToValidate="txtFirstName"
                                          ValidationExpression="^[a-zA-Z'.]{1,10}$"
                                          Text="Enter a valid Name" SetFocusOnError="true"
                                      BackColor="yellow"/>
        </td>
      </tr>

      <tr>
        <td>
          <label class="text-uppercase">Last Name:</label>
        </td>
        <td>
          <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
                     <asp:RegularExpressionValidator ID="RegLastName" runat="server"
                                          ControlToValidate="txtLastName"
                                          ValidationExpression="^[a-zA-Z'.]{1,10}$"
                                          Text="Enter a valid Name" SetFocusOnError="true"
                                      BackColor="yellow"/>
        </td>
      </tr>

      <tr>
        <td>
          <label class="text-uppercase">Date Of Birth:</label>
        </td>
        <td>

          <asp:TextBox ID="txtDateOfBirth" runat="server"/>
         
          <ajaxToolkit:CalendarExtender ID="Calendar1" runat="server" TargetControlID="txtDateOfBirth"   Format="MM/dd/yyyy">
          </ajaxToolkit:CalendarExtender>


        </td>
      </tr>

      <tr>
        <td>
          <label class="text-uppercase">Gender:</label>
        </td>
        <td>
          <asp:TextBox ID="txtGender" runat="server"></asp:TextBox>
          <asp:RegularExpressionValidator ID="RegGender" runat="server"
                                          ControlToValidate="txtGender"
                                          ValidationExpression="^M(ale)?$|^F(emale)?$"
                                          Text="Enter M/F or Male/Female" SetFocusOnError="true"
                                      BackColor="yellow"/>
        </td>
      </tr>

      <tr>
        <td>
          <label class="text-uppercase">User Name:</label>
        </td>
        <td>
          <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
                  <asp:RegularExpressionValidator ID="RegUserName" runat="server"
                                          ControlToValidate="txtUserName"
                                          ValidationExpression="^[A-Za-z][A-Za-z0-9._]{5,14}$"
                                          Text="Enter a valid User Name" SetFocusOnError="true"
                                      BackColor="yellow"/>
        </td>
      </tr>

      <tr>
        <td>
          <label class="text-uppercase">Plan:</label>
        </td>
        <td>
          <asp:DropDownList ID="ddlPlan" runat="server"></asp:DropDownList>
        </td>
      </tr>


    </table>

    <p class="t">
      <asp:Button ID="btnCreate" runat="server" CssClass="btn btn-primary" OnClick="btnCreate_Click" Text="Create"/>
      <asp:Label ID="lblResult" runat="server"></asp:Label>
    </p>
  </div>
  <a href="../ClaimView/Create.aspx">../ClaimView/Create.aspx</a><br/>
  <a href="../ClaimView/Index.aspx">../ClaimView/Index.aspx</a><br/>
  <a href="Index.aspx">../Index.aspx</a><br/>
  <a href="../PlanView/Create.aspx">../PlanView/Create.aspx</a><br/>
  <a href="../PlanView/Index.aspx">../PlanView/Index.aspx</a>
  
  


</form>


</body>
</html>