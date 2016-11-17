<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="AspWebForms.MemberView.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="../PlanView/StyleSheet.less"/>
</head>
<body>
    <form id="form1" runat="server">
    <div>
         <h1 class="title1">Members' List</h1>
    <asp:GridView ID="gvMember" runat="server" AutoGenerateColumns="false" CssClass="table table-hover" >
        <Columns>
            <asp:BoundField DataField="MemberId" HeaderText="Member Id" />
            <asp:BoundField DataField="FirstName" HeaderText="First Name" />
            <asp:BoundField DataField="LastName" HeaderText="Last Name" />
            <asp:BoundField DataField="DOB" HeaderText="Date Of Birth" />
            <asp:BoundField DataField="Gender" HeaderText="Gender" />
            <asp:BoundField DataField="UserName" HeaderText="User Name" />
            
            <asp:TemplateField HeaderText="Plan Name">
                <ItemTemplate>
                    <asp:Label id="lblName" runat="server" Text='<%# Eval("Plan.PlanName")%>' ></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    </div>
        <a href="Insert.aspx">/MemberView/Insert.aspx</a><br/>
        <a href="../PlanView/Create.aspx">../PlanView/Create.aspx</a> <br/>
        <a href="../PlanView/Index.aspx">../PlanView/Index.aspx</a>
    </form>
</body>
</html>
