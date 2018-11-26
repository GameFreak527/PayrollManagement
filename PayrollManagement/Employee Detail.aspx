<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Employee Detail.aspx.cs" Inherits="Employee_View_Details.Employee_Detail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #TextArea1 {
            height: 99px;
            width: 231px;
        }
        body {
            background-color: #f6f8f9;
        }
        .button {
            background-color: white; /* Green */
            border: 2px solid #e7e7e7;;
            color: black;
            padding: 4px 8px;
            text-align: center;
            text-decoration: none;
            display: inline-block;
            font-size: 16px;
            margin: 2px 1px;
            -webkit-transition-duration: 0.4s; /* Safari */
            transition-duration: 0.4s;
            cursor: pointer;
        }
        .button:hover {background-color: #e7e7e7;}
        .button:active {
            background-color: #3e8e41;
            box-shadow: 0 5px #666;
            transform: translateY(4px);
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Employee Information</h1>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblViewWarning" runat="server" ForeColor="Red" visible="false" Text="view Warning"></asp:Label>
            <br />
            <asp:Label ID="Label6" runat="server" Text="Employee ID:"></asp:Label>
            &nbsp;&nbsp;&nbsp;<asp:TextBox ID="txtEmpId" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
            <asp:Button CssClass="button" ID="btnView" runat="server" Text="View" OnClick="btnView_Click" Width="121px" />
            <br />
            <br />
            <asp:Label ID="Label7" runat="server" Text="Social Security ID:"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblSSN" runat="server" Visible="false" Text="SSNLabel"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Name:"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtFname" Enabled="false" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Surname:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtLname" Enabled="false" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Address:"></asp:Label>
            &nbsp; &nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtAdd1" Enabled="false" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Email:"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtEmail" Enabled="false" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Text="Phone:"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtPhone" Enabled="false" runat="server"></asp:TextBox>
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button CssClass="button" ID="btnEdit" runat="server" Text="Edit" Width="117px" OnClick="btnEdit_Click" />

        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnSave" CssClass="button" runat="server" Text="Save" OnClick="btnSave_Click" Width="118px" />

        </div>
    </form>
</body>
</html>
