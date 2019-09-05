<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="LINQ_APP.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:GridView ID="GridView1" runat="server">

            </asp:GridView>


            <br />
            <asp:Button ID="btnGetData" runat="server" OnClick="btnGetData_Click" Text="Get Data" />
            <asp:Button ID="btnInsert" runat="server" OnClick="btnInsert_Click" Text="Insert" />


        </div>
    </form>
</body>
</html>
