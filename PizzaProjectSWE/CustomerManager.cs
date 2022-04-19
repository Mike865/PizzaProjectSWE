using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace PizzaProjectSWE
{
    /*
     * Example JSON
     * CustomerID
     */
    [Serializable]
    internal class CustomerManager
    {

        private List<Customer> _customerList = new List<Customer>();

        /// <summary>
        /// Method utilized Packages Newtson.Json.Serialized object to convert _customerList obj into string
        /// </summary>
        /// <returns>
        /// a string that is a json representation of the method
        /// </returns>
        public string getJson()
        {
            return JsonConvert.SerializeObject(_customerList);
        }

        public CustomerManager()
        {
            ///Intialize customer with a null customer
            _customerList.Add(new Customer("null", "null", "null_num", "null", "null_user"));
        }

        /// <summary>
        /// Load Customer Information
        /// </summary>
        /// <param name="restored">
        /// restored so far is a dummy variable that tells the program to look for a CustomerInfo.txt file</param>
        public CustomerManager(bool restored)
        {

            LoadCustomerInformation();
        }

        /// <summary>
        /// Adds a new Customer object to the _customerList
        /// </summary>
        /// <param name="n">
        /// n: string representing the customer name
        /// customer.name = name
        /// </param>
        /// <param name="a">
        /// a: string representing the customer address
        /// customer.address = a
        /// </param>
        /// <param name="num">
        /// num: string representing the customer number
        /// customer.number = num
        /// </param>
        /// <param name="p">
        /// p: string representing the customer password
        /// </param>
        /// <param name="u">
        /// u: string representing the customer username 
        /// customer.username = u </param>
        /// <returns> Boolean -> true if customer was created. False if the customer wasn't created </returns>
        public Boolean addCustomer(string n, string a, string num, string p, string u)
        {
            // Add Customer to the _customerList
            foreach (Customer c in _customerList)
            {
                if (c.UserName == u || c.Number == num)
                {
                    return false;
                }
            }
            _customerList.Add(new Customer(n, a, num, p, u));
            return true;
        }

        /// <summary>
        /// Allows the customer to log in using their phone number and password
        /// </summary>
        /// <param name="num">
        /// num: string
        /// num representes their phone number see addCusteorm for more infromation </param>
        /// <param name="p">
        /// p: string
        /// p: represents their password should match </param>
        /// <returns>Customer obj: if success then a specific customer object will be returned.
        /// if generic ie null then their login attempt failed</returns>
        public Customer LogInNumber(string num, string p)
        {
            foreach ( Customer c in _customerList)
            {
                if (num == c.Number & p == c.Password)
                {
                    return c;
                }
            }
            return _customerList[0];
        }

        /// <summary>
        /// Allows the customer to log in using their phone number and password
        /// </summary>
        /// <param name="u">
        /// u: string
        /// u: representes their userName see addCusteorm for more infromation </param>
        /// <param name="p">
        /// p: string
        /// p: represents their password should match </param>
        /// <returns>Customer obj: if success then a specific customer object will be returned.
        /// if generic ie null then their login attempt failed</returns>
        public Customer LogInUserName(string u, string p)
        {
            foreach (Customer c in _customerList)
            {
                if (u == c.UserName & p == c.Password)
                {
                    return c;
                }
            }
            return _customerList[0];
        }

        /// <summary>
        /// Essentially a helper method that allows you to see if a username is present already
        /// </summary>
        /// <param name="username">
        /// username: string
        /// username: is a string that represents the customer username it'll be compared to all present usernames
        /// </param>
        /// <returns>Boolean
        ///     if true
        ///         Customer username is present
        ///     else
        ///         Customer username isn't present 
        /// </returns>
        public Boolean isCustomerPresent(string username)
        {
            /* all other attributes of the Customer don't matter*/
            foreach ( Customer c in _customerList)
            {
                if (c.UserName == username)
                {
                    return false;
                }
            }
            return true;
        }


        /// <summary>
        /// Uses getJson method located above
        /// converts that into a List(string) and writes that into a files called CustomerInfo.txt 
        /// </summary>
        public void SaveInformation()
        {
            string json = getJson();
            string[] jsonEnum = json.Split('\n');
            File.WriteAllLines("CustomerInfo.txt", jsonEnum);
        }

        /// <summary>
        /// Method is the inverse of the SaveInformation Method
        /// Creates A Ilist(Customer) 
        /// reads CustomerInfo.txt -> converts from string[] to string 
        /// reads string and depostis value info the List(Customer) [mentioned above]
        /// performs addCustomer on all Customer objects that are in List obj
        /// </summary>
        public void LoadCustomerInformation()
        {
            IList<Customer> CustomerInfo;
            string[] jsonEnum = File.ReadAllLines("CustomerInfo.txt");
            string json = String.Join("\n", jsonEnum);
            JsonTextReader r = new JsonTextReader(new StringReader(json));
            r.SupportMultipleContent = true;

            if (!r.Read())
            {
                //Thinking of making the program throw an exception here
                Console.WriteLine("Something went wrong");
                return;
            }
            JsonSerializer s = new JsonSerializer();
            CustomerInfo = JsonConvert.DeserializeObject<IList<Customer>>(json);
            foreach (Customer customer in CustomerInfo)
            {
                addCustomer(customer.Name, customer.Address, customer.Number, customer.Password, customer.UserName);
            }


        }

        /// <summary>
        /// Internal class that provides a blueprint for the customer class
        /// setters and getters implemented for:
        ///     - CustomerID
        ///     - Name
        ///     - Address
        ///     - Number
        ///     - Password
        ///     - UserName
        /// </summary>
        internal class Customer
        {
            private static int _customerID = 0;
            public int CustomerID { get; private set; }
            public string Name { get; set; }
            public string Address { get; set; }
            public string Number { get; set; }
            public string Password { get; set; }
            public string UserName { get; set; }

            public PaymentInformation _pi;

            /// <summary>
            /// allows payment information to be saved 
            /// </summary>
            /// <param name="c">
            /// c: string
            /// c: represents the card number for customers</param>
            /// <param name="e">
            /// e: string
            /// e: represents the card expirationd date for customer payment information </param>
            public void setPaymentInfo(string c, string e)
            {
                _pi = new PaymentInformation(c, e);
                return;

            }

            private const string _filename = "CustomerInfo.txt";
            
            /// <summary>
            /// Constructor for customer object
            /// </summary>
            /// <param name="n"></param>
            /// <param name="a"></param>
            /// <param name="num"></param>
            /// <param name="p"></param>
            /// <param name="u"></param>
            public Customer(string n, string a, string num, string p, string u)
            {

                Name = n;
                Address = a;
                Number = num;
                Password = p;
                CustomerID = _customerID++;
                UserName = u;
            }
            public class PaymentInformation
            {
                public string cardNumber = "";
                public string expDate = "";
                public PaymentInformation(string c, string e)
                {
                    cardNumber = c;
                    expDate = e;
                }
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
