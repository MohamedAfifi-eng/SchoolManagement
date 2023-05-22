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
    public partial class List : System.Web.UI.Page
    {
        public IEnumerable<Student> Students { get; set; }
        private IRepository<Student> _studentRepository;
        protected void Page_Load(object sender, EventArgs e)
        {
            _studentRepository=new Repository<Student>();
            Students= _studentRepository.GetAll().ToList();
            GridView1.DataSource = Students;
            GridView1.DataBind();
        }
    }
}