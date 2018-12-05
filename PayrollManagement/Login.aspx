<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageEmp.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PayrollManagement.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%--<form id="form1" runat="server">--%>
        <div id="outerFrame">
            <h2>Log In</h2>
            <table>
                <tr>
                    <td>
                        <asp:Label Text="Employee ID" runat="server" />
                    </td>
                    <td>
                        <asp:TextBox ID="employeeIdTxtBox" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label Text="Password" runat="server" />
                    </td>
                    <td>
                        <asp:TextBox ID="passwordTxtBox" TextMode="Password" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button id="loginBtn" Text="LogIn" runat="server" OnClick="loginBtn_Click"/>

                    </td>
                </tr>
            </table>
            <asp:label id="commonLabel"  runat="server" Font-Bold="true" Font-Size="Large" ForeColor="Red"/>
        </div>
    <%--</form>--%>
</asp:Content>
