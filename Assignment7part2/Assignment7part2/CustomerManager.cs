/* Assignment 7 part II - by ...KaiserDMC...
   Current date: 2021-01-04
   Date of submission: 2020-01-05 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7part2
{
    //Manager class used to store all customers inside a list of Customers by utilizing the methods inside it
    class CustomerManager
    {
        private List<Customer> m_customers; //A list of Customers to store the customers

        public CustomerManager() //Initialization of the Manager
        {
            m_customers = new List<Customer>(); //Initialization of the array/list
        }

        public int Count //Property to find the count of the customers inside the list
        {
            get { return m_customers.Count; }
        }

        public bool CheckIndex(int index) //Index check... To make sure we are not out of range
        {
            bool goodIndex = false;
            if ((index >= 0) && index <= m_customers.Count)
                goodIndex = true;
            return goodIndex;
        }

        public bool AddCustomer(Customer customerIn) //Add a customer to the manager
        {
            m_customers.Add(customerIn); //Add a customer to the manager list
            return true;
        }

        public bool ChangeCustomer(Customer customerIn, int index) //Find the position where a task is to be changed/edited
        {
            bool edit = true;
            if (CheckIndex(index))
            {
                var currentCustomer = m_customers[index];
                currentCustomer.ContactData = customerIn.ContactData;
                currentCustomer.ID = customerIn.ID;
            }
            else
                edit = false;
            return edit;
        }

        public bool DeleteCustomer(int index) //Find the position where a customer is to be deleted
        {
            bool delete = true;
            if (CheckIndex(index))
                m_customers.RemoveAt(index);
            else
                delete = false;
            return delete;
        }

        public string[] GetCustomersInfo() //Convert all items inside the list to an array of strings
        {
            string[] customersAsString = new string[m_customers.Count];
            for (int i = 0; i < m_customers.Count; i++)
            {
                if (m_customers[i] == null)
                    break;

                customersAsString[i] = m_customers[i].ToString();
            }

            return customersAsString;
        }

        public Customer GetCustomer(int index) //Get a customer at certain index
        {
            return m_customers[index];
        }

        public List<Customer> GetCustomerRecords() //Get all customers, used to clear the manager
        {
            return m_customers;
        }

        public string GetNewID() //Get a ID for the customer, with custom format
        {
            const string startID = "K"; //"K" stands for Kontroll
            return startID + (m_customers.Count + 1).ToString();
        }
    }
}
