using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {


            bool programContinues = true;
            while (programContinues == true)

            {

                Console.WriteLine("Welcome to Batting Average calculator");
                Console.WriteLine("Enter number of times at bat: ");

                Console.WriteLine("0 = out, 1 = single, 2 = double, 3 = triple, 4 = homerun");
                int userinput = int.Parse(Console.ReadLine());



                double[] timesatBat = new double[userinput];

                // read the info from the user
                for (int i = 0; i < timesatBat.Length; i++)
                {
                    Console.WriteLine("Result for at-bat" + (i + 1));
                    timesatBat[i] = double.Parse(Console.ReadLine());
                }

                double Sum = 0;
                double Slugging = 0;

                for (int i = 0; i < timesatBat.Length; i++)
                {
                    Sum = Sum + timesatBat[i];

                }

                Slugging = Sum / userinput;

                Console.WriteLine($"The Slugging is equal to {Slugging}");

                double Count = 0;
                foreach (double Element in timesatBat)
                {
                    if (Element != 0)
                    {
                        Count = Count + 1;

                    }


                }

                double Ave = Count / Sum;
                Console.WriteLine($"The average is equal to {Ave}");


                Console.WriteLine("Another batter?");
                string userChoice;
                userChoice = Console.ReadLine();

                if (userChoice == "yes" || userChoice == "Yes" || userChoice == "YES")
                {
                    programContinues = true;
                }

                else if (userChoice == "no" || userChoice == "No" || userChoice == "No")
                {
                    programContinues = false;
                }
                else
                {
                    bool yesOrNo = true;
                    while (yesOrNo == true)
                    {
                        if (userChoice != "yes" || userChoice != "no" || userChoice == " ")
                        {
                            Console.WriteLine("Please enter yes or no");
                            userChoice = Console.ReadLine();
                            if (userChoice == "yes" || userChoice == "YES" || userChoice == "Yes")
                               
                            {
                            yesOrNo = false;
                            }

                            else if (userChoice == "NO" || userChoice == "No" || userChoice == "no")
                            {
                                Console.WriteLine("Bye Bye"); 
                                programContinues = false;
                                return;
                            }
                            

                        }
                       
                        
                    }   

                           
                }

            }
        }
    }
}
