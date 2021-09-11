<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminHome.aspx.cs" Inherits="Bus_Reservation_System.AdminHome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

  
        <table>
            <tr>
                <td style="height:100px;"></td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button1" Width="200px" Height="200px" runat="server" Text="customers" OnClick="Button1_Click" />
                </td>
                <td style="width:100px"></td>
                <td>
                    <asp:Button ID="Button2" Width="200px" Height="200px" runat="server" Text="buses" OnClick="Button2_Click" />
                </td>
                <td style="width:100px"></td>
                <td>
                    <asp:Button ID="Button3" Width="200px" Height="200px" runat="server" Text="scheduling" OnClick="Button3_Click" />

                </td>
                <td style="width:100px"></td>
             <!--   <td>
                    <asp:Button ID="Button4" Width="200px" Height="200px" runat="server" Text="Button4" />
                </td> -->
            </tr> 
        </table>
        

</asp:Content>
