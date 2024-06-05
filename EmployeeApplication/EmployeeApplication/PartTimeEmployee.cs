using EmployeeInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeNamespace
{
    public class PartTimeEmployee : IEmployee
    {
        private string _firstName;
        private string _middleInitial;
        private string _lastName;
        private string _department;
        private string _jobTitle;
        private double _basicSalary;

        public PartTimeEmployee(string FName, string MInitial, string LName, string dept, string job)
        {
            _firstName = FName;
            _middleInitial = MInitial;
            _lastName = LName;
            _department = dept;
            _jobTitle = job;
            _basicSalary = 0.0;
        }

        public string FirstName { get => _firstName; set => _firstName = value; }
        public string MiddleName { get => _middleInitial; set => _middleInitial = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public string Department { get => _department; set => _department = value; }
        public string JobTitle { get => _jobTitle; set => _jobTitle = value; }
        public double BasicSalary { get => _basicSalary; }

        public void computeSalary(int hoursWorked, double ratePerHour)
        {
            _basicSalary = hoursWorked * ratePerHour;
        }

        public double getSalary()
        {

            return _basicSalary;
        }
    }
}
