<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="MasterPage1.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:TextBox ID="TB_UserLogin" runat="server" Height="25px" Width="216px"></asp:TextBox>
    <br />
    <asp:TextBox ID="TB_PassLogin" runat="server" Height="24px" TextMode="Password" Width="220px"></asp:TextBox>
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="B_Login" runat="server" OnClick="B_Login_Click" Text="Iniciar sesion" />
    <br />
    <br />
    <br />
    <br />
    <asp:TextBox ID="TB_UserReg" runat="server" Height="25px" Width="216px" style="margin-bottom: 6px"></asp:TextBox>
    <br />
    <asp:TextBox ID="TB_PassReg" runat="server" Height="24px" TextMode="Password" Width="220px" EnableTheming="True"></asp:TextBox>
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="B_Register" runat="server" OnClick="B_Register_Click" Text="Registrarse" />
</asp:Content>
