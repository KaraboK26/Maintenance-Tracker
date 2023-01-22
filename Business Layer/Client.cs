using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Project.DataLayer;

namespace Project.BusinessLayer
{
    class Client 
    {
        private string client_id;
        public string Client_ID { get; set; }
        private string name;
        public  string Name { get; set; }
        private string surname;
        public string Surname { get; set; }
        private string contract_id;
        public string Contract_ID { get; set; }
        private string address;
        public string Address { get; set; }
        private string phonenumber;
        public string Phonenumber { get; set; }
        private string client_type;
        public string Client_Type { get; set; }

        public DataTable ViewClients()
        {
            return new DataHandler().ViewClients();
        }

        public void AddClient()
        {
            new DataHandler().AddClient(Name,Surname,Phonenumber,Address,Client_Type,Convert.ToInt32(Contract_ID));
        }

        public void DeleteClient()
        {
            new DataHandler().DeleteClient(Convert.ToInt32(Client_ID));
        }

        public DataTable SearchClient()
        {
            return new DataHandler().SearchClient(Convert.ToInt32(Client_ID));
        }

        public void UpdateClient()
        {
            new DataHandler().UpdateClient(Convert.ToInt32(Client_ID),Name, Surname, Phonenumber, Address, Client_Type,Convert.ToInt32(Contract_ID));
        }

        public DataTable ClientAgreement()
        {
            return new DataHandler().ClientAgreement(Convert.ToInt32(Client_ID));
        }

    }
}
