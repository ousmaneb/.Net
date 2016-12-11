<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="AspWebForms.Users.Login" MasterPageFile="~/Static Pages/Insurance.Master" %>

<asp:Content ID="ControlId" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
  <div style="text-align: center">
    <h4 style="font-size: medium">Log In</h4>
    <hr/>
    <asp:PlaceHolder runat="server" ID="LoginStatus" Visible="false">
      <p>
        <asp:Literal runat="server" ID="StatusText"/>
      </p>
    </asp:PlaceHolder>
    <asp:PlaceHolder runat="server" ID="LoginForm" Visible="false">
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
        <div>
          <asp:Button CssClass="btn btn-primary" runat="server" OnClick="SignIn" Text="Log in"/>
        </div>
      </div>
    </asp:PlaceHolder>
    <asp:PlaceHolder runat="server" ID="LogoutButton" Visible="false">
      <div>
        <div>
          <asp:Button CssClass="btn btn-primary" runat="server" OnClick="SignOut" Text="Log out"/>
        </div>
      </div>
    </asp:PlaceHolder>
  </div>
  <br/> <br/> <br/>
  <br/>
  <br/>
  <br/>
</asp:Content>