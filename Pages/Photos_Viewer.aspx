﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Photos_Viewer.aspx.cs" Inherits="Bazaar.Pages.Photos_Viewer" MasterPageFile="~/Public.Master" %>
<%@ OutputCache Duration="60" VaryByParam="*" Location="Any" %>

<asp:Content ID="Content4" ContentPlaceHolderID="MainMenu" runat="server" >
    <asp:Panel runat="server" ID="PnlMenu">
    </asp:Panel>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="TopCplcHolder" runat="server">
    <asp:Panel runat="server" ID="PnlTop">
    </asp:Panel>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="LeftCplcHolder" runat="server">
    <asp:Panel runat="server" ID="PnlLeft">
    </asp:Panel>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainCplcHolder" runat="server">
    <asp:Panel runat="server" ID="PnlRight">
    </asp:Panel>
</asp:Content>
