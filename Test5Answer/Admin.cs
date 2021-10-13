using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test5Answer
{
    class Admin
    {
        //instead of looping through the whole list, 
        //using Dict allows u to easily locate with a key
        Dictionary<string, Customer> dictOfCustomer = new Dictionary<string, Customer>();

        public Admin()
        {
            if (!File.Exists("Banking_Details.txt"))
            {
                Console.WriteLine("File Doesnt exist");
                return;
            }

            FileStream fs = new FileStream("Banking_Details.txt", FileMode.Open, FileAccess.Read);
            fs.Seek(0, SeekOrigin.Begin);
            StreamReader sr = new StreamReader(fs);

            string str = sr.ReadLine();
            while(str != null)
            {
                var strArray = str.Split('_');
                //changeing double acct balance
                var account_bal = double.Parse(strArray[3]);
                //changing boolean loan applied
                var loan_app = bool.Parse(strArray[5]);

                var customer = new Customer(strArray[0], strArray[1], strArray[4], account_bal, loan_app);

                if (!dictOfCustomer.ContainsKey(strArray[0]))
                {
                    dictOfCustomer.Add(strArray[0], customer);
                }

                str = sr.ReadLine();

            }
            sr.Close();
            fs.Close();
        }

        public void PerformOperation()
        {
            bool user_exited = false;
            while (!user_exited)
            {
                Console.WriteLine("Select Option");
                Console.WriteLine("1) Create Account");
                Console.WriteLine("2) Withdraw from Account");
                int user_option = Int32.Parse(Console.ReadLine());

                switch (user_option)
                {
                    case 1:
                        {
                            var new_cust = HandleAccountOpening.CreateCustomerAccount();
                            if(new_cust != null)
                            {
                                if (!dictOfCustomer.ContainsKey(new_cust.customer_id))
                                {
                                    dictOfCustomer.Add(new_cust.customer_id, new_cust);
                                }
                                else
                                {
                                    Console.WriteLine("Data already exist");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Failed.");
                            }

                            break;
                        }
                    case 2:
                        {
                            var user_id = Console.ReadLine();
                            var customer = dictOfCustomer[customer_id];
                            break;
                        }
                        case 4:
                        {
                            WriteAllTransactionsinFile();
                            user_exited = true;
                            break;
                        }

                }
            }

        }

        private void WriteAllTransactionsinFile()
        {
            //override existing file
            //write content of dic in file 

        }
    }
}
