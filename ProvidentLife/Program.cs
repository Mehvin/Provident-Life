using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                Client client;
                customerSystem(client);
            }
            else if (user == "staff") // temporary way of checking of user
            {
                staffSystem(user);
            }
        }

        static void customerSystem(Client client)
        {
            Console.WriteLine("Welcome back Customer, " + client.getName() + "\n");
            bool programrun = true;

            while (programrun)
            {
                Console.WriteLine("-----Customer Tasks-----");
                Console.WriteLine("[1] View My Policies");
                Console.WriteLine("[0] Exit");

                Console.Write("Enter option: ");
                int option = Convert.ToInt32(Console.ReadLine());

                if (option == 1) // View policies
                {
                    customerViewPolicies(client);
                }
                else if (option == 0) //Exit
                {
                    programrun = false;
                }
            }
        }

        static void customerViewPolicies(Client client)
        {
            while (true)
            {
                Console.WriteLine("Your Policies");

                IPCollection ipCollection = client.getIPCollection();

                // Iterate through the policies.
                Iterator ipIterator = ipCollection.getIterator();
                while (ipIterator.hasNext())
                {
                    InsurancePolicy policy = (InsurancePolicy)ipIterator.next();

                    // Print out policy details inline.
                }

                // Get user option.
                Console.WriteLine("\n\n[1] View a policy\n[] Return home");

                Console.Write("Enter option: ");
                int option = Convert.ToInt32(Console.ReadLine());
                if (option == 1) // View policy
                {
                    // Get policy no. from user
                    int policyNo = 0;
                    while (true)
                    {
                        Console.Write("Enter policy no: ");
                        policyNo = Convert.ToInt32(Console.ReadLine());

                        if (policyNo >= 0 && policyNo <= ipCollection.getCount())
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\nInvalid Input!");
                        }
                    }

                    customerViewAPolicy(ipCollection.getPolicy(policyNo - 1));
                }
                else if (option == 0) // Return home
                {
                    break;
                }
            }
        }

        static void customerViewAPolicy(InsurancePolicy policy)
        {
            bool isRunning = false;
            while (isRunning)
            {
                // Display policy details.
                Console.WriteLine("Displaying policy details!");

                // Get outstanding premiums.
                List<Premium> premiums = policy.getPremiums();

                bool hasOutstandingPremiums = premiums.Count > 0;
                if (hasOutstandingPremiums) // Has outstanding premiums.
                {
                    Console.WriteLine("Has outstanding premiums!");

                    Console.WriteLine("\n\n[1] Pay Outstanding Premium(s)\n[0] Return home");
                }
                else // Has no outstanding premiums.
                {
                    Console.WriteLine("Has no outstanding premium!");

                    Console.WriteLine("[0] Return home");
                }

                while (true)
                {
                    Console.Write("Enter option: ");
                    int option = Convert.ToInt32(Console.ReadLine());
                    if (option == 1 && hasOutstandingPremiums) // Customer wants to pay premium using credit card.
                    {
                        customerPayCreditCard(premiums);
                        break;
                    }
                    else if (option == 0) // Return back to the list of policies
                    {
                        isRunning = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid option.");
                    }
                }
            }
        }

        static void customerPayCreditCard(List<Premium> premiums)
        {
            bool isRunning = true;
            while (isRunning)
            {
                if (premiums.Count == 0)
                {
                    Console.WriteLine("No outstanding premiums!");
                    isRunning = false;
                    break;
                }

                Console.WriteLine("Displaying a list of premiums!");

                // Get chosen premium from user.
                int premiumNo;
                while (true)
                {
                    Console.Write("Enter premium no: ");
                    premiumNo = Convert.ToInt32(Console.ReadLine());

                    if (premiumNo >= 0 && premiumNo <= premiums.Count)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid Input!");
                    }
                }

                // Retrieve premium.
                Premium premium = premiums[premiumNo - 1];


                // Get credit card info.
                Console.Write("Enter credit card no: ");
                int creditCardNo = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter CCV no: ");
                int ccv = Convert.ToInt32(Console.ReadLine());

                // Process payment
                bool paymentSuccess = CreditCardSystem.getInstance().processPayment(creditCardNo, ccv);

                if (paymentSuccess)
                {
                    premium.setPaymentType("Credit Card");
                    premium.setDateTimeOfPayment(DateTime.Now);
                }
                else
                {
                    Console.WriteLine("Payment unsuccessful!");
                }

                // Get user option if he wants to continue or return.
                while (true)
                {
                    Console.WriteLine("\n\n[1] Pay Another Outstanding Premium(s)\n[0] Return back");
                    Console.Write("Enter option: ");
                    int option = Convert.ToInt32(Console.ReadLine());
                    if (option == 1) // Pay another outstandin premium
                    {
                        isRunning = true;
                        break;
                    }
                    else if (option == 0) // Return back
                    {
                        isRunning = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid option.");
                    }
                }
            }
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

        static void createPolicy() //Done by Melvin
        {
            int moreRiders = 1;

            //Loop to get all clients and display it

            Console.Write("Select a client: ");
            int clientNo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Select premium type (1-One Time | 2-Periodic): ");
            int premiumType = Convert.ToInt32(Console.ReadLine());

            if (premiumType == 2)
            {
                Console.Write("Number of days per period: ");
                int noOfDays = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Enter maturity date: ");
            DateTime maturityDate = Convert.ToDateTime(Console.ReadLine());
            
            while (moreRiders == 1)
            {
                Console.Write("Enter in policy description: ");
                string desc = Console.ReadLine();

                Console.Write("Enter policy type: ");
                string policyType = Console.ReadLine();

                Console.Write("Enter payout amount: $");
                int payOut = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter total amount: $");
                int totalAmt = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter terms and conditions: ");
                string TnC = Console.ReadLine();

                Console.Write("Are there any more riders? (1- Yes | 2- No): ");
                moreRiders = Convert.ToInt32(Console.ReadLine());

                // Rider r = new Rider(); //create new rider here
            }

            //Display details of insurance policy

            Console.Write("Confirm to create policy? (1-Confirm | 2-Cancel): ");
            int confirm = Convert.ToInt32(Console.ReadLine());

            if (confirm == 1)
            {
                // create new policy here
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
