using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Project.DataLayer;

namespace Project.BusinessLayer
{
    class CallAgent : Employee
    {

        public DataTable ViewAgents()
        {
            return new DataHandler().ViewAgents();
        }

        public void AddAgent()
        {
            new DataHandler().AddAgent(Name, Surname, PhoneNumber, Convert.ToInt32(Employee_ID));
        }

        public DataTable SearchAgent()
        {
            return new DataHandler().SearchAgent(Convert.ToInt32(Employee_ID));
        }

        public void UpdateAgent()
        {
            new DataHandler().UpdateAgent(Name, Surname, PhoneNumber, Convert.ToInt32(Employee_ID));
        }
    }
}
