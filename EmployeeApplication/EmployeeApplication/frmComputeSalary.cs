using EmployeeNamespace;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeApplication
{
    public partial class frmComputeSalary : Form
    {
        public frmComputeSalary()
        {
            InitializeComponent();
        }

        private void btnComputeSalary_Click(object sender, EventArgs e)
        {
            string firstName = FirstName.Text;
            string middleInitial = MiddleInitial.Text;
            string lastName = LastName.Text;
            string department = "";
            string jobTitle = "";
            double ratePerHour = double.Parse(RatePerHour.Text);
            int hoursWorked = int.Parse(HoursWorked.Text);

            PartTimeEmployee employee = new PartTimeEmployee(firstName, middleInitial, lastName, department, jobTitle);

            employee.computeSalary(hoursWorked, ratePerHour);

            BasicSalary.Text = employee.getSalary().ToString();

            fname.Text = employee.FirstName;
            minitial.Text = employee.MiddleName;
            lname.Text = employee.LastName;

        }
    }
}
