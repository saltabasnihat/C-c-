using Lab_6.Models;
using Lab6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab_6
{
    public partial class RegisterCourse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Load available courses 
                List<Course> availableCourses = Helper.GetAvailableCourses();
                cblAvailableCourses.DataSource = availableCourses;
                cblAvailableCourses.DataTextField = "Title";
                cblAvailableCourses.DataValueField = "Code";
                cblAvailableCourses.DataBind();
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string studentName = txtStudentName.Text.Trim();

            string studentType = rblStudentType.SelectedValue;

            List<string> selectedCourses = new List<string>();
            foreach (ListItem item in cblAvailableCourses.Items)
            {
                if (item.Selected)
                {
                    selectedCourses.Add(item.Value);
                }
            }

            bool isValid = ValidateRegistration(studentName, studentType, selectedCourses);

            if (isValid)
            {
                // Show the confirmation page
                lblConfirmation.Text = "Registration Successful!";
                lblStudentName.Text = "Student Name: " + studentName;
                lblStudentType.Text = "Student Type: " + studentType;

                List<Course> courses = Helper.GetSelectedCourses(selectedCourses);
                gvSelectedCourses.DataSource = courses;
                gvSelectedCourses.DataBind();

                int totalWeeklyHours = courses.Sum(c => c.WeeklyHours);
                lblTotalWeeklyHours.Text = "Total Weekly Hours: " + totalWeeklyHours;
            }
            else
            {
                // Show error
                lblConfirmation.Text = "Registration Failed! Please check the validation rules.";
                lblStudentName.Text = "";
                lblStudentType.Text = "";
                lblTotalWeeklyHours.Text = "";
                gvSelectedCourses.DataSource = null;
                gvSelectedCourses.DataBind();
            }
        }

        private bool ValidateRegistration(string studentName, string studentType, List<string> selectedCourses)
        {
            if (string.IsNullOrWhiteSpace(studentName))
            {
                return false;
            }

            if (studentType == "FullTime")
            {
                int totalWeeklyHours = Helper.GetSelectedCourses(selectedCourses).Sum(c => c.WeeklyHours);
                if (totalWeeklyHours > 16)
                {
                    return false;
                }
            }
            else if (studentType == "PartTime")
            {
                if (selectedCourses.Count > 3)
                {
                    return false;
                }
            }
            else if (studentType == "Coop")
            {
                int totalWeeklyHours = Helper.GetSelectedCourses(selectedCourses).Sum(c => c.WeeklyHours);
                if (selectedCourses.Count > 2 || totalWeeklyHours > 4)
                {
                    return false;
                }
            }

            // Validation passed
            return true;
        }
    }
}
