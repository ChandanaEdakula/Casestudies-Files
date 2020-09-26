using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel; //for FaultException class
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using WCFWebClient.ServiceReference2; //for proxy class

namespace WCFWebClient
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                EmpServiceClient proxy = new EmpServiceClient();
                var empLst = proxy.GetAllEmps().ToList();

                GridView1.DataSource = empLst;
                GridView1.DataBind();
            }
        }

        protected void btnGetData_Click(object sender, EventArgs e)
        {
            //EmpServiceClient proxy = new EmpServiceClient();
            //int data = int.Parse(txtData.Text);
            //string result = proxy.GetData(data);

            //lblMsg.Text = result;
        }

     
        protected void btnAddEmp_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee
            {
                Ecode=int.Parse(txtEcode.Text),
                Ename = TxtEname.Text,
                Salary = int.Parse(txtSalary.Text),
                Deptid = int.Parse(txtDeptid.Text)
            };

            EmpServiceClient proxy = new EmpServiceClient();
            proxy.AddEmployee(emp);
            lblMsg.Text = "Record inserted";

            GridView1.DataSource = proxy.GetAllEmps().ToList();
            GridView1.DataBind();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int ecode = int.Parse(txtEcode.Text);

                EmpServiceClient proxy = new EmpServiceClient();
                proxy.DeleteEmpById(ecode);
                lblMsg.Text = "Record deleted";

                GridView1.DataSource = proxy.GetAllEmps().ToList();
                GridView1.DataBind();
            }
            catch(FaultException<MyException> ex)
            {
                lblMsg.Text = ex.Message;
            }

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee
            {
                Ecode = int.Parse(txtEcode.Text),
                Ename = TxtEname.Text,
                Salary = int.Parse(txtSalary.Text),
                Deptid = int.Parse(txtDeptid.Text)
            };

            EmpServiceClient proxy = new EmpServiceClient();
            proxy.UpdateEmpById(emp);
            lblMsg.Text = "Record updated";

            GridView1.DataSource = proxy.GetAllEmps().ToList();
            GridView1.DataBind();
        }

        protected void btnFindById_Click(object sender, EventArgs e)
        {
            int ecode = int.Parse(txtEcode.Text);

            EmpServiceClient proxy = new EmpServiceClient();
            Employee record = proxy.GetEmpById(ecode);

            TxtEname.Text = record.Ename;
            txtSalary.Text = record.Salary.ToString();
            txtDeptid.Text = record.Deptid.ToString();

        }

        protected void btnDivide_Click(object sender, EventArgs e)
        {
            try
            {
                MathServiceClient proxy = new MathServiceClient();
                proxy.DivideNumber();
            }
            catch(FaultException<MyException> ex)
            {
                lblMsg.Text = ex.Message;
            }
        }
    }
}