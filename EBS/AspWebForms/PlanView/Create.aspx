﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Create.aspx.cs" Inherits="AspWebForms.PlanView.Create" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Create Insurance</title>
    <link rel="stylesheet" type="text/css" href="StyleSheet.less"/>
    <meta charset="utf-8"/>
    <meta http-equiv="X-UA-Compatible" content="IE=edge"/>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <meta name="description" content=""/>
    <meta name="author" content=""/>

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


<form id="form1" runat="server">
    <asp:ScriptManager id="xyz" runat="server"></asp:ScriptManager>

    <div>
        <h1 class="title1">Add New Plan</h1>
        <table class="table-hover">


            <tr>
                <td>
                    <label>Name<sup style="color: red">*</sup></label>
                </td>
                <td>
                    <asp:TextBox ID="txtPlanName" Font-Size="Medium" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rqvPlanName"
                                                runat="server"
                                                ControlToValidate="txtPlanName"
                                                ErrorMessage="Name is Required"
                                                SetFocusOnError="true"
                                                BackColor="yellow">

                    </asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="regNamePlan" runat="server"
                                                    ControlToValidate="txtPlanName"
                                                    ValidationExpression="^[a-zA-Z'.]{1,25}$"
                                                    Text="Enter a valid name" SetFocusOnError="true"
                                                    BackColor="yellow"/>
                </td>
            </tr>

            <tr>
                <td>
                    <label>Description <sup style="color: red">*</sup></label>
                </td>
                <td>
                    <asp:TextBox ID="txtDescr" Font-Size="Medium" runat="server"></asp:TextBox>
                      <asp:RequiredFieldValidator ID="rqvDescr"
                                                runat="server"
                                                ControlToValidate="txtDescr"
                                                ErrorMessage="Description is Required"
                                                SetFocusOnError="true"
                                                BackColor="yellow">
                           </asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegNameDescr" runat="server"
                                                    ControlToValidate="txtDescr"
                                                    ValidationExpression="^[a-zA-Z''-'\s]{1,25}$"
                                                    Text="Enter a valid Description" SetFocusOnError="true"
                                                    BackColor="yellow"/>
                </td>
            </tr>

            <tr>
                <td>
                    <label>Detuctible Value<sup style="color: red">*</sup></label>&nbsp;
                </td>
                <td>
                    <asp:TextBox ID="txtDetuc" Font-Size="Medium" runat="server"></asp:TextBox>
                         <asp:RequiredFieldValidator ID="rqvDetuc"
                                                runat="server"
                                                ControlToValidate="txtDetuc"
                                                ErrorMessage="Detuctible Value is Required"
                                                SetFocusOnError="true"
                                                BackColor="yellow">
                           </asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegNameDetuc" runat="server"
                                                    ControlToValidate="txtDetuc"
                                                    ValidationExpression="^\d+(\.\d\d)?$"
                                                    Text="Enter a positive number" SetFocusOnError="true"
                                                    BackColor="yellow"/>
                </td>
            </tr>

            <tr>
                <td>

                    <asp:Button ID="btnCreate" runat="server" Text="Create" OnClick="btnCreate_Click" CssClass="btn btn-primary"/>
                </td>
                <td>
                    <h6 style="color: red">
                        <asp:Label ID="lblResult" runat="server"></asp:Label>
                    </h6>
                </td>
            </tr>

        </table>


    </div>

    <br/> <br/> <br/> <br/> <br/> <br/> <br/> <br/> <br/>
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