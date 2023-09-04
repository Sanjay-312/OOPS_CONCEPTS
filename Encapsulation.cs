using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concepts
{
    internal class Bank
    {
        public long accountNumber;
        public string name;
        public int balance;

        public void getBalance()
        {
            Console.WriteLine("get balance method called");
        }
        public void withdraw()
        {
            Console.WriteLine("withdraw  method called");
        }
        public void deposit()
        {
            Console.WriteLine("depoist method called");
        }
    }
    internal class Laptop
    {
        private string model;

        public void setModel(string model)
        {
            this.model = model;
        }

        public string getModel()
        {
            return model;
        }
    }
    internal class Mobile
    {
        private int cost;

        public int price
        {
            get { return cost; }
            set { cost = value; }
        }
    }

}
