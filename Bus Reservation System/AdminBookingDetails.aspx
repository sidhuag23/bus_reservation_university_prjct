<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminBookingDetails.aspx.cs" Inherits="Bus_Reservation_System.AdminBookingDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  
    <br />
    <asp:GridView ID="GridViewBookingDetails" runat="server"  AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Height="104px" Width="90%" >
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:BoundField DataField="UserId" HeaderText="User Id" />
            <asp:BoundField DataField="BusId" HeaderText=" Bus Id" />
            <asp:BoundField DataField="SeatNumber" HeaderText="Seat Number" />
            <asp:BoundField DataField="Name" HeaderText="Name" />
            <asp:BoundField DataField="PhoneNumber" HeaderText=" Phone Number" />
            <asp:BoundField DataField="Mail" HeaderText="Mail" />
            <asp:BoundField DataField="CreatedDate" HeaderText="Date" />
            <asp:BoundField DataField="IsCancelled" HeaderText="Cancelled" />
            <asp:TemplateField>
                <ItemTemplate>
                    
                    <asp:Button ID="ButtonCancel" runat="server" Text="Cancel" CommandArgument='<%# Eval("Id") %>' OnClick="ButtonCancel_Click"   />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#E9E7E2" />
        <SortedAscendingHeaderStyle BackColor="#506C8C" />
        <SortedDescendingCellStyle BackColor="#FFFDF8" />
        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
    </asp:GridView>
</asp:Content>
