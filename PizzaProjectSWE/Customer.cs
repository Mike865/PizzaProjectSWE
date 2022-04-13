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
    internal class Customer
    {
        // implement setters and getters

        private static int _customerID = 0;
        public int CustomerID { get; private set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Number { get; set; }
        public string Password { get; set; }
        private string _filename;


        public Customer(string n, string a, string num, string p)
        {

            Name = n;
            Address = a;
            Number = num;
            Password = p;
            CustomerID = _customerID++;
            _filename = CustomerID.ToString() + Name;
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
