using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace PizzaProjectSWE
{
    /*
     * Example JSON
     * CustomerID
     */
    [Serializable]

    public class CustomerManager
    {
        /// <summary>
        /// _Customer list is a list of type customer
        /// </summary>
        public List<Customer> _customerList { get; set; }
        /// <summary>
        /// currentCustomer provides a means of selecting a customer from the customerList
        /// </summary>
        public Customer currentCustomer { get; set; }
        /// <summary>
        /// GetJson takes no objectsand returns string the string is a list of customer object with all atributes 
        /// </summary>
        /// <returns></returns>
        public string GetJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        /// <summary>
        /// the CustomerManager Constructor takes no arguments and calls the 
        /// initObjs function
        /// it alos checks for customer informaiton and if there is none it creats the intial customer
        /// </summary>
        public CustomerManager()
        {
            initObjects();
            if (!CheckforCustomerInfo())
            {
                addCustomer("null_name", "null_address", "number_num", "password", "someuserName", "1234CardNum", "01/2023Date");
            }
        }
        // Going to remove all objs with 0 references after testing
        public CustomerManager(bool DEBUG)
        {
            initObjects();
            LoadCustomerInformation();
        }

        /// <summary>
        /// Returns a customerObj corresponding to the index I
        /// </summary>
        /// <param name="i">
        /// i: int and could be between 0 and CustomerList.Count - 1 inclusive.
        /// </param>
        /// <returns>
        /// returns _customerList[i]
        /// </returns>
        public Customer GetCustomerObj(int i)
        {
            if (i < 0 || i > _customerList.Count - 1)
            {
                return _customerList[0];
            }
            return _customerList[i];
        }

        /// <summary>
        /// sets currentCustomer obj and returns if login succeeded or not
        /// </summary>
        /// <param name="u">
        /// u: username: string: the username of the customer object inside of the customer list</param>
        /// <param name="p">
        /// p: password: string: the string belonging to the customer profile
        /// </param>
        /// <returns>
        /// bool: if true login succeeded else login did not succeed and the currentcustomerobj is set to null
        /// </returns>
        public bool LogInUserName(string u, string p)
        {
            //changed return types 
            foreach (Customer c in _customerList)
            {
                if (u == c.UserName & p == c.Password)
                {
                    currentCustomer = c;
                    return true;
                }
            }

            currentCustomer = GetCustomerObj(0);
            return false;
        }

        /// <summary>
        /// sets current customer obj and returns t/F if login succeded or not
        /// </summary>
        /// <param name="num">
        /// num: number: string the string of the profile number that belows to the customer object
        /// </param>
        /// <param name="p">
        /// p: password: string: the string belonging to the customer profile
        /// </param>
        /// <returns>
        /// bool: if true login succeeded else login did not succeed and the currentcustomerobj is set to null
        /// </returns>
        public bool LogInNumber(string num, string p)
        {
            foreach (Customer c in _customerList)
            {
                if (num == c.Number & p == c.Password)
                {
                    currentCustomer = c;
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// sets internal currentcustomer to a particular integer DEBUG ONLY
        /// </summary>
        /// <param name="CustomerIndex">
        /// CustomerIndex: int: the index from 0 - customerList.Count - 1 inclusive
        /// </param>
        public void SetCustomer(int CustomerIndex)
        {
            if (CustomerIndex > _customerList.Count - 1 || _customerList.Count < 0)
            {
                Console.WriteLine("That customer isn't in the list");
            }
            currentCustomer = _customerList[CustomerIndex];
            Console.WriteLine("Customer is Set");
        }

        /// <summary>
        /// sets internal currentcustomer to null DEBUG ONLY
        /// </summary>
        /// <param name="CustomerIndex">
        /// </param>
        public void SetCustomerNull()
        {
            currentCustomer = null;
        }

        //public void addCustomer()
        //{
        //    _customerList.Add(new Customer());
        //}
        //removing after function verification ^^

        /// <summary>
        /// initializes the customerList
        /// </summary>
        public void initObjects()
        {
            _customerList = new List<Customer>();
        }
        /// <summary>
        /// writes information to txt.file located next to exe
        /// </summary>
        public void SaveInformation()
        {
            string json = GetJson();
            string[] jsonEnum = json.Split('\n');
            File.WriteAllLines("CustomerInfo.txt", jsonEnum);
        }
        /// <summary>
        /// a funciton that checks to see if CustomerInfo.txt Exists
        /// </summary>
        /// <returns></returns>
        public bool CheckforCustomerInfo()
        {
            return File.Exists("CustomerInfo.txt");
        }
        /// <summary>
        /// Actually performs the work to read the customer list and enable it to be used by the CustomerManager - helps manage persistence
        /// </summary>
        public void LoadCustomerInformation()
        {
            Customer selectedCustomer;
            CustomerManager CustomerInfo = new CustomerManager();
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
            CustomerInfo = JsonConvert.DeserializeObject<CustomerManager>(json);
            _customerList = CustomerInfo._customerList;

        }
        /// <summary>
        /// Func to assist with the customer obj creation
        /// </summary>
        /// <param name="name">
        /// name: string: the customer name</param>
        /// <param name="addr">
        /// addr: address: string: the address belonging to the customer</param>
        /// <param name="num">
        /// num: number: string: the phone number belonging to the customer</param>
        /// <param name="pass">
        /// pass: password: string: the password to the customer account</param>
        /// <param name="username">
        /// username: string: a username string belonging to the customer</param>
        /// <param name="CardNumber">
        /// cardnumber: string the card number to be charged when purchasing</param>
        /// <param name="ExpDate">
        /// ExpDate: Expiration Date: string: the Expiration date that is paired with the card number</param>
        /// <returns>returns the enwly created customer obj</returns>
        public Customer addCustomer(string name, string addr, string num, string pass, string username, string CardNumber = null, string ExpDate = null)
        {
            _customerList.Add(new Customer(name, addr, num, pass, username, CardNumber, ExpDate));
            return _customerList[_customerList.Count - 1];
        }
        /// <summary>
        /// Customer Class definition to the Customer list can be made
        /// </summary>
        public class Customer
        {
            /// <summary>
            /// allows the JSonConvert to read the customer
            /// </summary>
            [JsonProperty("Customer")]
            /// counter for customer orders
            private static int _customerOrderCounter = 0;
            /// <summary>
            /// string: Name of customer
            /// </summary>
            public string Name { get; set; }
            /// <summary>
            /// string: Address of customer
            /// </summary>
            public string Address { get; set; }
            /// <summary>
            /// string: Number of customer
            /// </summary>
            public string Number { get; set; }
            /// <summary>
            /// string: Password of customer
            /// </summary>
            public string Password { get; set; }
            /// <summary>
            /// string: Username of customer
            /// </summary>
            public string UserName { get; set; }
            /// <summary>
            /// int: currentOrder counter
            /// </summary>
            private int _currentOrder { get; set; }
            /// <summary>
            /// List<Order>: internal list of orders for all customers
            /// </summary>
            public List<Order> Orders { get; set; }
            /// <summary>
            /// PaymentInformation: payment information belonging to customer
            /// </summary>
            public PaymentInformation PaymentInfo { get; set; }
            /// <summary>
            /// takes a list of food and enables customer to add that 'Food' to their order
            /// </summary>
            /// <param name="foods">
            /// List(Food): Food is an object found in FoodCS 
            /// </param>
            public void Checkout(List<Food> foods)
            {
                Orders.Add(new Order(foods));
                Orders[_currentOrder].GetTotal();
            }
            /// <summary>
            /// returns this as a json object. Likely for debug
            /// </summary>
            /// <returns></returns>
            public string GetJson()
            {
                return JsonConvert.SerializeObject(this);
            }
            /// <summary>
            /// Provides a way to get the most recent order
            /// </summary>
            /// <returns></returns>
            public string GetRecentOrder()
            {
                if (Orders.Count == 0)
                {
                    return "No orders present";
                }
                return JsonConvert.SerializeObject(Orders[_currentOrder--]);
            }
            /// <summary>
            /// empty Customer constructor: inits all local non primitive objects
            /// </summary>
            public Customer()
            {
                initObjects();
            }

            // Will delete after verification testing
            //public Customer(string f, string l, string attr)
            //{
            //    initObjects();
            //    fname = f;
            //    lname = l;
            //    this.attr = attr;
            
            /// <summary>
            /// Customer contructor sets all variables and initsObjs -> creating all nonprimitive objects
            /// </summary>
            /// <param name="name">
            /// name: string: name of the customer</param>
            /// <param name="addr">
            /// addr: address: string: address of the customer</param>
            /// <param name="num">
            /// num: number: string: number for the customer</param>
            /// <param name="pass">
            /// pass: password: string: password for the customer</param>
            /// <param name="username">
            /// username: string: username for the customer</param>
            /// <param name="CardNumber">
            /// cardnumber: string: cardnumber for users</param>
            /// <param name="ExpDate">
            /// ExpDate: Expiration Date: string: Expiration date belonging to the CardNumber mentioned above</param>
            public Customer(string name, string addr, string num, string pass, string username, string CardNumber = null, string ExpDate = null)
            {
                initObjects();
                Name = name;
                Address = addr;
                Number = num;
                Password = pass;
                UserName = username;
                if (CardNumber != null && ExpDate != null)
                {
                    PaymentInfo.CardNumber = CardNumber;
                    PaymentInfo.ExpDate = ExpDate;
                }
            }
            /// <summary>
            /// inits customer order counter and all other non primitive objects
            /// </summary>
            public void initObjects()
            {
                Orders = new List<Order>();
                PaymentInfo = new PaymentInformation();
                _currentOrder = 0;

            }
            /// <summary>
            /// adds a list of food to the orde 
            /// </summary>
            /// <param name="food">
            /// A list consisting of Food an object specific to this assembly
            /// </param>
            public void addOrder(List<Food> food)
            {
                //Orders.Add(new Order(food));
                Checkout(food);
                _currentOrder++;
            }
            //public void addOrder(string[] food)
            //{
            //    Orders.Add(new Order(food));
            //    Checkout();
            //    _currentOrder++;
            //}
            /// <summary>
            /// internal class for payment ifnormation provides 
            /// </summary>
            public class PaymentInformation
            {
                [JsonProperty("PaymentInformation")]
                /// string holds Cardnumber
                public string CardNumber { get; set; }
                /// <summary>
                /// string holwds Expiration date for PaymentInfomation
                /// </summary>
                public string ExpDate { get; set; }
                /// <summary>
                /// constructor for the paymentinformation
                /// </summary>
                /// <param name="c">
                /// c: cardnumber: string: users cardnumber</param>
                /// <param name="e">
                /// e: expirationDate: string: users Expiration Date</param>
                public PaymentInformation(string c, string e)
                {
                    CardNumber = c;
                    ExpDate = e;
                }
                /// <summary>
                /// Empty Json object
                /// </summary>
                public PaymentInformation()
                {
                }
                /// <summary>
                /// gets Json obj as string
                /// </summary>
                /// <returns>
                /// (this) as json </returns>
                public string GetJson()
                {
                    return JsonConvert.SerializeObject(this);
                }
            }
            /// <summary>
            /// creates Order Object to be used in customer object
            /// </summary>
            public class Order
            {
                [JsonProperty("Orders")]
                
                /// creates ordernumber object
                public int OrderNumber { get; set; }
                /// <summary>
                /// creates orderTotal primitive
                /// </summary>
                public double OrderTotal { get; set; }
                /// <summary>
                /// creates an internal list of FoodItems for the Order
                /// </summary>
                public List<Food> FoodItems { get; set; }
                /// <summary>
                /// Empty constructors calls initObjects
                /// </summary>
                public Order()
                {

                    initObjects();
                }
                /////  likely to delete all below if program functions normally
                //<summary>
                ///// order Con
                ///// </summary>
                ///// <param name="Desc"></param>
                ///// <param name="cat"></param>
                ///// <param name="cost"></param>
                //public Order(string Desc, MenuCategory cat, double cost)
                //{
                //    initObjects();
                //    FoodItems.Add(new Food(Desc, cat, cost));
                //}
                //public Order(Food food)
                //{
                //    initObjects();
                //}

                /// <summary>
                /// Order Constructor
                /// </summary>
                /// <param name="food">
                /// food: Food[]: is an array of food</param>
                //public Order(Food[] food)
                //{
                //    initObjects();
                //    foreach (Food f in food)
                //    {
                //        FoodItems.Add(f);
                //    }
                //}

                /// <summary>
                /// adds food to order
                /// </summary>
                /// <param name="foods">
                /// food: List<Food>: a food object to add to order</param>
                public Order(List<Food> foods)
                {
                    initObjects();
                    foreach (Food f in foods)
                    {
                        FoodItems.Add(f);
                    }
                }
                /// <summary>
                /// adds food to order
                /// </summary>
                /// <param name="food">
                /// food: Food: a food object to add to order</param>
                public void addFood(Food food)
                {
                    
                }

                /// <summary>
                /// inits all objs the food list OrderNumber and Order Total
                /// </summary>
                public void initObjects()
                {
                    OrderNumber = _customerOrderCounter++;
                    FoodItems = new List<Food>();
                    OrderTotal = 0;
                }
                /// <summary>
                /// Gets total for food in order
                /// </summary>
                /// <returns>a double that's the totoal for all food</returns>
                public double GetTotal()
                {
                    foreach (Food f in FoodItems)
                    {
                        OrderTotal += f.cost;
                    }
                    return OrderTotal;
                }
            }
        }

    }
}