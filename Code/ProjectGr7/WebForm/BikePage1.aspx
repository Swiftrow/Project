<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BikePage1.aspx.cs" Inherits="WebClient.BikePage1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div class ="IDBike">
                    <p>Insert bike ID:      <asp:TextBox ID="IDBike" runat="server"></asp:TextBox></p>
                </div>

        <div class="TableBike">
            <p> Za bike :               <asp:Table ID="TableBike" runat="server">
                <asp:TableRow runat="server">
                    <asp:TableCell ID="Name" runat="server"></asp:TableCell>
                    <asp:TableCell ID="Category" runat="server"></asp:TableCell>
                    <asp:TableCell runat="server"></asp:TableCell>
                    <asp:TableCell runat="server"></asp:TableCell>
                    <asp:TableCell runat="server"></asp:TableCell>
                    <asp:TableCell runat="server"></asp:TableCell>
                    <asp:TableCell runat="server"></asp:TableCell>
                    <asp:TableCell runat="server"></asp:TableCell>
                    <asp:TableCell runat="server"></asp:TableCell>
                    <asp:TableCell runat="server"></asp:TableCell>
                    <asp:TableCell runat="server"></asp:TableCell>
                    <asp:TableCell runat="server"></asp:TableCell>
                </asp:TableRow>
                </asp:Table></p>
        </div>
            

        <div class="Find">
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click2" Text="Button" />
            </div>
    </div>
    </form>
</body>
</html>
