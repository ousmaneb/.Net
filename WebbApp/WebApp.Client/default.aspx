<%@ Page Language="C#" AutoEventWireup="true" Async="true" MasterPageFile="~/Site.Master" CodeBehind="default.aspx.cs" Inherits="WebApp.Client._default" %>

<asp:Content runat="server" ContentPlaceHolderID="PageViewHolder">
  <asp:Label runat="server" ID="first_lbl">First Name</asp:Label>
  <asp:TextBox runat="server" ID="first_txt"></asp:TextBox>
  <br />
  <br />

  <asp:Label runat="server" ID="last_lbl">Last Name</asp:Label>
  <asp:TextBox runat="server" ID="last_txt"></asp:TextBox>
  <br />
  <br />

  <asp:Label runat="server" ID="address_lbl">Address</asp:Label>
  <asp:TextBox runat="server" ID="address_txt" Rows="5" TextMode="MultiLine"></asp:TextBox>
  <br />
  <br />

  

  <asp:UpdatePanel runat="server" ID="update_panel" UpdateMode="Always">
    <ContentTemplate>
      <asp:Button runat="server" ID="add_btn" Text="Add Contact" OnClick="add_btn_Click" />
      <br />
      <br />
      <br />
      <br />
      <asp:Panel runat="server" ID="success_panel" Visible="false">
        <asp:Label runat="server" ID="success_lbl" Font-Size="X-Large" ForeColor="Green">Contact was added successfully!!!</asp:Label>
      </asp:Panel>
    </ContentTemplate>
  </asp:UpdatePanel>
</asp:Content>
