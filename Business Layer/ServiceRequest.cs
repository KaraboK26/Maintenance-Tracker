using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Project.DataLayer;

namespace Project.BusinessLayer
{
    class ServiceRequest
    {
        private string request_id;
        public string Request_ID { get; set; }
        private string service_id;
        public string Service_ID { get; set; }
        private string client_id;
        public string Client_ID { get; set; }

        public DataTable ViewRequests()
        {
            return new DataHandler().ViewRequests();
        }

        public void NewRequest()
        {
            new DataHandler().NewRequest(Convert.ToInt32(Client_ID),Convert.ToInt32(Service_ID));
        }

        public void RemoveRequest()
        {
            new DataHandler().RemoveRequest(Convert.ToInt32(Request_ID));
        }
    }
}
