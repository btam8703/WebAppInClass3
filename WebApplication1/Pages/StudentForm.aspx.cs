using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Pages
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private static List<Student> StudentList = new List<Student>();

        protected void Page_Load(object sender, EventArgs e)
        {
            MessageLabel.Text = "";
        }
        protected void Add_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                bool found = false;
                foreach (var item in StudentList)
                {
                    if (item.StudentID == int.Parse(StudentID.Text))
                    {
                        found = true;
                    }
                }
                if (found)
                {
                    MessageLabel.Text = "Record already exists.";
                }
                else
                {
                    Student newitem = new Student(int.Parse(StudentID.Text), StudentName.Text, double.Parse(StudentCredits.Text), Phone.Text);
                    StudentList.Add(newitem);
                    PeopleGridView.DataSource = StudentList;
                    PeopleGridView.DataBind();
                }
            }
        }
        protected void Clear_Click(object sender, EventArgs e)
        {
            StudentID.Text = "";
            StudentCredits.Text = "";
            StudentName.Text = "";
            Phone.Text = "";
        }
    }
}
