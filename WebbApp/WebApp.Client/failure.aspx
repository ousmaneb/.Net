<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="failure.aspx.cs" Inherits="WebApp.Client.failure" %>

<asp:Content runat="server" ContentPlaceHolderID="PageViewHolder">
  <asp:Label runat="server" ID="failure_lbl" Font-Size="X-Large" ForeColor="Red">Failed to add contact!!!</asp:Label>
  <br />
  <br />

  <asp:HyperLink runat="server" NavigateUrl="~/default.aspx">return home</asp:HyperLink>
</asp:Content>
