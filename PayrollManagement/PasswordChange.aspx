<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="PasswordChange.aspx.cs" Inherits="PayrollManagement.PasswordChange" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="float:right; clear:left">
        </div>
        <div id="OuterDiv">
            <h2>
            Change password
        </h2>
            <div id="Content" style="margin:auto">
                <table style="width:300px">
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="newPassword" Text="New Password"/>
                        </td>
                        <td>
                            <asp:TextBox runat="server" ID="passwordTxtBox"/>
                            <asp:RequiredFieldValidator ID="passwordValidator" runat="server" ErrorMessage="Password Must Required" ControlToValidate="passwordTxtBox" ></asp:RequiredFieldValidator>

                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" ID="confirmPass" Text="Confirm Password"/>

                        </td>
                        <td>
                            <asp:TextBox runat="server" ID="confirmPasswordTxtBox"/>
                            <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Mismatch Password" ControlToValidate="confirmPasswordTxtBox" ControlToCompare="passwordTxtBox"></asp:CompareValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                        </td>
                        <td>
                            <asp:Button runat="server" ID="submit" Text="Submit" OnClick="submit_Click"/>
                        </td>
                    </tr>
                </table>
                <asp:Label runat="server" ID="statusLabel"  ForeColor="Red" Font-Bold="true" Font-Size="Large" />
            </div>
        </div>
</asp:Content>
