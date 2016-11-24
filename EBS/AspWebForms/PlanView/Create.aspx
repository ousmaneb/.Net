﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Create.aspx.cs" Inherits="AspWebForms.PlanView.Create" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title>Create Insurance</title>
  <link rel="stylesheet" type="text/css" href="StyleSheet.less"/>

</head>
  

<body>
<form id="form1" runat="server">
  

  
  
  
  

  <div>
    <h1 class="title1">INSURANCE WEB APP: Create New Insurance</h1>
    <table class="t">


      <tr>
        <td>
          <label>Name</label>
        </td>
        <td>
          <asp:TextBox ID="txtPlanName" Font-Size="Medium" runat="server"></asp:TextBox>
          <asp:RequiredFieldValidator ID="rqvPlanName"
                                      runat="server"
                                      ControlToValidate="txtPlanName"
                                      ErrorMessage="Name is Required"
                                      SetFocusOnError="true"
                                      BackColor="yellow">

          </asp:RequiredFieldValidator>
          <asp:RegularExpressionValidator ID="regNamePlan" runat="server"
                                          ControlToValidate="txtPlanName"
                                          ValidationExpression="^[a-zA-Z'.]{1,25}$"
                                          Text="Enter a valid name" SetFocusOnError="true"
                                      BackColor="yellow"/>
        </td>
      </tr>
      <tr>
        <td>
          <label>Description</label>
        </td>
        <td>
          <asp:TextBox ID="txtDescr" Font-Size="Medium" runat="server"></asp:TextBox>
          <asp:RegularExpressionValidator ID="RegNameDescr" runat="server"
                                          ControlToValidate="txtDescr"
                                          ValidationExpression="^[a-zA-Z''-'\s]{1,25}$"
                                          Text="Enter a valid Description" SetFocusOnError="true"
                                      BackColor="yellow"/>
        </td>
      </tr>
      <tr>
        <td>
          <label>Detuctible Value</label>
        </td>
        <td>
          <asp:TextBox ID="txtDetuc" Font-Size="Medium" runat="server"></asp:TextBox>
          <asp:RegularExpressionValidator ID="RegNameDetuc" runat="server"
                                          ControlToValidate="txtDetuc"
                                          ValidationExpression="^\d+(\.\d\d)?$"
                                          Text="Enter a positive number" SetFocusOnError="true"
                                      BackColor="yellow"/>
        </td>
      </tr>
      <tr>
        <td>
          <asp:Button ID="btnCreate" runat="server" Text="Create" OnClick="btnCreate_Click"/>
        </td>
        <td>
          <asp:Label ID="lblResult" runat="server"></asp:Label>
        </td>
      </tr>
    
    </table>


  </div>
  
    <a href="../ClaimView/Create.aspx">../ClaimView/Create.aspx</a><br/>
      <a href="../ClaimView/Index.aspx">../ClaimView/Index.aspx</a><br/>
      <a href="Index.aspx">../PlanView/Index.aspx</a><br/>
      <a href="../MemberView/Index.aspx">../MemberView/Index.aspx</a><br/>
      <a href="../MemberView/Insert.aspx">../MemberView/Insert.aspx</a>
</form>
</body>
</html>