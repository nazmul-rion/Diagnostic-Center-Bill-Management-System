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
                <input class="btn" type="submit" value="Show" name="showbtn">
                <br><br>
            </fieldset>
        </form>
        <br><br>
        <table>
            <tr>
                <th>SL</th>
                <th>Bill Number</th>
                <th>Contact No</th>
                <th>Patient Name</th>
                <th>Bill Ammount</th>
            <tr>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
        </table>
        <br><br>
        <button class="pbfbtn">PDF</button>
        <div class="totalshw" style="text-align: right;">
            <label for=" total">Total:</label>
            <input type="text" id="total" name="total">
            <br><br>
        </div>
    </fieldset>


</asp:Content>
