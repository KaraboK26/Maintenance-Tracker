using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Project.DataLayer;

namespace Project.BusinessLayer
{
    class Service
    {
        private string service_id;
        public string Service_ID { get; set; }

        public DataTable ViewServices()
        {
            return new DataHandler().ViewServices();
        }

        public DataTable ServiceLevel()
        {
            return new DataHandler().ServiceLevel(Convert.ToInt32(Service_ID));
        }
    }
}
