using LINQ_APP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LINQ_APP
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        private void GetData()
        {
            SampleDataContext dbContex = new SampleDataContext();

            dbContex.Log = Response.Output;
            GridView1.DataSource = dbContex.GetEmployee();
            GridView1.DataBind();
        }

        protected void btnGetData_Click(object sender, EventArgs e)
        {
            GetData();
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {

            SampleDataContext dbContext = new SampleDataContext();
            dbContext.InsertEmployee();
            GetData();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            SampleDataContext dbContext = new SampleDataContext();
            dbContext.UpdateEmployee();
            GetData();

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            SampleDataContext dbContext = new SampleDataContext();
            dbContext.DeleteEmployee();            
            GetData();
        }
    }
}