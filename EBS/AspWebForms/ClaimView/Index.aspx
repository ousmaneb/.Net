<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="AspWebForms.ClaimView.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title> ClaimView </title>
  <link rel="stylesheet" type="text/css" href="../PlanView/StyleSheet.less"/>
  <link href="../Content/bootstrap.min.css" rel="stylesheet"/>
  <style>
    .HellowWorldPopup {
      background: white;
      min-height: 150px;
      min-width: 200px;
    }
  </style>

</head>
<body>
<form id="form1" runat="server" class="form-group">
  <asp:ScriptManager ID="scrpt" runat="server"></asp:ScriptManager>
  <div>
      <h1 class="title1">Claims' List</h1>
  <div>
  
    <asp:UpdatePanel ID="udp2" runat="server" UpdateMode="Conditional">
      <ContentTemplate>
        <asp:GridView ID="GridView1" runat="server"
                      AutoGenerateColumns="false" CssClass="table table-hover"
                      DataKeyNames="ClaimId">
          <Columns>
            <asp:BoundField DataField="ClaimId" HeaderText="Claim Id" Visible="False"/>
            <asp:BoundField DataField="ClaimDate" HeaderText="Claim Date"/>
            <asp:BoundField DataField="DueDate" HeaderText="Due Date"/>
            <asp:BoundField DataField="ClaimAmount" HeaderText="Claim Amount"/>


            <asp:TemplateField HeaderText="First Name">
              <ItemTemplate>
                <asp:Label ID="lblName" runat="server" Text='<%# Eval("Member.FirstName") %>'></asp:Label>
              </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Last Name">
              <ItemTemplate>
                <asp:Label ID="lblName" runat="server" Text='<%# Eval("Member.LastName") %>'></asp:Label>
              </ItemTemplate>
            </asp:TemplateField>
          </Columns>
        </asp:GridView>
      </ContentTemplate>
    </asp:UpdatePanel>
  </div>

 
  <asp:UpdatePanel ID="udp" runat="server" UpdateMode="Conditional">
    <ContentTemplate>
       <h1 class="title1">Claims' List</h1>
      <asp:GridView ID="gvClaim" runat="server"
                    AutoGenerateColumns="false"
                    CssClass="table table-hover"
        OnRowCommand="gvClaim_RowCommand"
                    DataKeyNames="ClaimId">
        <Columns>
          <asp:BoundField DataField="ClaimId" HeaderText="Claim Id" Visible="False"/>
          <asp:BoundField DataField="ClaimDate" HeaderText="Claim Date"/>
          <asp:BoundField DataField="DueDate" HeaderText="Due Date"/>
          <asp:BoundField DataField="ClaimAmount" HeaderText="Claim Amount"/>


          <asp:TemplateField HeaderText="First Name">
            <ItemTemplate>
              <asp:Label ID="lblName" runat="server" Text='<%# Eval("Member.FirstName") %>'></asp:Label>
            </ItemTemplate>
          </asp:TemplateField>

          <asp:TemplateField HeaderText="Last Name">
            <ItemTemplate>
              <asp:Label ID="lblName" runat="server" Text='<%# Eval("Member.LastName") %>'></asp:Label>
            </ItemTemplate>
          </asp:TemplateField>

          <asp:TemplateField HeaderText="Action">
            <ItemTemplate>
              <%--                            Pass Command argumnet to pass the row index so that we know which row we are working with--%>
              <asp:Button ID="btnEdit" runat="server" Text="Edit" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" CommandName="EditRow" CssClass="btn btn-primary"/>
              <asp:Button ID="btnDelte" runat="server" Text="Delete" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" CommandName="DeleteRow" CssClass="btn btn-primary"/>

            </ItemTemplate>

          </asp:TemplateField>


        </Columns>
      </asp:GridView>


      <asp:Label ID="lbl" runat="server"></asp:Label>
      <ajaxToolkit:ModalPopupExtender ID="ModalPopupExtender1"
                                      runat="server"
                                      TargetControlID="lbl"
                                      PopupControlID="Panel1"
                                      PopupDragHandleControlID="PopupHeader"
                                      Drag="true"
                                      BackgroundCssClass="bg-primary">
      </ajaxToolkit:ModalPopupExtender>
      <div>
        <asp:Panel ID="Panel1" Style="display: none" runat="server">

          <div class="modal-dialog modal-sm">
            <div class="modal-header" id="PopupHeader">Update Claim</div>
            <div class="modal-body">
              <div class="modal-content">
                <table class="table table-hover">
                  <tr>
                    <td>
                      <label class="text-uppercase">Claim Date </label> &nbsp;
                    </td>
                    <td>
                      <asp:TextBox ID="txtClaimDate" runat="server"/>

                      <ajaxToolkit:CalendarExtender ID="Calendar1" runat="server" TargetControlID="txtClaimDate" Format="MM/dd/yyyy">
                      </ajaxToolkit:CalendarExtender>
                    </td>
                  </tr>

                  <tr>
                    <td>
                      <label class="text-uppercase">Due Date </label> &nbsp;
                    </td>
                    <td>
                      <asp:TextBox ID="txtDueDate" runat="server"/>

                      <ajaxToolkit:CalendarExtender ID="Calendar2" runat="server" TargetControlID="txtDueDate" Format="MM/dd/yyyy">
                      </ajaxToolkit:CalendarExtender>
                    </td>
                  </tr>


                  <tr>
                    <td>
                      <label class="text-uppercase">Claim Amount </label> &nbsp;
                    </td>
                    <td>
                      <asp:TextBox ID="txtAmount" runat="server"></asp:TextBox>
                     
                    </td>
                  </tr>

                  <tr>
                    <td>
                      <label class="text-uppercase">Member:</label>
                    </td>
                    <td>
                      <asp:DropDownList ID="ddlMember" runat="server" CssClass="form-control"></asp:DropDownList>
                    </td>
                  </tr>

                </table>
              </div>


            </div>
            <div class="modal-footer">
              <asp:Button ID="btnOkay" runat="server" OnClick="btnOkay_Click" Text="Update"/>
              <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" Text="Cancel"/>
            </div>
          </div>

        </asp:Panel>
      </div>
      <%--  todo Add one  ModelPopup for Delete
                        Add on Panel for Delete--%>

    </ContentTemplate>
  </asp:UpdatePanel>

  <a href="Create.aspx">../Create.aspx</a><br/>
  <a href="../MemberView/Index.aspx">../MemberView/Index.aspx</a><br/>
  <a href="../MemberView/Insert.aspx">../MemberView/Insert.aspx</a><br/>
  <a href="../PlanView/Create.aspx">../PlanView/Create.aspx</a><br/>
  <a href="../PlanView/Index.aspx">../PlanView/Index.aspx</a><br/>
    </div>
</form>
</body>
</html>