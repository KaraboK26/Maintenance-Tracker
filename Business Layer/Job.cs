using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Project.DataLayer;

namespace Project.BusinessLayer
{
    class Job
    {
        private string job_id;
        public string Job_ID { get; set; }
        private string service_id;
        public string Service_ID { get; set; }
        private string client_id;
        public string Client_ID { get; set; }
        private string technician_id;
        public string Technician_ID { get; set; }
        private string priority;
        public string Priority { get; set; }


        public DataTable ViewJobs()
        {
            return new DataHandler().ViewJobs();
        }

        public void NewJob()
        {
            new DataHandler().NewJob(Priority,Convert.ToInt32(Technician_ID),Convert.ToInt32(Client_ID),Convert.ToInt32(Service_ID));
        }

        public void CloseJob()
        {
            new DataHandler().CloseJob(Convert.ToInt32(Job_ID));
        }

        public DataTable TrackJob()
        {
            return new DataHandler().TrackJob(Convert.ToInt32(Job_ID));
        }

        public void EscalateJob()
        {
            new DataHandler().EscalateJob(Convert.ToInt32(Job_ID),Priority);
        }

        public void ReassignJob()
        {
            new DataHandler().ReassignJob(Convert.ToInt32(Job_ID),Convert.ToInt32(Technician_ID));
        }
    }
}
