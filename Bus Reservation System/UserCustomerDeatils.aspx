<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="UserCustomerDeatils.aspx.cs" Inherits="Bus_Reservation_System.UserCustomerDeatils" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>

    </div>
    <div class="col-md-12" style="width:100%">
        <div class="col-md-3"></div>
         <div class="col-md-6 form-container">
             
                    <div class="form-group">
                        <h2>
                            <asp:Label ID="LabelFrom" runat="server" Text=""></asp:Label>: To :<asp:Label ID="LabelTo" runat="server" Text=""></asp:Label></h2>
                        <h3>Passenger Information</h3>
                        <hr />
                        <div>
                            <asp:Label ID="LabelName" runat="server" Text="Name"></asp:Label>
                            <asp:TextBox ID="TextBoxName" CssClass="form-control" runat="server"></asp:TextBox>
                            <asp:Label ID="LabelGender" runat="server" Text="Gender"></asp:Label><br />
                            <asp:RadioButton ID="RadioButtonMale" GroupName="Gender" Text="Male" runat="server" /><asp:RadioButton ID="RadioButtonFemale" Text="Female"  GroupName="Gender" runat="server" />Female<br />
                            <asp:Label ID="LabelAge" runat="server" Text="Age"></asp:Label>
                            <asp:TextBox ID="TextBoxAge" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                        <h3>Contact deatils</h3>
                        <hr />
                        <div>
                            <asp:Label ID="LabelMail" runat="server" Text="Mail"></asp:Label>
                            <asp:TextBox ID="TextBoxMail" CssClass="form-control" runat="server"></asp:TextBox>
                            <asp:Label ID="LabelPhone" runat="server" Text="Phone Number"></asp:Label>
                            <asp:TextBox ID="TextBoxPhone" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                        <hr />
                        <div class="row"><div class="col-md-8"><h5>Total Amount:<asp:Label ID="LabelAmount" runat="server" Text=""></asp:Label></h5></div><div class="col-md-4">
                            <asp:Button ID="ButtonPay" CssClass="" runat="server" Text="Prceed To Pay" OnClick="ButtonPay_Click" /></div></div>
                        </div>
                 
         </div>
         <div class="col-md-3"></div>
    </div>
</asp:Content>
