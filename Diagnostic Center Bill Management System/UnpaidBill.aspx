<%@ Page Title="" Language="C#" MasterPageFile="~/navbar.Master" AutoEventWireup="true" CodeBehind="UnpaidBill.aspx.cs" Inherits="Diagnostic_Center_Bill_Management_System.UnpaidBill" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <fieldset class="pages" id="Unpaid Bill">
        <form action="#">
            <fieldset>
                <legend>Unpaid Bill Report</legend>
                <label for="fdate">From Date :</label>
                <br>
                <input type="date" id="fdate" name="fdate">
                <br>
                <label for="tdate">To Date:</label>
                <br>
                <input type="date" id="tdate" name="tdate">
                <asp:Button ID="Button1" runat="server" Text="Show" OnClick="Button1_Click" />
                <br><br>
            </fieldset>
        </form>
        <br><br>
       
         <asp:GridView ID="GridView1" runat="server">
         </asp:GridView>
       
        <br><br>
        <div class="totalshw" style="text-align: right;">
            <label for=" total">Total:</label>
            <input type="text" id="total" name="total">
            <br><br>
        </div>
    </fieldset>


</asp:Content>
