<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="AspWebForms.ClaimView.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <meta charset="utf-8"/>
  <meta http-equiv="X-UA-Compatible" content="IE=edge"/>
  <meta name="viewport" content="width=device-width, initial-scale=1"/>
  <meta name="description" content=""/>
  <meta name="author" content=""/>
  <title> ClaimView </title>
       <link rel="shortcut icon" href="../img/ob.png" />
  <link rel="stylesheet" type="text/css" href="../PlanView/StyleSheet.less"/>
  <link href="../Content/bootstrap.min.css" rel="stylesheet"/>


  <!-- Bootstrap Core CSS -->
  <link href="../Content/bootstrap.min.css" rel="stylesheet"/>

  <!-- Custom CSS -->
  <link href="../Content/business-casual.css" rel="stylesheet"/>

  <!-- Fonts -->
  <link href="https://fonts.googleapis.com/css?family=Open+Sans:300italic,400italic,600italic,700italic,800italic,400,300,600,700,800" rel="stylesheet" type="text/css"/>
  <link href="https://fonts.googleapis.com/css?family=Josefin+Slab:100,300,400,600,700,100italic,300italic,400italic,600italic,700italic" rel="stylesheet" type="text/css"/>

  <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
  <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
  <!--[if lt IE 9]>
    <script src="https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js"></script>
    <script src="https://oss.maxcdn.com/libs/respond.js/1.4.2/respond.min.js"></script>
  <![endif]-->


  <style>
      
    @import url('../PlanView/StyleSheet.less');


  </style>

</head>
<body>
<div class="brand">DK Insurance</div>
<div class="address-bar">1 East 96th street | New York, NY 10026 | 123.456.7890</div>

<!-- Navigation -->
<nav class="navbar navbar-default" role="navigation">
  <div class="container">
    <!-- Brand and toggle get grouped for better mobile display -->

    <!-- Collect the nav links, forms, and other content for toggling -->
    <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
      <ul class="nav navbar-nav">

        <li>


          <button onclick="location.href = '../Static%20Pages/index.html'" type="button" class="dropbtn">
            HOME
          </button>


        </li>
        <li>
          <div class="dropdown">
            <button class="dropbtn">PLAN VIEW</button>
            <div class="dropdown-content">
              <a href="../PlanView/Index.aspx">Edit/Delete Plan</a>
              <a href="../PlanView/Create.aspx">Create Plan</a>
            </div>
          </div>

        </li>

        <li>
          <div class="dropdown">
            <button class="dropbtn">MEMBER VIEW</button>
            <div class="dropdown-content">
              <a href="../MemberView/Index.aspx">Edit/Delete Member</a>
              <a href="../MemberView/Insert.aspx">Create Member</a>
            </div>
          </div>
        </li>

        <li>
          <div class="dropdown">
            <button class="dropbtn">CLAIM VIEW</button>
            <div class="dropdown-content">
              <a href="../ClaimView/Index.aspx">Edit/Delete Claim</a>
              <a href="../ClaimView/Create.aspx">Create Claim</a>
            </div>
          </div>
        </li>

      </ul>
    </div>
    <!-- /.navbar-collapse -->
  </div>
  <!-- /.container -->
</nav>


<form id="form1" runat="server" class="form-group">
  <asp:ScriptManager ID="scrpt" runat="server"></asp:ScriptManager>
  <div>
    <table>
      <tr>
        <td style="text-align: center" class="t1">
          <h1 class="title1">Claims</h1>


          <asp:UpdatePanel ID="udp2" runat="server" UpdateMode="Conditional">
            <ContentTemplate>
              <asp:GridView ID="GridView1" runat="server"
                            AutoGenerateColumns="false" CssClass="floatLeft"
                            RowStyle-CssClass="rowHover"
                            DataKeyNames="ClaimId">
                <Columns>
                  <asp:BoundField DataField="ClaimId" HeaderText="Claim Id" Visible="False"/>
                  <asp:BoundField DataField="ClaimDate" HeaderText="Claim Date"  HtmlEncode="false" DataFormatString="{0:MM/dd/yyyy}"/>
                  <asp:BoundField DataField="DueDate" HeaderText="Due Date"  HtmlEncode="false" DataFormatString="{0:MM/dd/yyyy}"/>
                  <asp:BoundField DataField="ClaimAmount" HeaderText="Claim Amount"/>


                  <asp:TemplateField HeaderText="First Name">
                    <ItemTemplate>
                      <asp:Label ID="lblFirstName" runat="server" Text='<%# Eval("Member.FirstName") %>'></asp:Label>
                    </ItemTemplate>
                  </asp:TemplateField>

                  <asp:TemplateField HeaderText="Last Name">
                    <ItemTemplate>
                      <asp:Label ID="lblLastName" runat="server" Text='<%# Eval("Member.LastName") %>'></asp:Label>
                    </ItemTemplate>
                  </asp:TemplateField>
                </Columns>
              </asp:GridView>
            </ContentTemplate>
          </asp:UpdatePanel>
        </td>

        <td style="text-align: center" class="t2">


          <asp:UpdatePanel ID="udp" runat="server" UpdateMode="Conditional">
            <ContentTemplate>
              <h1 class="title1">Edit/Delete Claim</h1>
              <asp:GridView ID="gvClaim" runat="server"
                            AutoGenerateColumns="false"
                            CssClass="floatRight"
                            OnRowCommand="gvClaim_RowCommand"
                            RowStyle-CssClass="rowHover"
                            DataKeyNames="ClaimId"
                            >
                <Columns>
                  <asp:BoundField DataField="ClaimId" HeaderText="Claim Id" Visible="False"/>
                  <asp:BoundField DataField="ClaimDate" HeaderText="Claim Date" HtmlEncode="false" DataFormatString="{0:MM/dd/yyyy}"/>
                  <asp:BoundField DataField="DueDate" HeaderText="Due Date" HtmlEncode="false" DataFormatString="{0:MM/dd/yyyy}" />
                  <asp:BoundField DataField="ClaimAmount" HeaderText="Claim Amount"/>


                  <asp:TemplateField HeaderText="First Name">
                    <ItemTemplate>
                      <asp:Label ID="lblFirstName" runat="server" Text='<%# Eval("Member.FirstName") %>'></asp:Label>
                    </ItemTemplate>
                  </asp:TemplateField>

                  <asp:TemplateField HeaderText="Last Name">
                    <ItemTemplate>
                      <asp:Label ID="lblLastName" runat="server" Text='<%# Eval("Member.LastName") %>'></asp:Label>
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
                           <h6 style="color: red">
    <asp:Label ID="Label1" runat="server" EnableViewState="False"></asp:Label>
 </h6>

              <asp:Label ID="lbl" runat="server"></asp:Label>
              <ajaxToolkit:ModalPopupExtender ID="ModalPopupExtender1"
                                              runat="server"
                                              TargetControlID="lbl"
                                              PopupControlID="Panel1"
                                              PopupDragHandleControlID="PopupHeader"
                                              Drag="true">
              </ajaxToolkit:ModalPopupExtender>
              <div>
                <asp:Panel ID="Panel1" runat="server" BackColor="lightgreen" BorderStyle="Solid"

                           BorderWidth="5px" CssClass="panel" align-self="baseline">

                  <div class="modal-dialog modal-sm">
                    <div class="modal-header" id="PopupHeader">Update Claim</div>

                    <table class="table-hover">
                      <tr>
                        <td>
                          <label class="text-uppercase">Claim Date </label>
                        </td>
                        <td>
                          <asp:TextBox ID="txtClaimDate" runat="server" CssClass="form-control"/>

                          <ajaxToolkit:CalendarExtender ID="Calendar1" runat="server" TargetControlID="txtClaimDate" Format="MM/dd/yyyy">
                          </ajaxToolkit:CalendarExtender>
                        </td>
                      </tr>

                      <tr>
                        <td>
                          <label class="text-uppercase">Due Date </label>
                        </td>
                        <td>
                          <asp:TextBox ID="txtDueDate" runat="server" CssClass="form-control"/>

                          <ajaxToolkit:CalendarExtender ID="Calendar2" runat="server" TargetControlID="txtDueDate" Format="MM/dd/yyyy">
                          </ajaxToolkit:CalendarExtender>
                        </td>
                      </tr>


                      <tr>
                        <td>
                          <label class="text-uppercase">Claim Amount </label>
                        </td>
                        <td>
                          <asp:TextBox ID="txtAmount" runat="server" CssClass="form-control"></asp:TextBox>

                        </td>
                      </tr>

                      <tr>
                        <td>
                          <label class="text-uppercase">First Name</label>
                        </td>
                        <td>
                          <asp:DropDownList ID="ddlFirstName" runat="server" CssClass="form-control"></asp:DropDownList>
                        </td>
                      </tr>

                      <tr>
                        <td>
                          <label class="text-uppercase">Last Name</label>
                        </td>
                        <td>
                          <asp:DropDownList ID="ddlLastName" runat="server" CssClass="form-control"></asp:DropDownList>
                        </td>
                      </tr>

                    </table>

                    <div class="modal-footer"  style="text-align:center;">
                      <asp:Button CssClass="bfooter" ID="btnUpdate" runat="server" OnClick="btnUpdate_Click" Text="Update"/>
                      <asp:Button CssClass="bfooter" ID="btnUCancel" runat="server" OnClick="btnUCancel_Click" Text="Cancel"/>
                    </div>
                  </div>

                </asp:Panel>
                 <%--  todo Add one  ModelPopup for Delete
                        Add on Panel for Delete--%>

                    <asp:Label ID="lbl1" runat="server"></asp:Label>
              <ajaxToolkit:ModalPopupExtender ID="ModalPopupExtender2"
                                              runat="server"
                                              TargetControlID="lbl1"
                                              PopupControlID="Panel2"
                                              PopupDragHandleControlID="PopupHeader1"
                                              Drag="true">
              </ajaxToolkit:ModalPopupExtender>
                 <asp:Panel ID="Panel2" runat="server" BackColor="lightgreen" BorderStyle="Solid"

                           BorderWidth="5px" CssClass="panel" align-self="baseline">

                  <div class="modal-dialog modal-sm">
                    <div class="modal-header" id="PopupHeader1">Delete Claim</div>
                     <h6 style="color: red">Do you want to delete this record?</h6>
                    <table class="table-hover">
                      <tr>
                        <td>
                          <label class="text-uppercase">Claim Date </label>
                        </td>
                        <td>
                          <asp:TextBox ID="txtClaimDate1" runat="server" CssClass="form-control"/>

                          <ajaxToolkit:CalendarExtender ID="CalendarExtender1" runat="server" TargetControlID="txtClaimDate" Format="MM/dd/yyyy">
                          </ajaxToolkit:CalendarExtender>
                        </td>
                      </tr>

                      <tr>
                        <td>
                          <label class="text-uppercase">Due Date </label>
                        </td>
                        <td>
                          <asp:TextBox ID="txtDueDate1" runat="server" CssClass="form-control"/>

                          <ajaxToolkit:CalendarExtender ID="CalendarExtender2" runat="server" TargetControlID="txtDueDate" Format="MM/dd/yyyy">
                          </ajaxToolkit:CalendarExtender>
                        </td>
                      </tr>


                      <tr>
                        <td>
                          <label class="text-uppercase">Claim Amount </label>
                        </td>
                        <td>
                          <asp:TextBox ID="txtAmount1" runat="server" CssClass="form-control"></asp:TextBox>

                        </td>
                      </tr>

                      <tr>
                        <td>
                          <label class="text-uppercase">First Name</label>
                        </td>
                        <td>
                          <asp:DropDownList ID="ddlFirstName1" runat="server" CssClass="form-control"></asp:DropDownList>
                        </td>
                      </tr>

                      <tr>
                        <td>
                          <label class="text-uppercase">Last Name</label>
                        </td>
                        <td>
                          <asp:DropDownList ID="ddlLastName1" runat="server" CssClass="form-control"></asp:DropDownList>
                        </td>
                      </tr>

                    </table>

                    <div class="modal-footer"  style="text-align:center;">
                      <asp:Button CssClass="bfooter" ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete"/>
                      <asp:Button CssClass="bfooter" ID="btnDCancel" runat="server" OnClick="btnDCancel_Click" Text="Cancel"/>
                    </div>
                  </div>

                </asp:Panel>
              </div>
             

            </ContentTemplate>
          </asp:UpdatePanel>

        </td>
      </tr>
    </table>
  </div>
</form>

<footer>
  <div class="container">
    <div class="row">
      <div class="col-lg-12 text-center">
        <p style="color: blue">
          <img src="../img/ob.png" width="40" height="40"/>Copyright &copy; DK 2016
        </p>
      </div>
    </div>
  </div>
</footer>


<!-- jQuery -->

<script src="../scripts/jquery.js"></script>
<!-- Bootstrap Core JavaScript -->

<script src="../scripts/bootstrap.min.js"></script>

<!-- Script to Activate the Carousel -->
<script>
  $('.carousel')
    .carousel({
      interval: 5000 //changes the speed
    })
</script>
</body>
</html>