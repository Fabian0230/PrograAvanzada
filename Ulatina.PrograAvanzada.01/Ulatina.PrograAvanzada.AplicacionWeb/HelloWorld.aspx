﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HelloWorld.aspx.cs" Inherits="Ulatina.PrograAvanzada.AplicacionWeb.HelloWorld" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="height: 379px">
    <form id="frmForma" runat="server">
    <div style="height: 382px" title="Hola mundo">
    
        Hola a todos<br />
        Entrada de parametros<br />
        <asp:Calendar ID="cldFechaEnviada" runat="server" OnSelectionChanged="cldFechaEnviada_SelectionChanged"></asp:Calendar>
        <br />
        Fecha seleccionada: <asp:Label ID="lblFechaRecibida" runat="server" Text="Label"></asp:Label>
    
        <br />
        <br />
        <asp:TextBox ID="txtValor1" runat="server"></asp:TextBox>
&nbsp;<asp:TextBox ID="txtValor2" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="btnSumar" runat="server" OnClick="btnSumar_Click" Text="Sumar" />
        <br />
        <asp:Label ID="Resultado" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
