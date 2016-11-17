﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Insert.aspx.cs" Inherits="AspWebForms.MemberView.Insert" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../Content/bootstrap.min.css" rel="stylesheet"/>
    <link rel="stylesheet" type="text/css" href="../PlanView/StyleSheet.less"/>
</head>
<body>
<h1 class="title1">Create New Member</h1>
    
     
<form id="form1" runat="server">
    <div>
        <table class="table-hover">
           
            <tr>
                <td>
                    <label class="text-uppercase">First Name:</label>
                </td>
                <td>
                    <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td>
                    <label class="text-uppercase">Last Name:</label>
                </td>
                <td>
                    <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td>
                    <label class="text-uppercase">Date Of Birth:</label>
                </td>
                <td>
                    <asp:TextBox ID="txtDateOfBith" runat="server"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td>
                    <label class="text-uppercase">Gender:</label>
                </td>
                <td>
                    <asp:TextBox ID="txtGender" runat="server"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td>
                    <label class="text-uppercase">User Name:</label>
                </td>
                <td>
                    <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
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
        </p>
    </div>

    <a href="Index.aspx">Index.aspx</a><br/>
    <a href="../PlanView/Create.aspx">../PlanView/Create.aspx</a><br/>
    <a href="../PlanView/Index.aspx">../PlanView/Index.aspx</a>
</form>


</body>
</html>