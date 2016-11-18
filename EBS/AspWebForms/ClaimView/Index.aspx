<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="AspWebForms.ClaimView.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
  <link rel="stylesheet" type="text/css" href="../PlanView/StyleSheet.less"/>
</head>
<body>
        <form id="form1" runat="server">
    <div>
         <h1 class="title1">Claims' List</h1>
    <asp:GridView ID="gvClaim" runat="server" AutoGenerateColumns="false" CssClass="table table-hover" >
        <Columns>
            <asp:BoundField DataField="ClaimId" HeaderText="Claim Id"  Visible="False"/>
            <asp:BoundField DataField="ClaimDate" HeaderText="Claim Date" />
            <asp:BoundField DataField="DueDate" HeaderText="Due Date" />
            <asp:BoundField DataField="ClaimAmount" HeaderText="Claim Amount" />
       
            
            <asp:TemplateField HeaderText="Member First Name">
                <ItemTemplate>
                    <asp:Label id="lblName" runat="server" Text='<%# Eval("Member.FirstName")%>' ></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
          
             <asp:TemplateField HeaderText="Member Last Name">
                <ItemTemplate>
                    <asp:Label id="lblName" runat="server" Text='<%# Eval("Member.LastName")%>' ></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    </div>
          <a href="Create.aspx">../Create.aspx</a><br/>
          <a href="../MemberView/Index.aspx">../MemberView/Index.aspx</a><br/>
          <a href="../MemberView/Insert.aspx">../MemberView/Insert.aspx</a><br/>
          <a href="../PlanView/Create.aspx">../PlanView/Create.aspx</a><br/>
          <a href="../PlanView/Index.aspx">../PlanView/Index.aspx</a><br/>

    </form>
</body>
</html>
