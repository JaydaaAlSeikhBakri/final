<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page1.aspx.cs" Inherits="Tecno_2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div id="btnSubmits_Click">
    
       Name 
        <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
        </div>
        <p>
           Age 
            <asp:TextBox ID="txtage" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="btnSubmit_Click" runat="server" OnClick="btnSubmit_Click_Click" Text="Add To ViewState" />
        <p>
            <asp:Button ID="btnview_click" runat="server" OnClick="btnview_click_Click" Text="View" />
        </p>
        <asp:Button ID="btndone_Click" runat="server" OnClick="btndone_Click_Click" Text="Query String" />
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Session" />
        </p>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Cookie" />
        <asp:HiddenField ID="hiddenTime" runat="server" />
    </form>
    </body>
</html>
