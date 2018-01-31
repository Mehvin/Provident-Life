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
            int option = 0;
            bool programrun = true;

            Console.WriteLine("----Provident Life System----");
            Console.Write("Username: ");
            user = Console.ReadLine();

            while (programrun)
            {
                displayMenu();
                Console.Write("Enter option: ");
                option = Convert.ToInt32(Console.ReadLine());

                if (option == 1)
                {
                    //Funtion Create new policy
                }
                else if (option == 2)
                {
                    //Function View All Policy

                    //Selects policy number
                    //display policy menu
                    displayPolicyMenu();
                }
                else if (option == 0)
                {
                    //exit
                    programrun = false;
                }
            }       
        }
            
        static void displayMenu()
        {
            Console.WriteLine("\nProvident Life System");
            Console.WriteLine("[1] Create New Policy");
            Console.WriteLine("[2] View All Policy"); // if user = admin show all , if user != admin show their own policies only
            Console.WriteLine("[0] Exit");
        }

        static void displayPolicyMenu()
        {
            Console.WriteLine("\n1. Generate Alerts");
            Console.WriteLine("2. Edit Policy");
        }
    }
}
