<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="AspWebForms.MemberView.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">


<head runat="server">
    <title>MemberView</title>
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
        <h1 class="title1">INSURANCE WEB APP: Members' Summary</h1>

        <div>
            <asp:UpdatePanel ID="udp2" runat="server" UpdateMode="Conditional">
                <ContentTemplate>
                    <asp:GridView ID="GridView1" runat="server"
                                  AutoGenerateColumns="false"
                                  CssClass="table table-hover"
                                  DataKeyNames="MemberId">
                        <Columns>
                            <asp:BoundField DataField="MemberId" HeaderText="Member Id" Visible="False"/>
                            <asp:BoundField DataField="FirstName" HeaderText="First Name"/>
                            <asp:BoundField DataField="LastName" HeaderText="Last Name"/>
                            <asp:BoundField DataField="DOB" HeaderText="Date Of Birth"/>
                            <asp:BoundField DataField="Gender" HeaderText="Gender"/>
                            <asp:BoundField DataField="UserName" HeaderText="User Name"/>

                            <asp:TemplateField HeaderText="Plan">
                                <ItemTemplate>
                                    <asp:Label ID="lblName" runat="server" Text='<%# Eval("Plan.PlanName") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>


                        </Columns>
                    </asp:GridView>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>


        <asp:UpdatePanel ID="udp" runat="server" UpdateMode="Conditional">
            <ContentTemplate>

                <h1 class="title1">Members' List</h1>
                <asp:GridView ID="gvMember" runat="server" AutoGenerateColumns="false"
                              CssClass="table table-hover"
                              OnRowCommand="gvMember_RowCommand"
                              DataKeyNames="MemberId">
                    <Columns>
                        <asp:BoundField DataField="MemberId" HeaderText="Member Id" Visible="False"/>
                        <asp:BoundField DataField="FirstName" HeaderText="First Name"/>
                        <asp:BoundField DataField="LastName" HeaderText="Last Name"/>
                        <asp:BoundField DataField="DOB" HeaderText="Date Of Birth"/>
                        <asp:BoundField DataField="Gender" HeaderText="Gender"/>
                        <asp:BoundField DataField="UserName" HeaderText="User Name"/>

                        <asp:TemplateField HeaderText="Plan Name">
                            <ItemTemplate>
                                <asp:Label id="lblName" runat="server" Text='<%# Eval("Plan.PlanName") %>'></asp:Label>
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
                            <div class="modal-header" id="PopupHeader">Update Member</div>
                            <div class="modal-body">
                                <div class="modal-content">
                                    <table class="table table-hover">
                                        <tr>
                                            <td>
                                                <label class="text-uppercase">First Name:</label>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="firstname" runat="server" CssClass="form-control"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <label class="text-uppercase">Last Name:</label>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="lastname" runat="server" CssClass="form-control"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <label class="text-uppercase">Date Of Birth:</label>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="dob" runat="server" CssClass="form-control"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <label class="text-uppercase">Gender:</label>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="gender" runat="server" CssClass="form-control"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <label class="text-uppercase">UserName:</label>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="username" runat="server" CssClass="form-control"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <label class="text-uppercase">Plan:</label>
                                            </td>
                                            <td>
                                                <asp:DropDownList ID="ddlPlan" runat="server" CssClass="form-control"></asp:DropDownList>
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


        <a href="../ClaimView/Create.aspx">../ClaimView/Create.aspx</a><br/>
        <a href="../ClaimView/Index.aspx">../ClaimView/Index.aspx</a><br/>
        <a href="Insert.aspx">../Insert.aspx</a><br/>
        <a href="../PlanView/Create.aspx">../PlanView/Create.aspx</a><br/>
        <a href="../PlanView/Index.aspx">../PlanView/Index.aspx</a>

    </div>
</form>
</body>


</html>