<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="AspWebForms.PlanView.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Search Plan</title>


    <link rel="stylesheet" type="text/css" href="StyleSheet.less"/>

</head>
<body>
<form id="form1" runat="server">
    <div>
        <h1 class="title1">INSURANCE WEB APP: Plans' Summary</h1>

        <div>
            <asp:TextBox ID="txtsearch" runat="server"></asp:TextBox>
            <asp:Button ID="btnSearch" runat="server" OnClick="btnSearch_Click" Text="Search"/>


        </div>
        <div>
            <asp:GridView ID="gvPlan" runat="server" AutoGenerateColumns="false" AlternatingRowStyle-BackColor="#ccff99" AlternatingRowStyle-BorderStyle="Inset">
                <Columns>
                    <asp:BoundField DataField="PlanId" HeaderText="Id"/>
                    <asp:BoundField DataField="PlanName" HeaderText="Plan Name"/>

                    <asp:BoundField DataField="Descr" HeaderText="Plan Description"/>

                </Columns>
            </asp:GridView>
        </div>

        <a href="Create.aspx">Create.aspx</a><br/>
        <a href="../MemberView/Index.aspx">../MemberView/Index.aspx</a><br/>
        <a href="../MemberView/Insert.aspx">../MemberView/Insert.aspx</a>

    </div>
</form>
</body>
</html>