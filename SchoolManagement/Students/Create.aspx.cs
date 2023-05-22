using SchoolManagement.Models;
using SchoolManagement.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SchoolManagement.Students
{
    public partial class Create : System.Web.UI.Page
    {
        protected IRepository<Student> _studentRepository;

        public Create()
        {
            _studentRepository = new Repository<Student>();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submitButton_Click1(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                var student = new Student();
                student.FName = txtFName.Text;
                student.LName = txtLName.Text;
                DateTime dateTime;
                bool parsingDateSucceded = DateTime.TryParse(txtDOP.Text, out dateTime);
                if (parsingDateSucceded)
                    student.DateOfBirth = dateTime;
                student.Notes = txtNotes.Text;

                _studentRepository.Create(student);
                Response.Redirect("List.aspx");
            }

        }
    }
}