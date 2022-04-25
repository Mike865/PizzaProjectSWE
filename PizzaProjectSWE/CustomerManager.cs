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
        public List<Customer> _customerList { get; set; }
        public Customer currentCustomer { get; set; }
        //private int _customerCounter { get; set; }
        public string GetJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        public CustomerManager(string s)
        {
            initObjects();
        }

        public CustomerManager()
        {
            initObjects();
            if (!CheckforCustomerInfo())
            {
                addCustomer("null_name", "null_address", "number_num", "password", "someuserName", "1234CardNum", "01/2023Date");
            }
        }
        public CustomerManager(bool DEBUG)
        {
            initObjects();
            LoadCustomerInformation();
        }

        public Customer GetCustomerObj(int i)
        {
            if (i < 0 || i > _customerList.Count - 1)
            {
                return _customerList[0];
            }
            return _customerList[i];
        }

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
            return false;
        }

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

        public void SetCustomer(int CustomerIndex)
        {
            if (CustomerIndex > _customerList.Count - 1 || _customerList.Count < 0)
            {
                Console.WriteLine("That customer isn't in the list");
            }
            currentCustomer = _customerList[CustomerIndex];
            Console.WriteLine("Customer is Set");
        }
        public void SetCustomerNull()
        {
            currentCustomer = null;
        }

        //public void addCustomer()
        //{
        //    _customerList.Add(new Customer());
        //}

        public void initObjects()
        {
            _customerList = new List<Customer>();
        }
        public void SaveInformation()
        {
            string json = GetJson();
            string[] jsonEnum = json.Split('\n');
            File.WriteAllLines("CustomerInfo.txt", jsonEnum);
        }
        public bool CheckforCustomerInfo()
        {
            return File.Exists("CustomerInfo.txt");
        }

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
        public Customer addCustomer(string name, string addr, string num, string pass, string username, string CardNumber = null, string ExpDate = null)
        {
            _customerList.Add(new Customer(name, addr, num, pass, username, CardNumber, ExpDate));
            return _customerList[_customerList.Count - 1];
        }
        public class Customer
        {
            [JsonProperty("Customer")]
            private static int _customerOrderCounter = 0;
            public string Name { get; set; }
            public string Address { get; set; }
            public string Number { get; set; }
            public string Password { get; set; }
            public string UserName { get; set; }
            private int _currentOrder { get; set; }
            public List<Order> Orders { get; set; }
            public PaymentInformation PaymentInfo { get; set; }

            public void Checkout(List<Food> foods)
            {
                Orders.Add(new Order(foods));
                Orders[_currentOrder].GetTotal();
            }

            public string GetJson()
            {
                return JsonConvert.SerializeObject(this);
            }
            public string GetRecentOrder()
            {
                if (Orders.Count == 0)
                {
                    return "No orders present";
                }
                return JsonConvert.SerializeObject(Orders[_currentOrder--]);
            }

            public Customer()
            {
                initObjects();
            }

            //public Customer(string f, string l, string attr)
            //{
            //    initObjects();
            //    fname = f;
            //    lname = l;
            //    this.attr = attr;
            //}

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

            public void initObjects()
            {
                Orders = new List<Order>();
                PaymentInfo = new PaymentInformation();
                _currentOrder = 0;

            }
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
            public class PaymentInformation
            {
                [JsonProperty("PaymentInformation")]
                public string CardNumber { get; set; }
                public string ExpDate { get; set; }
                public PaymentInformation(string c, string e)
                {
                    CardNumber = c;
                    ExpDate = e;
                }
                public PaymentInformation()
                {
                }
                public string GetJson()
                {
                    return JsonConvert.SerializeObject(this);
                }
            }
            public class Order
            {
                [JsonProperty("Orders")]

                public int OrderNumber { get; set; }
                public double OrderTotal { get; set; }
                public List<Food> FoodItems { get; set; }
                public Order()
                {

                    initObjects();
                }
                public Order(string Desc, MenuCategory cat, double cost)
                {
                    initObjects();
                    FoodItems.Add(new Food(Desc, cat, cost));
                }
                public Order(Food food)
                {
                    initObjects();
                }
                public Order(Food[] food)
                {
                    initObjects();
                    foreach (Food f in food)
                    {
                        FoodItems.Add(f);
                    }
                }
                public Order(List<Food> foods)
                {
                    initObjects();
                    foreach (Food f in foods)
                    {
                        FoodItems.Add(f);
                    }
                }
                public void addFood(Food food)
                {
                    
                }

                public void initObjects()
                {
                    OrderNumber = _customerOrderCounter++;
                    FoodItems = new List<Food>();
                    OrderTotal = 0;
                }
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