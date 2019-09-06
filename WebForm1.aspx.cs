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
            GridView1.DataSource = dbContex.Employees;
            GridView1.DataBind();
        }

        protected void btnGetData_Click(object sender, EventArgs e)
        {
            GetData();
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {

            using (SampleDataContext dbContex = new SampleDataContext())
            {
                Employees newEmployee = new Employees
                {
                    FirstName = "Pamela",
                    LastName = "Vazques",
                    Title = "Costurera",
                    TitleOfCourtesy = "Sra.",
                    Address = "Echeverria 158",
                    City = "Mendoza",
                    Region = "Cuyo",
                    PostalCode = "5598",
                    Country = "Argentina",
                    HomePhone = "4369852",
                    Extension = "SDFW",
                    Notes = "Nada we"
                };
                dbContex.Employees.InsertOnSubmit(newEmployee);
                dbContex.SubmitChanges();
            }
            GetData();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            using (SampleDataContext dbContex = new SampleDataContext())
            {

                Employees employee = dbContex.Employees.SingleOrDefault(x => x.EmployeeID == 20);
                employee.PostalCode = "6650";
                dbContex.SubmitChanges();
            }
            GetData();

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            using (SampleDataContext dbContex = new SampleDataContext())
            {

                Employees employee = dbContex.Employees.SingleOrDefault(x => x.EmployeeID == 20);
                dbContex.Employees.DeleteOnSubmit(employee);
                dbContex.SubmitChanges();
            }
            GetData();
        }
    }
}