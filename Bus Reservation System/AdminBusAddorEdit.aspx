<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminBusAddorEdit.aspx.cs" Inherits="Bus_Reservation_System.AdminBusAddorEdit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="form-group" style="width:80%">
    <h3>
        <asp:Label ID="LabelAddorEdit" runat="server" Text=""></asp:Label>_Bus Deatils</h3>
    <hr />
    <div>
        <asp:Label ID="LabelBusNumber" runat="server" Text="Bus Number"></asp:Label>
        <asp:TextBox ID="TextBoxBusNumber" CssClass="form-control" runat="server" required></asp:TextBox>
        <asp:Label ID="LabelBusName" runat="server" Text="Bus Name"></asp:Label>
        <asp:TextBox ID="TextBoxBusName" CssClass="form-control" runat="server" required></asp:TextBox>
        <asp:Label ID="LabelType" runat="server" Text="Bus Type"></asp:Label>
        <asp:TextBox ID="TextBoxType" CssClass="form-control" runat="server" required></asp:TextBox>
        <br />

    </div>
    <div>
        <asp:Button ID="ButtonSave"  CssClass="btn float-right" runat="server" Text="Save" OnClick="ButtonSave_Click" /><asp:Button ID="ButtonCancel" CssClass="btn float-right" runat="server" Text="Cancel" />
    </div>
</div>
</asp:Content>
