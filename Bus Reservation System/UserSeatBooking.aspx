﻿<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="UserSeatBooking.aspx.cs" Inherits="Bus_Reservation_System.UserSeatBooking" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
        <div class="container-fluid justify-content-center">
            <table style="">
                <tr>
                    <td></td>
                    <td><h3>
                        <asp:Label ID="LabelStart" runat="server" Text=""></asp:Label>--<asp:Label ID="LabelEnd" runat="server" Text=""></asp:Label></h3></td>
                </tr>
                <tr>
                    <td style="width:150px"></td>
                    <td style="border:solid">
            <asp:DataList ID="DataList1" RepeatColumns="4" RepeatDirection="Horizontal" runat="server" OnItemCommand="DataList1_ItemCommand">
                <ItemTemplate>
                      <div style="width:90px; align-items:center;"><asp:Button Width="60px" Height="60px" BackColor="WhiteSmoke" CommandName="st" ID="ButtonSeat" runat="server" Text='<%# Eval("Id") %>' /></div>
                   
                </ItemTemplate>
            </asp:DataList>
                        </td>
                    <td style="width:100px"></td>
                    <td style="border:solid;width:600px">
                        <div class="col-md-12 container-fluid justify-content-center ">
                            <div>
                                Boarding & Droping
                            </div>
                            <hr />
                            <div class="row">
                            <div class="col-md-6">
                                <asp:Label ID="LabelFrom" runat="server" Text=""></asp:Label></div>
                            <div class="col-md-6">
                                <asp:Label ID="LabelFromTime" runat="server" Text=""></asp:Label></div>
                                </div>
                            <div class="row">
                            <div class="col-md-6">
                                <asp:Label ID="LabelTo" runat="server" Text=""></asp:Label></div>
                            <div class="col-md-6">
                                <asp:Label ID="LabelToTime" runat="server" Text=""></asp:Label></div>
                                </div>
                             <hr />
                             <div class="row">
                            <div class="col-md-6">Seat Number</div>
                            <div class="col-md-6"><asp:Label ID="LabelSeats" runat="server" Text=""></asp:Label></div>
                                 </div>
                            <hr />
                            <div>Fare Details</div>
                             <div class="row">
                            <div class="col-md-6">Amount</div>
                            <div class="col-md-6">INR-<asp:Label ID="LabelAmount" runat="server" Text=""></asp:Label></div>
                                 </div>
                            <hr />
                            <asp:Button ID="ButtonBook" BackColor="#dcad10" CssClass="btn btn-block" runat="server" Text="Proceed to Book" OnClick="ButtonBook_Click" />
                        </div>
                    </td>
                     <td></td>
                </tr>
            </table>



           
            </div>
       
</asp:Content>
