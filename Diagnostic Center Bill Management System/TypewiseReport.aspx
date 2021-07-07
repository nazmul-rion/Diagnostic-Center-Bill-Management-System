<%@ Page Title="" Language="C#" MasterPageFile="~/navbar.Master" AutoEventWireup="true" CodeBehind="TypewiseReport.aspx.cs" Inherits="Diagnostic_Center_Bill_Management_System.TypewiseReport" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <fieldset class="pages" id="Type Wise">
        <form action="#">
            <fieldset>
                <legend>Type Wise Report</legend>
                <label for="fdate">From Date :</label>
                <br>
                <input type="date" id="fdate" name="fdate">
                <br>
                <label for="tdate">To Date:</label>
                <br>
                <input type="date" id="tdate" name="tdate">
                <input class="btn" type="submit" value="Show" name="showbtn">
                <br><br>
            </fieldset>
        </form>
        <br><br>
       <gridview></gridview>
        <button class="pbfbtn">PDF</button>
        <div class="totalshw" style="text-align: right;">
            <label for=" total">Total:</label>
            <input type="text" id="total" name="total">
            <br><br>
        </div>
    </fieldset>

</asp:Content>
