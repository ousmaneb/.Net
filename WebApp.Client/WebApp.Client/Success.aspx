<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="success.aspx.cs" Inherits="WebApp.Client.Success" %>

<asp:Content runat="server" ContentPlaceHolderID="PageViewHolder">
  <asp:Label runat="server" ID="success_lbl" Font-Size="X-Large" ForeColor="Green">Contact was added successfully!!!</asp:Label>
  <br />
  <br />
  <asp:HyperLink runat="server" NavigateUrl="~/default.aspx">return home</asp:HyperLink>
</asp:Content>
