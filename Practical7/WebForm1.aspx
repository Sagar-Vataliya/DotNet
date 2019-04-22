<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Practical7.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
&nbsp;<asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtName" ErrorMessage="field must not be empty" ForeColor="Red" ToolTip="Enter value">*</asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
&nbsp;<asp:TextBox ID="txtPwd" runat="server" TextMode="Password" ></asp:TextBox>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtCPwd" ControlToValidate="txtPwd" ErrorMessage="Password &amp; cpassword must be same" ForeColor="Red" ToolTip="Enter pasword">*</asp:CompareValidator>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="C Password"  ></asp:Label>
&nbsp;<asp:TextBox ID="txtCPwd" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Sem"></asp:Label>
&nbsp;<asp:TextBox ID="txtSem" runat="server"></asp:TextBox>
            <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtSem" ErrorMessage="Not valid sem" ForeColor="Red" MaximumValue="8" MinimumValue="1" ToolTip="Enter sem" Type="Integer">*</asp:RangeValidator>
            <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="txtSem" ErrorMessage="enter even semester" ForeColor="Red" OnServerValidate="CustomValidator1_ServerValidate" ToolTip="enter even semester">*</asp:CustomValidator>
            <br />
            <br />
            <asp:Label ID="Label6" runat="server" Text="Phone no"></asp:Label>
&nbsp;<asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtPhone" ErrorMessage="Invalid phone no" ForeColor="Red" ToolTip="Enter phone" ValidationExpression="[0-9]{10}">*</asp:RegularExpressionValidator>
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Text="Email"></asp:Label>
&nbsp;<asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtEmail" ErrorMessage="Invalid email" ForeColor="Red" ToolTip="Enter email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
            <br />
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" Text="Submit" />
            <br />
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
            <br />
        </div>
    </form>
</body>
</html>
