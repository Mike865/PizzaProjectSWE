using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace PizzaProjectSWE
{
    /*
     * Example JSON
     * CustomerID
     */
    [Serializable]
    internal class CustomerManager
    {
        // implement setters and getters
        // methods are not tested


        private List<Customer> _customerList = new List<Customer>();

        public void newCustmer(string n, string a, string num, string p, string u)
        {
            _customerList.Add(new Customer(n, a, num, p, u));
        }

        public Boolean LogInNumber(string num, string p)
        {
            foreach ( Customer c in _customerList)
            {
                if (num == c.Number & p == c.Password)
                {
                    return true;
                }
            }
            return false;
        }

        public Boolean LogInUserName(string u, string p)
        {
            foreach (Customer c in _customerList)
            {
                if (u == c.UserName & p == c.Password)
                {
                    return true;
                }
            }
            return false;
        }


        internal class Customer
        {
            private static int _customerID = 0;
            public int CustomerID { get; private set; }
            public string Name { get; set; }
            public string Address { get; set; }
            public string Number { get; set; }
            public string Password { get; set; }
            public string UserName { get; set; }
            private string _filename;
            public Customer(string n, string a, string num, string p, string u)
            {

                Name = n;
                Address = a;
                Number = num;
                Password = p;
                CustomerID = _customerID++;
                UserName = u;
                _filename = CustomerID.ToString() + Name;
            }
        }


        //public bool saveInfo()
        //{
        //    Console.WriteLine(System.IO.Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath));
        //    File f = new File(_filename);
        //    Stream str = f.Open(FileMode.Create);
        //    BinaryFormatter bf = new BinaryFormatter();
        //    bf.Serialize(str, this);
        //    str.Close();
        //    return true;
        //}

        public class PaymentMethods
        {

        }
    }
}
