<%@ Page Title="" Language="C#" MasterPageFile="~/navbar.Master" AutoEventWireup="true" CodeBehind="TestwiseReport.aspx.cs" Inherits="Diagnostic_Center_Bill_Management_System.TeswiseReport" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <fieldset class="pages" id="Test Wise">
        <form action="#">
            <fieldset>
                <legend>Test Wise Report</legend>
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
                <th>Test Name</th>
                <th>Total Test</th>
                <th>Total Ammount</th>
            </tr>
            <tr>
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
