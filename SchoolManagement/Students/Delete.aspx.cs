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
    public partial class Delete : System.Web.UI.Page
    {
        protected IRepository<Student> repository;
        public Delete()
        {
            repository=new Repository<Student>();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            int id;
            bool parsingResult= int.TryParse(Request.QueryString["id"],out id);
            if (parsingResult)
            {
                var student= repository.Find(id);
                lblName.Text = student.FName + " " + student.LName;
            }
        }

        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            int id;
            bool parsingResult = int.TryParse(Request.QueryString["id"], out id);
            if (parsingResult)
            {
                var student = repository.Find(id);
                repository.Delete(student);
                Response.Redirect("List");
            }
        }



    }
}