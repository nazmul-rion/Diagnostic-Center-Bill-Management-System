<%@ Page Title="" Language="C#" MasterPageFile="~/navbar.Master" AutoEventWireup="true" CodeBehind="TestType.aspx.cs" Inherits="Diagnostic_Center_Bill_Management_System.TestType" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <fieldset class="pages" id="Test Type">
        <form action="/addtesttype" method="POST">
            <fieldset>
                <legend>Test Type Setup</legend>
                <label for="Type_Name">Type name:</label>
                <input type="text" id="Type_Name" name="Type_Name"><br>
                <asp:Button class="btn"  runat="server" type="submit" OnClick="Button1_Click" Text="Save"/>
&nbsp;<br />
                <br />
                <br>
                <asp:GridView ID="GridView1" runat="server">
                </asp:GridView>
                <br>
            </fieldset>
        </form>
        <br><br><br>
       

    </fieldset>

</asp:Content>