using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Project.DataLayer;

namespace Project.BusinessLayer
{
    class Technician : Employee
    {
        private string job_description;
        public string Job_Description { get; set; }
        private string availability;
        public string Availability { get; set; }

        public DataTable ViewTechnicians()
        {
            return new DataHandler().ViewTechnicians();
        }

        public void AddTechnician()
        {
            new DataHandler().AddTechnician(Name, Surname, PhoneNumber, Job_Description, Convert.ToInt32(Employee_ID));
        }

        public DataTable SearchTechnician()
        {
            return new DataHandler().SearchTechnician(Convert.ToInt32(Employee_ID));
        }

        public void UpdateTechnician()
        {
            new DataHandler().UpdateTechnician(Name, Surname, PhoneNumber, Job_Description, Convert.ToInt32(Employee_ID));
        }

        public void TechnicianAvailability()
        {
            new DataHandler().TechnicianAvailability(Convert.ToInt32(Employee_ID), Availability);
        }
    }
}
