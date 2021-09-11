<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="UserBusDetails.aspx.cs" Inherits="Bus_Reservation_System.UserBusDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
        <div class="container-fluid justify-content-center">
            <div class="form-group">
            <div class="row col-12">
                <div class="col-1"></div>
                <div class="col-3">
                    <asp:Label ID="labelFrom"  runat="server" Text="From"></asp:Label>
                </div>
                <div class="col-3">
                    <asp:Label ID="labelTo"  runat="server" Text="To"></asp:Label>
                </div>
                <div class="col-3">
                    <asp:Label ID="labeldate"  runat="server" Text="Date"></asp:Label>
                </div>
                <div class="col-2"></div>

            </div>
            <div class="row col-12">
                <div class="col-1"></div>
                <div class="col-3">
                    <asp:DropDownList ID="DropDownListFrom" CssClass="form-control" runat="server"></asp:DropDownList>
                </div>
                <div class="col-3">
                    <asp:DropDownList ID="DropDownListTo" CssClass="form-control" runat="server"></asp:DropDownList>
                </div>
                <div class="col-3">
                    <asp:TextBox TextMode="Date" ID="TextBoxDate" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="col-1">
                    <asp:Button ID="ButtonSearch"  runat="server" Text="Search" OnClick="ButtonSearch_Click" /></div>
                <div class="col-1">
                    </div>

            </div>
                </div>
           <hr />
                
            <asp:DataList ID="DataList1" Width="100%" runat="server" OnItemCommand="DataList1_ItemCommand"  CellPadding="4" ForeColor="#333333">
                <AlternatingItemStyle BackColor="White" />
                <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <ItemStyle BackColor="#E3EAEB" />
                <ItemTemplate>
                    
                    <table style="text-align:center; width:100%">
                        <tr><td>&nbsp;</td></tr>
                        <tr>
                            <td>
                                <asp:Label ID="LabelBusNumber" runat="server" Text='<%# Eval("BusNumber") %>'></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="LabelDeparture" runat="server" Text='<%# Eval("DepatureTime") %>'></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Labelduration" runat="server" Text='<%# Eval("duration") %> '></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="LabelArrival" runat="server" Text='<%# Eval("ArrivalTime") %>'></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="LabelFare" runat="server" Text='<%# Eval("Rate") %>'></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="LabelAvilableSeat" runat="server" Text=""></asp:Label>
                            </td>
                           
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="LabelType" runat="server" Text='<%# Eval("BusType") %>'></asp:Label>
                            </td>
                            <td>
                                
                            </td>
                            <td>
                                <asp:Label ID="LabelSheduleId" runat="server" Text='<%# Eval("shId") %>'></asp:Label>
                            </td>
                            
                            <td>
                                
                            </td>
                           
                            <td>
                                <asp:Label ID="LabelBusId" runat="server" Text='<%# Eval("bsId") %>' Visible="false"></asp:Label>
                            </td>
                            <td>
                                <asp:Button ID="Button1"  CommandName="ViewSeats" runat="server" Text="View Seats" />
                            </td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                        </tr>
                    </table>
                </ItemTemplate>

                <SelectedItemStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />

            </asp:DataList>
                    
               
            </div>
   
</asp:Content>
