<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Insert.aspx.cs" Inherits="AspWebForms.MemberView.Insert" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
      <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <meta name="description" content="" />
    <meta name="author" content="" />

  <title>Create Member</title>
  <link href="../Content/bootstrap.min.css" rel="stylesheet"/>
  <link rel="stylesheet" type="text/css" href="../PlanView/StyleSheet.less"/>
  <script src="../scripts/bootstrap-datepicker.js"></script>
   <link rel="stylesheet" type="text/css" href="StyleSheet.less"/>
    
    
    <link rel="stylesheet" type="text/css" href="../PlanView/StyleSheet.less"/>
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
    <h1 class="title1">Create New Member</h1>
    <table class="table-hover">

      <tr>
        <td>
          <label class="text-uppercase">First Name:</label>
        </td>
        <td>
          <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
               <asp:RequiredFieldValidator ID="rqvFirstName"
                                      runat="server"
                                      ControlToValidate="txtFirstName"
                                      ErrorMessage="First Name is Required"
                                      SetFocusOnError="true"
                                      BackColor="yellow">

          </asp:RequiredFieldValidator>
           <asp:RegularExpressionValidator ID="regFirstName" runat="server"
                                          ControlToValidate="txtFirstName"
                                          ValidationExpression="^[a-zA-Z'.]{1,10}$"
                                          Text="Enter a valid Name" SetFocusOnError="true"
                                      BackColor="yellow"/>
        </td>
      </tr>

      <tr>
        <td>
          <label class="text-uppercase">Last Name:</label>
        </td>
        <td>
          <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
                     <asp:RegularExpressionValidator ID="RegLastName" runat="server"
                                          ControlToValidate="txtLastName"
                                          ValidationExpression="^[a-zA-Z'.]{1,10}$"
                                          Text="Enter a valid Name" SetFocusOnError="true"
                                      BackColor="yellow"/>
        </td>
      </tr>

      <tr>
        <td>
          <label class="text-uppercase">Date Of Birth:</label>
        </td>
        <td>

          <asp:TextBox ID="txtDateOfBirth" runat="server"/>
         
          <ajaxToolkit:CalendarExtender ID="Calendar1" runat="server" TargetControlID="txtDateOfBirth"   Format="MM/dd/yyyy">
          </ajaxToolkit:CalendarExtender>


        </td>
      </tr>

      <tr>
        <td>
          <label class="text-uppercase">Gender:</label>
        </td>
        <td>
          <asp:TextBox ID="txtGender" runat="server"></asp:TextBox>
          <asp:RegularExpressionValidator ID="RegGender" runat="server"
                                          ControlToValidate="txtGender"
                                          ValidationExpression="^M(ale)?$|^F(emale)?$"
                                          Text="Enter M/F or Male/Female" SetFocusOnError="true"
                                      BackColor="yellow"/>
        </td>
      </tr>

      <tr>
        <td>
          <label class="text-uppercase">User Name:</label>
        </td>
        <td>
          <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
                  <asp:RegularExpressionValidator ID="RegUserName" runat="server"
                                          ControlToValidate="txtUserName"
                                          ValidationExpression="^[A-Za-z][A-Za-z0-9._]{5,14}$"
                                          Text="Enter a valid User Name" SetFocusOnError="true"
                                      BackColor="yellow"/>
        </td>
      </tr>

      <tr>
        <td>
          <label class="text-uppercase">Plan:</label>
        </td>
        <td>
          <asp:DropDownList ID="ddlPlan" runat="server" Width="185px"></asp:DropDownList>
        </td>
      </tr>
      <tr>
        <td>
          <asp:Button ID="btnCreate" runat="server" CssClass="btn btn-primary" OnClick="btnCreate_Click" Text="Create"/>
        </td>
      </tr>
          
      <tr>
        <td>
             <asp:Label ID="lblResult" runat="server"></asp:Label>
        </td>
      </tr>
   

    </table>

  
   
  </div>
 
  


</form>
  <br/>
  <br/>
  <br/>
  <br/>
  <br/>
  <br/>
    <br/>
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