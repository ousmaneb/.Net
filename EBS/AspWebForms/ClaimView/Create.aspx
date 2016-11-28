<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Create.aspx.cs" Inherits="AspWebForms.ClaimView.Create" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <meta name="description" content="" />
    <meta name="author" content="" />
    <title>Create Claim</title>
       <link rel="shortcut icon" href="../img/ob.png" />
  <link href="../Content/bootstrap.min.css" rel="stylesheet"/>
  <link rel="stylesheet" type="text/css" href="../PlanView/StyleSheet.less"/>
  <script src="../scripts/bootstrap-datepicker.js"></script>
  

    
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
      
    


<form id="form1" runat="server">
  <asp:ScriptManager id="xyz" runat="server"></asp:ScriptManager>
  <div>
    <h1 class="title1">Add New Claim</h1>
    <table class="table-hover">
      
      
          <tr>
        <td>
          <label class="text-uppercase">MemberId<sup style="color: red">*</sup> </label> &nbsp;
        </td>
        <td>
          <asp:DropDownList ID="ddlClaim" runat="server" Width="184px"></asp:DropDownList>
        </td>
      </tr>
      

      <tr>
        <td>
          <label class="text-uppercase">Claim Date<sup style="color: red">*</sup> </label> &nbsp;
        </td>
        <td>
          <asp:TextBox ID="txtClaimDate" runat="server"/>
         
          <ajaxToolkit:CalendarExtender ID="Calendar1" runat="server" TargetControlID="txtClaimDate"   Format="MM/dd/yyyy">
          </ajaxToolkit:CalendarExtender>
                                    <asp:RequiredFieldValidator ID="rqvClaimDate"
                                                runat="server"
                                                ControlToValidate="txtClaimDate"
                                                ErrorMessage="Claim Date is Required"
                                                SetFocusOnError="true"
                                                BackColor="yellow">

                    </asp:RequiredFieldValidator>
        </td>
      </tr>
      
            <tr>
        <td>
          <label class="text-uppercase">Due Date <sup style="color: red">*</sup></label> &nbsp;
        </td>
        <td>
          <asp:TextBox ID="txtDueDate" runat="server"/>
         
          <ajaxToolkit:CalendarExtender ID="Calendar2" runat="server" TargetControlID="txtDueDate"   Format="MM/dd/yyyy">
          </ajaxToolkit:CalendarExtender>
                           <asp:RequiredFieldValidator ID="rqvDueDate"
                                                runat="server"
                                                ControlToValidate="txtDueDate"
                                                ErrorMessage="Due Date is Required"
                                                SetFocusOnError="true"
                                                BackColor="yellow">

                    </asp:RequiredFieldValidator>
        </td>
      </tr>
      
      


      <tr>
        <td>
          <label class="text-uppercase">Claim Amount <sup style="color: red">*</sup></label> &nbsp;
        </td>
        <td>
          <asp:TextBox ID="txtAmount" runat="server"></asp:TextBox>
                           <asp:RequiredFieldValidator ID="RequiredFieldValidator1"
                                                runat="server"
                                                ControlToValidate="txtAmount"
                                                ErrorMessage="Amount is Required"
                                                SetFocusOnError="true"
                                                BackColor="yellow">

                    </asp:RequiredFieldValidator>
                   <asp:RegularExpressionValidator ID="RegNameClaim" runat="server"
                                          ControlToValidate="txtAmount"
                                          ValidationExpression="^\d+(\.\d\d)?$"
                                          Text="Enter a positive number" SetFocusOnError="true"
                                      BackColor="yellow"/>
        </td>
      </tr>

      <tr>
        <td>
          <asp:Button ID="btnCreate" runat="server" CssClass="btn btn-primary" OnClick="btnCreate_Click" Text="Create"/>
        </td>
         <td>
          <h6 style="color: red">
            <asp:Label ID="lblResult" runat="server"></asp:Label>
          </h6>
        </td>
      </tr>
      
    
    </table>


      
      
    
  </div>
  

</form>
<br/>   <br/>   <br/>   <br/>   <br/> <br/>   <br/>  <br/>

   <footer >
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
