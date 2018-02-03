using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProvidentLife.Classes;

namespace ProvidentLife
{
    class Program
    {
        static void Main(string[] args)
        {
            string user;
             
            Console.WriteLine("----Provident Life System----");
            Console.Write("Username: ");
            user = Console.ReadLine();
            Console.WriteLine("");

            // check user type
            if (user == "customer") // temporary way of checking of user
            {
                customerSystem(user);
            }
            else if (user == "staff") // temporary way of checking of user
            {
                staffSystem(user);
            }
        }

        static void customerSystem(string user)
        {
            Console.WriteLine("Welcome back Customer, " + user + "\n");
            bool programrun = true;

            while (programrun)
            {
                Console.WriteLine("-----Customer Tasks-----");
                Console.WriteLine("[1] View Policy");
                Console.WriteLine("[0] Exit");

                Console.Write("Enter option: ");
                int option = Convert.ToInt32(Console.ReadLine());

                if (option == 1) //View policy
                {
                    //view own policies
                    //customerViewPolicy();
                }
                else if (option == 0) //Exit
                {
                    programrun = false;
                }
            }
        }

        static void customerViewPolicy()
        {

        }

        static void staffSystem(string user)
        {
            Console.WriteLine("Welcome back Staff, " + user + "\n");
            bool programrun = true;

            while (programrun)
            {
                Console.WriteLine(@"
-----Staff Tasks-----
[1] Create New Policy
[2] View Policy 
[3] Edit Policy
[0] Exit"); // if user = admin show all , if user != admin show their own policies only
                Console.Write("Enter option: ");
                int option = Convert.ToInt32(Console.ReadLine());

                if (option == 1) //Create new policy
                {
                    createPolicy();
                }
                else if (option == 2) //View policy
                {
                    //Selects policy number
                    //display policy menu
                    //staffViewPolicy();
                }
                else if (option == 0) //Exit
                {
                    programrun = false;
                }
            }
        }

        static void createPolicy()
        {
            //Loop to get all clients and display it

            Console.Write("Select a client: ");
            int clientNo = Convert.ToInt32(Console.ReadLine());

            //Loop to get list of policy types and display it

            Console.Write("Select a policy type: ");
            int policyType = Convert.ToInt32(Console.ReadLine());

            Console.Write("Select premium type(1-One Time| 2-Periodic): ");
            int premiumType = Convert.ToInt32(Console.ReadLine());

            if (premiumType == 2)
            {
                Console.Write("Number of days per period: ");
                int noOfDays = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Enter total amount: $");
            int totalAmt = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter maturity date: ");
            DateTime maturityDate = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Enter no. of additional riders: ");
            int addRiders = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter terms and conditions: ");
            string TnC = Console.ReadLine();

            //Display details of insurance policy

            Console.Write("Confirm to create policy? (1-Confirm | 2-Cancel): ");
            int confirm = Convert.ToInt32(Console.ReadLine());

            if (confirm == 1)
            {
                // create new policy
                Console.WriteLine("Policy created!");
            }
        }

        static void staffViewPolicy()
        {
            //check if user is admin

            //if admin
            //display ALL policies

            //if not admin
            //display polcies that belongs to him

            //add transaction to edit policy (sterling's)
            //add transaction to generate alerts (bryan's)
        }

        static void DisplayPolicyMenu()
        {
            Console.WriteLine("\n1. Generate Alerts");
            Console.WriteLine("2. Edit Policy");
        }

        static void editPolicy()
        {

        }

        static void generateAlerts()
        {

        }
    }
}
