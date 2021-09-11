<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminShedulingAddorEdit.aspx.cs" Inherits="Bus_Reservation_System.AdminShedulingAddorEdit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="form-group" style="width:80%">
    <h3>
        <asp:Label ID="LabelAddorEdit" runat="server" Text=""></asp:Label>_Bus Deatils</h3>
    <hr />
    <div>
        <asp:Label ID="LabelBusNumber" runat="server" Text=" Bus Number"></asp:Label>
        <asp:DropDownList ID="DropDownListBusNumber" DataTextField="BusNumber" DataValueField="BusNumber" CssClass="form-control" runat="server"></asp:DropDownList>
        <asp:Label ID="LabelFrom" runat="server" Text="From"></asp:Label>
        <asp:DropDownList ID="DropDownListFrom" DataTextField="CityName" DataValueField="CityName" CssClass="form-control" runat="server"></asp:DropDownList>
        <asp:Label ID="LabelTo" runat="server" Text="To"></asp:Label>
        <asp:DropDownList ID="DropDownListTo" DataTextField="CityName" DataValueField="CityName" CssClass="form-control" runat="server"></asp:DropDownList>

        <asp:Label ID="LabelDepatureTime" runat="server" Text="Depature Time"></asp:Label>
        <asp:TextBox ID="TextBoxDepatureTime" TextMode="DateTime" CssClass="form-control" runat="server"></asp:TextBox>
        <asp:Label ID="LabelArrivalTime" runat="server" Text="Arrival Time"></asp:Label>
        <asp:TextBox ID="TextBoxArrivalTime" TextMode="DateTime" CssClass="form-control" runat="server"></asp:TextBox>
        <asp:Label ID="LabelRate" runat="server" Text="Rate"></asp:Label>
        <asp:TextBox ID="TextBoxRate" TextMode="Number" CssClass="form-control" runat="server"></asp:TextBox>
        <br />

    </div>
    <div>
        <asp:Button ID="ButtonSave"  CssClass="btn float-right" runat="server" Text="Save" OnClick="ButtonSave_Click" /><asp:Button ID="ButtonCancel" CssClass="btn float-right" runat="server" Text="Cancel" />
    </div>
</div>
</asp:Content>
