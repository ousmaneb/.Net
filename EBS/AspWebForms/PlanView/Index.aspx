<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="AspWebForms.PlanView.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">


<head runat="server">
    
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <meta name="description" content="" />
    <meta name="author" content="" />

  <title>Plan View</title>
  <link rel="stylesheet" type="text/css" href="StyleSheet.less"/>

    <link href="../Content/bootstrap.min.css" rel="stylesheet"/>
    
    <!-- Bootstrap Core CSS -->
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />

    <!-- Custom CSS -->
    <link href="../Content/business-casual.css" rel="stylesheet" />

    <!-- Fonts -->
    <link href="https://fonts.googleapis.com/css?family=Open+Sans:300italic,400italic,600italic,700italic,800italic,400,300,600,700,800" rel="stylesheet" type="text/css" />
    <link href="https://fonts.googleapis.com/css?family=Josefin+Slab:100,300,400,600,700,100italic,300italic,400italic,600italic,700italic" rel="stylesheet" type="text/css" />

    <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
        <script src="https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js"></script>
        <script src="https://oss.maxcdn.com/libs/respond.js/1.4.2/respond.min.js"></script>
    <![endif]-->
    <style>
    @import url('StyleSheet.less');

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
    <h1 class="title1">Plans</h1>
            <asp:UpdatePanel ID="udp2" runat="server" UpdateMode="Conditional">
            <ContentTemplate>
     <asp:GridView ID="GridView1" runat="server"
                              AutoGenerateColumns="false"
                               CssClass="floatLeft"
                              DataKeyNames="PlanId" RowStyle-CssClass="rowHover">
        <Columns>
          <asp:BoundField DataField="PlanId" HeaderText="Id" Visible="False"/>
            <asp:TemplateField HeaderText="Plan">
                                <ItemTemplate>
                                    <asp:Label ID="lblName" runat="server" Text='<%# Eval("PlanName")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>

          <asp:BoundField DataField="Descr" HeaderText="Plan Description"/>
          <asp:BoundField DataField="DetuctibleValue" HeaderText="Detectuble Value"/>

        </Columns>
      </asp:GridView>
                     </ContentTemplate>
        </asp:UpdatePanel>
    </td>
 
        <td style="text-align: center" class="t2">     
      
        <asp:UpdatePanel ID="udp" runat="server" UpdateMode="Conditional">
        <ContentTemplate>

            <h1 class="title1">Edit/Delete Plans</h1>
            <asp:GridView ID="gvPlan" runat="server" 
              AutoGenerateColumns="false"
              CssClass="floatRight" 
                          OnRowCommand="gvPlan_RowCommand"
                          DataKeyNames="PlanId" RowStyle-CssClass="rowHover">
                <Columns>
                    <asp:BoundField DataField="PlanId" HeaderText="Plan Id" Visible="False"/>
                         
                    <asp:TemplateField HeaderText="Plan">
                                <ItemTemplate>
                                    <asp:Label ID="lblName" runat="server" Text='<%# Eval("PlanName")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>

                    <asp:BoundField DataField="Descr" HeaderText="Description"/>
                    <asp:BoundField DataField="DetuctibleValue" HeaderText="Detuctible Value"/>
         
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
                        <div class="modal-header" id="PopupHeader">Update Plan</div>
                        <div class="modal-body">
                            <div class="modal-content">
                                <table class="table table-hover">
                                  <tr>
                                        <td>
                                            <label class="text-uppercase">Plan:</label>
                                        </td>
                                        <td>
                                            <asp:DropDownList ID="ddlPlan" runat="server" CssClass="form-control"></asp:DropDownList>
                                        </td>
                                    </tr>
                                    

                                    <tr>
                                        <td>
                                            <label class="text-uppercase">Description:</label>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="descr" runat="server" CssClass="form-control"></asp:TextBox>
                                        </td>
                                    </tr>
                                    

                                    <tr>
                                        <td>
                                            <label class="text-uppercase">Detuctible Value:</label>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="dectVal" runat="server" CssClass="form-control"></asp:TextBox>
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
      </td>
      </tr>
    </table>
            
  </div>
  
  
  
  

    <div>
        
        &nbsp;
      <asp:TextBox ID="txtsearch" runat="server"></asp:TextBox>
      <asp:Button ID="btnSearch" runat="server" OnClick="btnSearch_Click" Text="Search"/>
    </div>
</form>
  
  
  <footer>
    <div class="container">
        <div class="row">
            <div class="col-lg-12 text-center">
                <p style="color: blue"><img src="../img/ob.png" width="40" height="40" />Copyright &copy; DK 2016</p>
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