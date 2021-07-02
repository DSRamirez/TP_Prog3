<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TP_Prog3._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        <h1>
            <asp:Label ID="lblprimera" runat="server" Text="Hola Mundo - Es la primera vez que se ha cargado la página  "></asp:Label>
        </h1>
        <h1>
            Cantidad de veces que se recargó la página:
            <asp:Label ID="lblcontador" runat="server"></asp:Label>
&nbsp;</h1>
        <h1>
            <asp:Button ID="btncargar" runat="server" OnClick="btncargar_Click" Text="Cargar" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="tbtreinicia" runat="server" OnClick="tbtreinicia_Click" Text="Reiniciar" />
        </h1>
    </div>


</asp:Content>
