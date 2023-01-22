using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.DataLayer;

namespace Project.BusinessLayer
{
    class Employee
    {
        private string name;
        public string Name { get; set; }
        private string surname;
        public string Surname { get; set; }
        private string phonenumber;
        public string PhoneNumber { get; set; }
        private string branch;
        public string Branch { get; set; }
        private string employee_id;
        public string Employee_ID { get; set; }

        public void AddEmployee()
        {
            new DataHandler().AddEmployee(Convert.ToInt32(Employee_ID), Convert.ToInt32(Branch));
        }

        public void DeleteEmployee()
        {
            new DataHandler().DeleteEmployee(Convert.ToInt32(Employee_ID));
        }
    }

}
