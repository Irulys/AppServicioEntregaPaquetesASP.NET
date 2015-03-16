using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace App.Modelo
{
    public class Bills
    {
        private long id;
        private DateTime date;
        private Person customers;
        protected Dictionary<Package, double> items = new Dictionary<Package, double>();
        protected long val = 0;


        public long Id
        {
            get { return id; }
            set { id = val++; }
        }
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        public Person Customers
        {
            get { return customers; }
            set { customers = value; }
        }


    }
}