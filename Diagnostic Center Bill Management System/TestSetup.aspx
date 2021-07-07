<%@ Page Title="" Language="C#" MasterPageFile="~/navbar.Master" AutoEventWireup="true" CodeBehind="TestSetup.aspx.cs" Inherits="Diagnostic_Center_Bill_Management_System.TestSetup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    
     <fieldset>
                <legend>Test Setup</legend>
                <label for="testname">Test name:</label>
                <br>
                <input type="text" id="testname" name="testname">
                <br>
                <label for="fee">Fee:</label>
                <br>
                <input type="text" id="fee" name="fee">
                <label>BDT</label>
                <br>
                <label for="testtype">Test Type:</label>
                <br>
                
                <asp:DropDownList ID="DropDownList1" name="typeid" runat="server">
                </asp:DropDownList>
                
                <br>
         <asp:Button Text="Save" runat="server" OnClick="savebtn" style="width: 42px" />
                <br />
                <br>
                <asp:GridView ID="GridView1" runat="server">
                </asp:GridView>
                <br />
                <br>
            </fieldset>


</asp:Content>