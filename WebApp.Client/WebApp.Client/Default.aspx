<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="default.aspx.cs" Inherits="WebApp.Client._Default" %>

<asp:Content runat="server" ContentPlaceHolderID="PageViewHolder">
  <asp:Label runat="server" ID="first_lbl">First Name</asp:Label>
  <asp:TextBox runat="server" ID="first_txt"></asp:TextBox>
  <br />
  <br />

  <asp:Label runat="server" ID="last_lbl">Family Name</asp:Label>
  <asp:TextBox runat="server" ID="last_txt"></asp:TextBox>
  <br />
  <br />

  <asp:Label runat="server" ID="address_lbl">Address</asp:Label>
  <asp:TextBox runat="server" ID="address_txt" TextMode="MultiLine"></asp:TextBox>
  <br />
  <br />

  <asp:Button runat="server" ID="add_btn" Text="Add Contact" />
</asp:Content>

