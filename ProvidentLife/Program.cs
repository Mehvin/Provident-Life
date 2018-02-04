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
            List<Client> clientList = new List<Client>();
            List<Employee> employeeList = new List<Employee>();
            List<InsurancePolicy> policyList = new List<InsurancePolicy>();

            initialiseClientList(clientList);
            initialiseEmployeeList(employeeList);
            initialisePolicyList(policyList, employeeList, clientList);

            string user;
            Client loggedInClient; //this is the client that logged in
            Employee loggedInEmployee; //this is the employee that logged in

            Console.WriteLine("----Provident Life System----");
            Console.Write("Username: ");
            user = Console.ReadLine();
            Console.WriteLine("");
            
            // check user type
            for (int i = 0; i < clientList.Count; i++)
            {
                if (clientList[i].getName() == user)
                {
                    loggedInClient = clientList[i];
                    customerSystem(loggedInClient);
                }
            }

            for (int i = 0; i < employeeList.Count; i++)
            {
                if (employeeList[i].getName() == user)
                {
                    loggedInEmployee = employeeList[i];
                    staffSystem(user, clientList, loggedInEmployee, policyList);
                }
            }
        }

        static void initialiseClientList(List<Client> cList)
        {
            Client c1 = new Client("Melvin", 1, "Bukit Timah");
            Client c2 = new Client("Fad", 2, "Jurong");
            Client c3 = new Client("Shaz", 3, "Boon Lay");
            Client c4 = new Client("Sterling", 4, "Holland V");
            Client c5 = new Client("Bryan", 5, "AMK");

            cList.Add(c1);
            cList.Add(c2);
            cList.Add(c3);
            cList.Add(c4);
            cList.Add(c5);
        }

        static void initialiseEmployeeList(List<Employee> eList)
        {
            Employee e1 = new Employee(1, "Mr Oon", "Senior", true, new SeniorPayStrategy());
            Employee e2 = new Employee(2, "Mrs Oon", "Senior", false, new SeniorPayStrategy());
            Employee e3 = new Employee(3, "Mr Tan", "Junior", false, new JuniorPayStrategy());

            eList.Add(e1);
            eList.Add(e2);
            eList.Add(e3);
        }

        static void initialisePolicyList(List<InsurancePolicy> pList, List<Employee> eList, List<Client> cList)
        {
            List<string> baseTnC = new List<string>();

            baseTnC.Add("Need to pay on time");
            baseTnC.Add("Cancel policy, will need to pay fee");
            baseTnC.Add("Penalty will need to be fully paid before a lapsed policy can become ongoing");

            DateTime startDateTime = new DateTime(2018, 1, 4);
            DateTime maturedDateTime = new DateTime(2020, 1, 4);

            List<Rider> riderList = new List<Rider>();
            Rider r1 = new Rider(0, "Life", "Base policy - life insurance", 1000000.00, 100000.00, new PercentagePayoutStrategy());
            Rider r2 = new Rider(1, "Medical", "Additional policy #1 - loss of a leg", 10000.00, 1000.00, new LumpSumPayoutStrategy());

            riderList.Add(r1);
            riderList.Add(r2);

            InsurancePolicy p1 = new OneTimeInsurancePolicy(baseTnC, startDateTime, maturedDateTime, cList[0], eList[0], riderList);

            pList.Add(p1);
        }

        static void customerSystem(Client client)
        {
            Console.WriteLine("Welcome back customer, " + client.getName() + "\n");

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
                int no = 1;
                while (ipIterator.hasNext())
                {
                    InsurancePolicy policy = (InsurancePolicy)ipIterator.next();

                    // Print out policy details inline.
                    Console.WriteLine("#" + no++);
                    Console.WriteLine("ID: " + policy.getPolicyID());
                    Console.WriteLine();
                }

                // Get user option.
                Console.WriteLine("\n\n[1] View a policy\n[0] Return home");

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
                Console.WriteLine("ID: " + policy.getPolicyID());

                Console.WriteLine("Terms & Conditions: ");
                int tAndCNo = 1;
                foreach (string tAndC in policy.getTermsCond())
                {
                    Console.WriteLine("#" + (tAndCNo++) + tAndC);
                }

                Console.WriteLine("Riders: ");
                int riderNo = 1;
                foreach (Rider r in policy.getRiderList())
                {
                    Console.WriteLine("#" + riderNo++);
                    Console.WriteLine("Description: " + r.getDescription());
                    Console.WriteLine("Total Amount payable: $" + r.getTotalAmountPayable());
                    Console.WriteLine("Pay out amount: $" + r.getPayOutAmount());
                    Console.WriteLine();
                }

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
                // If no premiums then return function.
                if (premiums.Count == 0)
                {
                    Console.WriteLine("No outstanding premiums!");
                    isRunning = false;
                    break;
                }

                // Display premiums.
                int no = 1;
                foreach (Premium p in premiums)
                {
                    Console.WriteLine("#" + no++);
                    Console.WriteLine("ID: " + p.getPremiumID());
                    Console.WriteLine("Details: " + p.getDetails());
                    Console.WriteLine("Due Date: " + p.getDueDate().ToString());
                    Console.WriteLine("Amount Payable: $" + p.getAmountPayable().ToString(".00"));
                    Console.WriteLine();
                }

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
                    Console.WriteLine("Payment successful!");
                    Console.WriteLine("Receipt no: " + premium.getPremiumID());
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

        static void staffSystem(string user, List<Client> cList, Employee loggedInEmployee, List<InsurancePolicy> pList)
        {
            Console.WriteLine("Welcome back employee, " + user + "\n");
            bool programrun = true;

            while (programrun)
            {
                Console.WriteLine("-----Staff Tasks-----");
                Console.WriteLine("[1] Create New Policy");
                Console.WriteLine("[2] View Policy");
                Console.WriteLine("[0] Exit"); // if user = admin show all , if user != admin show their own policies only
                Console.Write("Enter option: ");
                int option = Convert.ToInt32(Console.ReadLine());

                if (option == 1) //Create new policy
                {
                    createPolicy(cList, loggedInEmployee, pList);
                }
                else if (option == 2) //View policy
                {
                    staffViewPolicy(pList);
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

        static void createPolicy(List<Client> cList, Employee loggedInEmployee, List<InsurancePolicy> pList) //Done by Melvin
        {
            List<Rider> riderList = new List<Rider>();
            List<string> TnC = new List<string>();
            int moreRiders = 1;
            int riderNo = 0;

            Console.WriteLine("\n-----List of clients-----");
            for (int i = 0; i < cList.Count; i++)
            {
                Console.WriteLine("[" + cList[i].getClientID() + "]" + cList[i].getName());
            }

            Console.Write("Select a client: ");
            int clientNo = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nSelect premium type (1-One Time | 2-Periodic): ");
            int premiumType = Convert.ToInt32(Console.ReadLine());

            int noOfDays = 0; //placeholder
            if (premiumType == 2)
            {
                Console.Write("Number of days per period: ");
                noOfDays = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nEnter maturity date: ");
            DateTime maturityDate = Convert.ToDateTime(Console.ReadLine());
            DateTime startDate = DateTime.Now;

            while (moreRiders == 1)
            {
                Console.Write("\nEnter in policy description: ");
                string desc = Console.ReadLine();

                Console.Write("\nEnter policy type: ");
                string policyType = Console.ReadLine();

                Console.Write("\nEnter payout amount: $");
                double payOut = Convert.ToDouble(Console.ReadLine());

                Console.Write("\nEnter total amount: $");
                double totalAmt = Convert.ToDouble(Console.ReadLine());

                Console.Write("\nAre there any more riders? (1- Yes | 2- No): ");
                moreRiders = Convert.ToInt32(Console.ReadLine());

                Rider rider = new Rider(riderNo, desc, policyType, payOut, totalAmt, new PercentagePayoutStrategy());
                riderList.Add(rider);
                riderNo++;
            }

            Console.Write("\nEnter terms and conditions: ");
            string stringTnC = Console.ReadLine();
            TnC.Add(stringTnC);

            //Display details of insurance policy

            Console.Write("\nConfirm to create policy? (1-Confirm | 2-Cancel): ");
            int confirm = Convert.ToInt32(Console.ReadLine());

            if (confirm == 1)
            {
                if (premiumType == 1) //One-time
                {
                    OneTimeIPBuilder policybuilder = new OneTimeIPBuilder();
                    policybuilder.withClient(cList[0]);
                    policybuilder.withEmployee(loggedInEmployee);
                    policybuilder.startsOn(startDate);
                    policybuilder.maturesOn(maturityDate);
                    policybuilder.addsTermsAndCond(stringTnC);

                    for (int i = 0; i < riderList.Count; i++)
                    {
                        policybuilder.addRider(riderList[i]);
                    }

                    pList.Add(policybuilder.build());
                    Console.WriteLine("One-time policy created!\n");
                }
                else if (premiumType == 2) //Periodic
                {
                    PeriodicIPBuilder policybuilder = new PeriodicIPBuilder();
                    policybuilder.withClient(cList[0]);
                    policybuilder.withEmployee(loggedInEmployee);
                    policybuilder.startsOn(startDate);
                    policybuilder.maturesOn(maturityDate);
                    policybuilder.addsTermsAndCond(stringTnC);
                    policybuilder.SetPeriodicDays(noOfDays);

                    for (int i = 0; i < riderList.Count; i++)
                    {
                        policybuilder.addRider(riderList[i]);
                    }

                    pList.Add(policybuilder.build());
                    Console.WriteLine("Periodic policy created!\n");
                }
            }
            else if (confirm == 2)
            {
                Console.WriteLine("Policy NOT created!\n");
            }
        }

        static void staffViewPolicy(List<InsurancePolicy> pList)
        {
            for (int i = 0; i < pList.Count; i++)
            {
                Console.WriteLine(pList[i].getPolicyID());
            }

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

        static void editPolicy(InsurancePolicy policy)
        {
            List<Rider> policyRiders = policy.getRiderList();
            int riderNo = policyRiders.Count;
            Console.Write("Add Rider?[Y/N]: ");
            string option = Console.ReadLine();
            while (option == "Y")
            {
                Console.Write("\nEnter in policy description: ");
                string desc = Console.ReadLine();

                Console.Write("\nEnter policy type: ");
                string policyType = Console.ReadLine();

                Console.Write("\nEnter payout amount: $");
                double payOut = Convert.ToDouble(Console.ReadLine());

                Console.Write("\nEnter total amount: $");
                double totalAmt = Convert.ToDouble(Console.ReadLine());

                Console.Write("\nConfirm Add Rider?[Y/N]: ");
                string addRider = Console.ReadLine();

                if (addRider == "Y")
                {
                    Rider rider = new Rider(riderNo, desc, policyType, payOut, totalAmt, new PercentagePayoutStrategy());
                    policyRiders.Add(rider);
                    riderNo++;
                    Console.WriteLine("Rider Updated!");
                    Console.Write("\nAdd more riders?[Y/N]: ");
                    option = Console.ReadLine();
                }
                else if (addRider == "N")
                {
                    continue;
                }
            }
            if (option == "N")
            {
                Console.Write("Pay Premium by Cheque?[Y/N]: ");
                string ppbc = Console.ReadLine();
                while (ppbc == "Y")
                {
                    if (policyRiders[0].getTotalAmountPayable() == 0)
                    {
                        Console.Write("No outstanding premium");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Total amount payable = $" + policyRiders[0].getTotalAmountPayable());
                        Console.Write("Enter Cheque No.: ");
                        string cheque = Console.ReadLine();
                        Console.Write("Enter bank acc No.: ");
                        string bank = Console.ReadLine();
                        Console.Write("\nConfirm Payment?[Y/N]: ");
                        string payByCheque = Console.ReadLine();

                        if (payByCheque == "Y")
                        {
                            //Store cheque details
                            //Total amount payable =0
                            Console.WriteLine("Cheque Stored!");
                            break;
                        }
                        else if (payByCheque == "N")
                        {
                            continue;
                        }
                    }
                }
                Console.WriteLine("Policy Updated!");
            }
        }

        static void generateAlerts(List<InsurancePolicy> policy)
        {
            List<Premium> p;
            List<int> options = new List<int>();
            bool preNum = false;

            // skeleton code 
            //foreach (InsurancePolicy item in policy)
            //{
            //    p = item.getPremiums();

            //    foreach (Premium premium in p)
            //    {
            //        if (premium.getDueDate() > DateTime.Today)
            //        {
            //            Console.WriteLine(premium.getPremiumID());
            //        }
            //        //getPremiums and check if its due. If due console print due
            //    }
            //}

            //for demo purposes
            Console.WriteLine("ID           Due Date        Amount");
            Console.WriteLine("01           11/11/2011        $20");


            while (preNum)
            {
                Console.Write("Enter premium's number to send letter: ");
                options.Add(Convert.ToInt32(Console.ReadLine()));
                Console.Write("Is there anymore premium to select? ");
                if (Console.ReadLine() == "no") preNum = true;
            }

            Console.WriteLine("AUTO GENERATED EMAIL");
            Console.WriteLine("Your premium is due for payment");

            Console.WriteLine("Confirm send?");
            Console.ReadLine();

            Console.WriteLine("AUTO GENERATED LETTER");
            Console.WriteLine("Your premium is due for payment");

            Console.WriteLine("Confirm send?");
            Console.ReadLine();

            Console.WriteLine("Press enter to return");
            Console.ReadKey();
        }
    }
}