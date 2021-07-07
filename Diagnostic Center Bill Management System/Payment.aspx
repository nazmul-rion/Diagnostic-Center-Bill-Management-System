<%@ Page Title="" Language="C#" MasterPageFile="~/navbar.Master" AutoEventWireup="true" CodeBehind="Payment.aspx.cs" Inherits="Diagnostic_Center_Bill_Management_System.Payment" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <fieldset class="pages" id="Payment">
        <form action="#">
            <fieldset>
                <legend>Payment</legend>
                <label for="billno">Bill No :</label>
                <br>
                <input type="text" id="billno" name="billno">
                <b>OR</b>
                <br>
                <label for="mobile">Mobile No:</label>
                <br>
                <input type="text" id="mobile" name="mobile">
                <input class="btn" type="submit" value="Search" name="searchbtn">
                <br><br>
            </fieldset>
        </form>
        <br><br>
        <fieldset>
            <form action="#">
                <label for="ammount">Ammount :</label>
                <br>
                <input type="text" id="ammount" name="ammount">
                <br>
                <label for="duedate">Due Date:</label>
                <br>
                <input type="date" id="duedate" name="duedate">
                <input class="btn" type="submit" value="Pay" name="paybtn">
            </form>
        </fieldset>

    </fieldset>

</asp:Content>
