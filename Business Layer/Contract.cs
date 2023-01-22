using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Project.DataLayer;

namespace Project.BusinessLayer
{
    class Contract : Call
    {
        private string contract_id;
        public string Contract_ID { get; set; }
        private string availability;
        public string Availability { get; set; }

        public DataTable ViewContracts()
        {
            return new DataHandler().ViewContracts();
        }

        public void ContractAvailability()
        {
            new DataHandler().ContractAvailability(Convert.ToInt32(Contract_ID), Availability);
        }

        public DataTable ContractPerformance()
        {
            return new DataHandler().ContractPerformance(Convert.ToInt32(Contract_ID));
        }

        public void ContractSale()
        {
            new DataHandler().ContractSale(Convert.ToInt32(Contract_ID));
        }
    }
}
