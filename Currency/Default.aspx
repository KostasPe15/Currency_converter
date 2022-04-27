<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h1>Μετατροπή Συναλλαγμάτος</h1>
        Δώστε νόμισμα προέλευσης:
        <asp:TextBox ID="TextBox1" runat="server" Width="39px"></asp:TextBox>
&nbsp;<asp:DropDownList ID="lstCurFrom" runat="server" Height="16px" Width="234px">
        </asp:DropDownList>
        <br />
        <br />
        Δώστε νόμισμα προορισμού:&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="lstCurTo" runat="server" Height="25px" Width="226px">
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Μετατροπή" />
        <br />
        <br />
        Αποτέλεσμα: <asp:Label ID="Label1" runat="server"></asp:Label>
        <br />
    
    </div>
    </form>
</body>
</html>
