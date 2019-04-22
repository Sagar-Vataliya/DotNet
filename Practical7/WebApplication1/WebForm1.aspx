<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-family: 'Comic Sans MS'; font-size: medium; font-weight: 200; text-align: left;">
            Name :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID = "TextBox_Name" runat = "server" 
                         ControlToValidate = "TextBox_Name">

            </asp:TextBox>
            &nbsp;<asp:RequiredFieldValidator ID = "RequiredFieldValidator3" runat = "server" 
                                              ErrorMessage = "Please, Enter your Name..!!"
                                              Text = "*"
                                              ControlToValidate = "TextBox_Name"
                                              Display = "Dynamic">
            </asp:RequiredFieldValidator>
            <br />
            <br />
            Email :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID = "TextBox_Email" runat="server" 
                        >
            </asp:TextBox>
                &nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                                                      ErrorMessage="RegularExpressionValidator"
                                                      Text = "*"
                                                      ControlToValidate="TextBox_Email"
                                                      Display = "Dynamic">
                      </asp:RegularExpressionValidator>
            <br />
            <br />
            Mobile:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            <asp:TextBox ID = "TextBox_Mobile" runat = "server" 
                         ControlToValidate = "TextBox_Mobile"></asp:TextBox>
                &nbsp;<asp:RangeValidator ID = "RangeValidator1" runat = "server" 
                                ErrorMessage="Inappropriate Number, Range of Mobile Number : 0000000000 to 999999999"
                                Text ="*"
                                ControlToValidate = "TextBox_Mobile" 
                                MaximumValue="9999999999" 
                                MinimumValue="0000000000" 
                                Display="Dynamic" Type="Double"></asp:RangeValidator>
            <br />
            <br />
            Password:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID = "TextBox_Password" runat = "server" 
                         ControlToValidate = "TextBox_Password"></asp:TextBox>
                &nbsp;<asp:RequiredFieldValidator ID = "RequiredFieldValidator2" runat = "server" 
                                        ErrorMessage="Please, Re-Enter your password here..!!"
                                        Text = "*"
                                        ControlToValidate = "TextBox_Password"
                                        Display="Dynamic"></asp:RequiredFieldValidator>
            <br />
            <br />
            Confirm Password:
            <asp:TextBox ID = "TextBox_ConfirmPassword" runat = "server" 
                         ControlToValidate="TextBox_ConfirmPassword"></asp:TextBox>
                &nbsp;<asp:CompareValidator ID = "CompareValidator1" runat = "server" 
                                  ErrorMessage="Your Password is not Confirmed, Please Re-Enter your password..!!"
                                  Text = "*"
                                  ControlToValidate = "TextBox_ConfirmPassword" 
                                  ControlToCompare="TextBox_Password" 
                                  Display="Dynamic"></asp:CompareValidator>
            <br />
            <br />
           
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
            <br />
            <asp:Button ID="Submit" runat="server" 
                        Font-Bold="True" 
                        Font-Italic="False" 
                        OnClick="Form_Submit" 
                        Text="Submit" />
        </div>
    </form>
</body>
</html>
