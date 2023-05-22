using SchoolManagement.Models;
using SchoolManagement.Services;
using System;
using System.Web.UI;

namespace SchoolManagement.Students
{
    public partial class Edit : System.Web.UI.Page
    {
        private IRepository<Student> repository;
        public DateTime mydate;
        public Edit()
        {
            repository = new Repository<Student>();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                int id = int.Parse( Request.QueryString["id"]);
                
                Student s = repository.Find(id);
                if (s != null)
                {
                    txtid.Value = s.Id.ToString();
                    txtFName.Text = s.FName;
                    txtLName.Text = s.LName;
                    try
                    {
                        mydate = s.DateOfBirth.Value;
                        if (mydate!=null)
                        {
                            txtDOP.TextMode = System.Web.UI.WebControls.TextBoxMode.Date;
                            txtDOP.Text = mydate.ToShortDateString();



                        }

                    }
                    catch (Exception)
                    {

                    }
                    txtNotes.Text = s.Notes;
                }
                else
                {
                    Response.StatusCode = 404;
                    Response.End();
                }
            }

        }



        protected void submitButton_Click1(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                var Student = repository.Find(int.Parse( txtid.Value));

                Student.Id = int.Parse(txtid.Value);
                    Student.FName = txtFName.Text;
                    Student.LName = txtLName.Text;
                    Student.Notes = txtNotes.Text;
                
                DateTime parsedDateTime = new DateTime();
              bool dateparsedSuccessfuly=  DateTime.TryParse(txtDOP.Text, out parsedDateTime);
                if (dateparsedSuccessfuly)
                {
                    Student.DateOfBirth = parsedDateTime;
                }
                else
                {
                    Student.DateOfBirth = null;
                }
                repository.Update(Student);
                Response.Redirect("list");
            }
        }
    }
}