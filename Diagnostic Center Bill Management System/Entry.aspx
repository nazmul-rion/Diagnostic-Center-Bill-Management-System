<%@ Page Title="" Language="C#" MasterPageFile="~/navbar.Master" AutoEventWireup="true" CodeBehind="Entry.aspx.cs" Inherits="Diagnostic_Center_Bill_Management_System.Entry" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <fieldset class="pages" id="Entry">
        <form action="/addentry">
            <fieldset>
                <legend>Test Request Entry</legend>
                <label for="pname">Name of the Patient:</label>
                <br>
                <input type="text" id="pname" name="pname">
                <br>
                <label for="dob">Date of Birth:</label>
                <br>
                <input type="text" id="dob" name="dob">
                <br>
                <label for="mobile">Mobile No:</label>
                <br>
                <input type="text" id="mobile" name="mobile">
                <br>
                <label for="testtype">Select Test:</label>
                <br>
                <asp:DropDownList ID="DropDownList1" runat="server">
                </asp:DropDownList>
                <br>
                <label for="fee">Fee:</label>

                <br>
                <input type="text" id="fee" name="fee">
                <br>
                <asp:Button ID="addbtn" runat="server" Text="Add" />
                <br />
                <br />
                <asp:GridView ID="GridView1" runat="server">
                </asp:GridView>
                <br><br>

                <div style="text-align: right;">
            <label for="total">Total:</label>
            <input type="text" id="total" name="total">
            <br>
            <asp:Button ID="savebtn" runat="server" Text="Save" />
            <br><br>
        </div>
            </fieldset>
        </form>
        </fieldset>
</asp:Content>
