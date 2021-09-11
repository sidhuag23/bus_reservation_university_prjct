<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="UserHome.aspx.cs" Inherits="Bus_Reservation_System.UserHome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/bootstrap.js"></script>
    <script src="Scripts/jquery-3.4.1.js"></script>
    <script src="Scripts/jquery-3.4.1.min.js"></script>
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        .form-container{
            position:absolute;
            top:20vh;
            background-color:black;
            color:white;
            padding:30px;
            border-radius:10px;
            box-shadow:0px 0px 20px 0px #ffffff;
            opacity:0.8;
            width:50%;
            left:30%;
        }
        .bg {
            background: url('../Photos/pexels-lê-minh-977213.jpg') no-repeat;
            width:100%;
            height:95vh;
            background-size:100% 170%
        }
    </style>
    <section class="container-fluid bg">
        <section class="row justify-content-center">
            <section class="col-12 col-sm-6 col-md-6 form-container">
                
                    <div class="form-group">
                        <asp:Label  ID="LabelFrom" runat="server" Text="From"></asp:Label>
                            <asp:DropDownList ID="From" DataTextField="CityName" DataValueField="CityName" CssClass="form-control" runat="server"> </asp:DropDownList> 
                        <asp:Label ID="LabelTo" runat="server" Text="To"></asp:Label>
                        <asp:DropDownList ID="To" DataTextField="CityName" DataValueField="CityName" CssClass="form-control" runat="server"></asp:DropDownList>
                        <asp:Label ID="LabelDate" runat="server" Text="Date"></asp:Label>
                        <asp:TextBox  CssClass="form-control"  TextMode="Date" ID="Date" runat="server"></asp:TextBox>
                        <asp:Button ID="ButtonSearch" BackColor="#dcad10" CssClass="btn btn-block" runat="server" Text="Search" OnClick="ButtonSearch_Click" />
                    </div>
                
            </section>
        </section>
    </section>
</asp:Content>
