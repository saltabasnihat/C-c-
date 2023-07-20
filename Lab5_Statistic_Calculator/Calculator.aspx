<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculator.aspx.cs" Inherits="Lab5_Statistic_Calculator.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Lab5</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" />
</head>
<body>

    <form runat="server" class="container mt-4">
        <h1 class="text-center">Statistics Calculator</h1>
        <div class="form-group">
            <label for="txtFirst">First number:</label>
            <asp:TextBox ID="txtFirst" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

        <div class="form-group">
            <label for="txtSecond">Second number:</label>
            <asp:TextBox ID="txtSecond" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

        <div class="form-group">
            <label for="txtThird">Third number:</label>
            <asp:TextBox ID="txtThird" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" CssClass="btn btn-primary" />
    </form>
    <div id="result" runat="server" class="container mt-4" visible="false">
        <h3>Calculated Statistics</h3>
        <p><strong>Maximum:</strong> <asp:Label ID="lblMax" runat="server"></asp:Label></p>
        <p><strong>Minimum:</strong> <asp:Label ID="lblMin" runat="server"></asp:Label></p>
        <p><strong>Average:</strong> <asp:Label ID="lblAverage" runat="server"></asp:Label></p>
        <p><strong>Total:</strong> <asp:Label ID="lblTotal" runat="server"></asp:Label></p>
    </div>
</body>
</html>
