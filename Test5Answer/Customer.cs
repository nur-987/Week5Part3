using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test5Answer
{
    /// <summary>
    /// use _ so that when it gets into the txtFile, u can separate the string using the _
    /// </summary>
    class Customer
    {
        //string id => to accomodate letters in the string 
        public string customer_id { get; private set; }
        public string customer_name { get; private set; }
        public string account_number { get; private set; }
        public double account_balance { get; private set; }
        public string check_book_number { get; private set; }
        public bool loan_applied { get; set; }
        public Customer(string id, string name, string account_no, double bal, string check_book_num)
        {
            customer_id = id;
            customer_name = name;
            account_number = account_no;
            account_balance = bal;
            check_book_number = check_book_num;
            loan_applied = false;

        }

        public override string ToString()
        {
            //put in correct return!
            return base.ToString();
        }


    }
}
