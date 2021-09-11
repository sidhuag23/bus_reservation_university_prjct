﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminSheduling.aspx.cs" Inherits="Bus_Reservation_System.AdminSheduling" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="width:90% ;align-items:end">
        <br />
        <asp:Button ID="ButtonAdd" CssClass="float-right" runat="server" Text="Add" OnClick="ButtonAdd_Click" /></div>
    <br />
    <asp:GridView ID="GridViewShedule" runat="server"  AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Height="104px" Width="90%" >
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:BoundField DataField="BusNumber" HeaderText="Bus No" />
            <asp:BoundField DataField="BusFrom" HeaderText=" From" />
            <asp:BoundField DataField="BusTo" HeaderText="To" />
            <asp:BoundField DataField="DepatureTime" HeaderText="Depature" />
            <asp:BoundField DataField="ArrivalTime" HeaderText="Arrival" />
            <asp:BoundField DataField="Rate" HeaderText="Rate" />
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:Button ID="ButtonEdit" runat="server" Text="Edit" CommandArgument='<%# Eval("Id") %>' OnClick="ButtonEdit_Click"  />
                    <asp:Button ID="ButtonDelete" runat="server" Text="Delete" CommandArgument='<%# Eval("Id") %>' OnClick="ButtonDelete_Click"  />
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
