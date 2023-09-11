<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterCourse.aspx.cs" Inherits="Lab_6.RegisterCourse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Course Registration Page</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            margin: 20px;
            padding: 0;
            background-color: #f2f2f2;
        }

        h1, h2 {
            margin: 0;
            padding: 0;
        }

        .h1 {
            color: #1e3650;
            font-size: 28px;
            font-weight: bold;
            margin-bottom: 10px;
        }

        h2 {
            color: #1e3650;
            font-size: 22px;
            margin-bottom: 20px;
        }

        form {
            background-color: #fff;
            padding: 20px;
            border: 1px solid #ddd;
            border-radius: 5px;
        }

        label {
            font-weight: bold;
        }

        input[type="text"],
        input[type="submit"] {
            padding: 5px 10px;
            font-size: 14px;
            border: 1px solid #ccc;
            border-radius: 3px;
        }

        input[type="text"] {
            width: 200px;
        }

        input[type="submit"] {
            background-color: #1e3650;
            color: #fff;
            cursor: pointer;
        }

        input[type="radio"],
        input[type="checkbox"] {
            margin-right: 5px;
        }

        #btnSubmit {
            margin-top: 10px;
        }

        #lblConfirmation,
        #lblStudentName,
        #lblStudentType {
            font-size: 16px;
            font-weight: bold;
            color: #1e3650;
            margin-top: 10px;
        }

        #gvSelectedCourses {
            margin-top: 20px;
            border-collapse: collapse;
            width: 100%;
        }

        #gvSelectedCourses th, #gvSelectedCourses td {
            border: 1px solid #ddd;
            padding: 8px;
            text-align: left;
        }

        #gvSelectedCourses th {
            background-color: #f2f2f2;
            font-weight: bold;
        }

        #lblTotalWeeklyHours {
            font-size: 16px;
            font-weight: bold;
            color: #1e3650;
        }
    </style>
</head>

<body>
    <form id="form1" runat="server">
        <div>
            <h1 class="h1">Algonquin College Course Resitration</h1>
            <h2>Register for Courses</h2>

            <label for="txtStudentName">Student Name:</label>
            <asp:TextBox ID="txtStudentName" runat="server" placeholder="Enter student name"></asp:TextBox>
            <br />

            <p>Student Type:</p>
            <asp:RadioButtonList ID="rblStudentType" runat="server">
                <asp:ListItem Text="Full Time" Value="FullTime"></asp:ListItem>
                <asp:ListItem Text="Part Time" Value="PartTime"></asp:ListItem>
                <asp:ListItem Text="Co-op" Value="Coop"></asp:ListItem>
            </asp:RadioButtonList>
            <br />

            <p>Available Courses:</p>
            <asp:CheckBoxList ID="cblAvailableCourses" runat="server">
            </asp:CheckBoxList>

            <br />

            <asp:Button ID="btnSubmit" runat="server" Text="Submit Registration" OnClick="btnSubmit_Click" />


            <br />
            <asp:Label ID="lblConfirmation" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="lblStudentName" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="lblStudentType" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="lblSelectedCourses" runat="server" Text=""></asp:Label>
        </div>
        <p>Selected Courses:</p>
        <asp:GridView ID="gvSelectedCourses" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="Code" HeaderText="Course Code" />
                <asp:BoundField DataField="Title" HeaderText="Course Title" />
                <asp:BoundField DataField="WeeklyHours" HeaderText="Weekly Hours" />
            </Columns>
        </asp:GridView>

        <p>Total Weekly Hours:
            <asp:Label ID="lblTotalWeeklyHours" runat="server" Text=""></asp:Label></p>

    </form>

</body>
</html>
