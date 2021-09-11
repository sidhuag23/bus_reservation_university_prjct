<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="UserBookingStatus.aspx.cs" Inherits="Bus_Reservation_System.UserBookingStatus" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
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
            /*background: url('../Photos/pexels-lê-minh-977213.jpg') no-repeat;*/
            width:100%;
            height:95vh;
            background-size:100% 170%
        }
    </style>
    <section class="container-fluid bg">
        <section class="row justify-content-center">
            <section class="col-12 col-sm-6 col-md-6 form-container">
                
                    <div class="form-group">
                        <asp:Label  ID="LabelBookingId" runat="server" Text="Booking ID"></asp:Label>
                        <asp:TextBox  CssClass="form-control"   ID="BookingId" runat="server"></asp:TextBox>
                        <asp:Button ID="ButtonSearch" BackColor="#dcad10" CssClass="btn btn-block" runat="server" Text="Get" OnClick="ButtonSearch_Click" />
                    </div>
                
            </section>
        </section>
    </section>
</asp:Content>
