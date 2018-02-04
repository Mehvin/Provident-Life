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
                staffSystem(user, clientList);
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

        static void staffSystem(string user, List<Client> cList)
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
                    createPolicy(cList);
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

        static void createPolicy(List<Client> cList) //Done by Melvin
        {
            List<Rider> riderList = new List<Rider>();
            List<string> TnC = new List<string>();
            int moreRiders = 1;
            int riderNo = 0;
            
            Console.WriteLine("\n-----List of clients-----");
            for (int i = 0; i < cList.Count; i++)
            {
                Console.WriteLine("["+cList[i].getClientID() +"]"+ cList[i].getName());
            }

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
                double payOut = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter total amount: $");
                double totalAmt = Convert.ToDouble(Console.ReadLine());

                Console.Write("Are there any more riders? (1- Yes | 2- No): ");
                moreRiders = Convert.ToInt32(Console.ReadLine());

                Rider rider = new Rider(riderNo, desc, policyType, payOut, totalAmt, new PercentagePayoutStrategy());
                riderList.Add(rider);
                riderNo++;
            }

            Console.Write("Enter terms and conditions: ");
            string stringTnC = Console.ReadLine();
            TnC.Add(stringTnC);

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
