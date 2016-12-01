<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="AspWebForms.Users.Register" MasterPageFile="~/Static Pages/Insurance.Master"%>

<asp:Content ID="ControlId" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
  <div  style="text-align: center">
    <h4 style="font-size: medium">Register a new user</h4>
    <hr/>
    <p>
      <asp:Literal runat="server" ID="StatusMessage"/>
    </p>
    <div style="margin-bottom: 10px">
      <asp:Label runat="server" AssociatedControlID="UserName">User name</asp:Label>
      <div>
        <asp:TextBox runat="server" ID="UserName"/>
      </div>
    </div>
    <div style="margin-bottom: 10px">
      <asp:Label runat="server" AssociatedControlID="Password">Password</asp:Label>
      <div>
        <asp:TextBox runat="server" ID="Password" TextMode="Password"/>
      </div>
    </div>
    <div style="margin-bottom: 10px">
      <asp:Label runat="server" AssociatedControlID="ConfirmPassword">Confirm password</asp:Label>
      <div>
        <asp:TextBox runat="server" ID="ConfirmPassword" TextMode="Password"/>
      </div>
    </div>
    <div>
      <div>
        <asp:Button CssClass="btn btn-primary" runat="server" OnClick="CreateUser_Click" Text="Register"/>
      </div>
    </div>
  </div>
  <br/> <br/> <br/>
</asp:Content>