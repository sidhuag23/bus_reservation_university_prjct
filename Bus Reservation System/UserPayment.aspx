<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="UserPayment.aspx.cs" Inherits="Bus_Reservation_System.UserPayment" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script>
        function printpage() {
            var getPanel = document.getElementById("<%=Panel1.ClientID%>");
            var MainWindow = window.open('', '', 'height=500,width=800');
            MainWindow.document.write('<html><head><title>Booking Details</title>');
            MainWindow.document.write('</head><body>');
            MainWindow.document.write(getPanel.innerHTML);
            MainWindow.document.write('</body></html>');
            MainWindow.document.close();
            setTimeout(function () {
                MainWindow.print();
            }, 1000);
            return false;
        }
    </script>
    <div class="form-container">
   
                    <div class="form-group col-md-12">
                        <h3>Payment</h3>
                        <asp:Label ID="LabelCardNumber" runat="server" Text="Card Number"></asp:Label>
                        <asp:TextBox ID="TextBoxCardNumber" CssClass="form-control" runat="server"></asp:TextBox>
                        <div class="col-md-6"><asp:Label ID="LabelExpMonth" runat="server" Text="Exp Month"></asp:Label>
                        <asp:TextBox ID="TextBoxExpMonth" CssClass="form-control" runat="server"></asp:TextBox></div>
                        <div class="col-md-6"><asp:Label ID="LabelExpYear" runat="server" Text="Exp Year"></asp:Label>
                        <asp:TextBox ID="TextBoxExpYear" CssClass="form-control" runat="server"></asp:TextBox></div>
                        <asp:Label ID="LabelCVV" runat="server" Text="CVV"></asp:Label>
                        <asp:TextBox ID="TextBoxCVV" CssClass="form-control" runat="server"></asp:TextBox>
                        <asp:Label ID="LabelName" runat="server" Text="Holder Name"></asp:Label>
                        <asp:TextBox ID="TextBoxName" CssClass="form-control" runat="server"></asp:TextBox><br />
                        <asp:Button ID="ButtonPay" CssClass="btn btn-danger btn-block" runat="server" Text="Pay" OnClick="ButtonPay_Click"  />
                    </div>
        
        <asp:Panel ID="Panel1" runat="server" Visible="false" >
        <h3>
            <asp:Label ID="LabelFrom" runat="server" Text=""></asp:Label>- To -<asp:Label ID="LabelTo" runat="server" Text=""></asp:Label></h3><hr />
        <table>
            <tr><td>Name</td><td>:<asp:Label ID="LabelName2" runat="server" Text=""></asp:Label></td></tr>
            <tr><td>Bus Id</td><td>:<asp:Label ID="LabelBusId" runat="server" Text=""></asp:Label></td></tr>
            <tr><td>From</td><td>:<asp:Label ID="LabelFrom2" runat="server" Text=""></asp:Label></td></tr>
            <tr><td></td><td>:<asp:Label ID="LabelDTime" runat="server" Text=""></asp:Label></td></tr>
            <tr><td>To</td><td>:<asp:Label ID="LabelTo2" runat="server" Text=""></asp:Label></td></tr>
            <tr><td></td><td>:<asp:Label ID="LabelATime" runat="server" Text=""></asp:Label></td></tr>
            <tr><td>Seat Number</td><td>:<asp:Label ID="LabelStNo" runat="server" Text=""></asp:Label></td></tr>
            <tr><td>Ticket Number</td><td>:<asp:Label ID="LabelTicketNo" runat="server" Text=""></asp:Label></td></tr>
            <tr><td>Amount</td><td>:<asp:Label ID="LabelAmount" runat="server" Text=""></asp:Label></td></tr>
            <tr></tr>
            <tr><td colspan="2"><h3>Thank You Visit Again</h3></td></tr>
            <tr></tr>
            
        </table>
            </asp:Panel>
            </div>
                
</asp:Content>
