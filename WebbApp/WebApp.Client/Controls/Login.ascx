<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Login.ascx.cs" Inherits="WebApp.Client.Controls.Login" %>

<asp:Button runat="server" ID="login_button" Text="Login" OnClick="login_button_Click" />

<asp:Panel runat="server" ID="login_panel" Visible="false">
  <asp:Label runat="server">username</asp:Label>
  <asp:TextBox runat="server" ID="username"></asp:TextBox>
  <asp:Label runat="server">password</asp:Label>
  <asp:TextBox runat="server" ID="password" TextMode="Password"></asp:TextBox>
  <asp:Button runat="server" ID="submit_login" Text="Submit" OnClick="submit_login_Click" />
</asp:Panel>

<asp:Panel runat="server" ID="logout_panel" Visible="false">
  <asp:Label runat="server" ID="greeting">hello, user</asp:Label>
  <asp:Button runat="server" ID="logout_button" Text="Logout" OnClick="logout_button_Click" />
</asp:Panel>
