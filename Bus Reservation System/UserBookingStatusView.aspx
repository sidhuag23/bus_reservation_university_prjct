<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="UserBookingStatusView.aspx.cs" Inherits="Bus_Reservation_System.UserBookingStatusView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <table style="width:80%">
            <tr>
                <td></td>

            </tr>
            <tr>
                <td>
                    Booking Id
                </td>
                <td>
                    <asp:Label ID="LabelBkId" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    Name
                </td>
                <td>
                    <asp:Label ID="LabelName" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    Seat Number
                </td>
                <td>
                    <asp:Label ID="LabelStNo" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    Route
                </td>
                <td>
                    <asp:Label ID="LabelFrom" runat="server" Text=""></asp:Label>&nbsp; To&nbsp; <asp:Label ID="LabelTo" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    Time
                </td>
                <td>
                    <asp:Label ID="LabelDTime" runat="server" Text=""></asp:Label>&nbsp; To&nbsp; <asp:Label ID="LabelATime" runat="server" Text=""></asp:Label>
                </td>
            </tr>
             <tr>
                <td>
                    Rate
                </td>
                <td>
                    <asp:Label ID="LabelRate" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td>

                </td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:Button ID="ButtonPrint" runat="server" Text="Print" />
                     <asp:Button ID="ButtonCancelBooking" runat="server" Text="CancelBooking" OnClick="ButtonCancelBooking_Click" />
                </td>
            </tr>

        </table>
    </div>
</asp:Content>
