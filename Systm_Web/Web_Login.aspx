<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Web_Login.aspx.cs" Inherits="Systm_Web.Web_Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
   
    
    <link rel="stylesheet" href="css/bootstrap.min.css">
<link rel="stylesheet" href="css/bootstrap-theme.min.css">
<script src="js/jquery.min.js"></script>
<script src="js/bootstrap.min.js"></script>
    <title></title>
    <style type="text/css">
        .auto-style1
        {
            width: 100%;
        }
        .auto-style3
        {
            width: 124px;
        }
        .auto-style4 {
            height: 144px;
            width: 521px;
        }
        .auto-style5 {
            width: 124px;
            height: 144px;
        }
        .auto-style6 {
            width: 396px
        }
        .auto-style8 {
            width: 249px;
        }
        .auto-style9 {
            width: 11px;
        }
        .auto-style10 {
            width: 40px;
        }
        .auto-style11 {
            width: 521px;
        }
    </style>
</head>
<body style="background-color: #FFFFFF; color: #000000;">
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style4"></td>
                <td class="auto-style5">
                    <br />
                </td>
            </tr>
            <%--<tr>--%>
                <tr>
                <td class="auto-style11">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style6">
                    <br />
                    <br />
                    </td>


                <td>
                    <br />
                </td>
            </tr>
                <td class="auto-style11">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style6">
                    <asp:Panel ID="Panel2" runat="server" Height="250px" style="background-color: #66CCFF" Width="337px">
                        <table class="nav-justified">
                            <tr>
                                <td class="auto-style9">&nbsp;</td>
                                <td class="auto-style10">&nbsp;</td>
                                <td class="auto-style8">
                                    <h3>&nbsp;Accede a tu cuenta 🔐 </h3>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style9">&nbsp;</td>
                                <td class="auto-style10">&nbsp;</td>
                                <td class="auto-style8">
                                    <asp:TextBox ID="txtusuario" runat="server" class="form-control" placeholder="🔐 Usuario" Width="233px"></asp:TextBox>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style9">&nbsp;</td>
                                <td class="auto-style10">&nbsp;</td>
                                <td class="auto-style8">
                                    <asp:TextBox ID="txtcontraseña" runat="server" class="form-control" placeholder="🔐  Contraseña" TextMode="Password" Width="233px"></asp:TextBox>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style9">&nbsp;</td>
                                <td class="auto-style10">&nbsp;</td>
                                <td class="auto-style8">
                                    <asp:Button ID="Button1" runat="server" class="btn btn-primary" Height="35px" OnClick="Button1_Click" Text="Ingresar" Width="234px" />
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style9">&nbsp;</td>
                                <td class="auto-style10">&nbsp;</td>
                                <td class="auto-style8">
                                    &nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style9">&nbsp;</td>
                                <td class="auto-style10">&nbsp;</td>
                                <td class="auto-style8">
                                    &nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                    </asp:Panel>
            </td>


                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style11">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style6">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style11">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style11">&nbsp;</td>
                <td class="auto-style3">
                    &nbsp;</td>
                <td class="auto-style6">
                    <asp:Panel ID="Panel1" runat="server">
                    </asp:Panel>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style11">&nbsp;</td>
                <td class="auto-style3">
                    &nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td>
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br /> 
                    <br />
                    <br />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>