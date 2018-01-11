using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class OddOrEvenDistinguisherProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number between 1 and 100 and this program will determine if it is an odd or even number!"); //opening message

            int userNumberInput, userResponse, closeProgram;
            string userNumberInputString, userResponseString;
            closeProgram = 1;

            const int minimumNumber = 1;
            const int maximumNumber = 100;
            do
            {
                userNumberInputString = Console.ReadLine();
                userNumberInput = int.Parse(userNumberInputString);
                {
                    if (userNumberInput > maximumNumber) //possibile inputs & outcomes
                    {
                        Console.WriteLine("The number " + userNumberInput + " exceeds the parameters of this experiment. Please enter another number.");
                    }
                    else if (userNumberInput < minimumNumber)
                    {
                        Console.WriteLine("The number cannot be less than " + minimumNumber + ". Please enter another number.");
                    }
                    else if (userNumberInput >= 1 && userNumberInput <= 100)
                    {
                        if (userNumberInput % 2 == 0)
                        {
                            Console.WriteLine("The number " + userNumberInput + " is even.");
                            Console.WriteLine("Type \"1\" to submit another number or \"2\" to close program.");

                            userResponseString = Console.ReadLine(); //submit another or exit
                            userResponse = int.Parse(userResponseString);
                            if (userResponse > 1)
                            {
                                System.Threading.Thread.Sleep(500);
                                closeProgram = closeProgram + 1;
                            }
                        }
                        else
                        {
                            Console.WriteLine("The number " + userNumberInput + " is odd.");
                            Console.WriteLine("Type \"1\" to submit another number or \"2\" to close program.");

                            userResponseString = Console.ReadLine(); //submit another or exit
                            userResponse = int.Parse(userResponseString);
                            if (userResponse > 1)
                            {
                                System.Threading.Thread.Sleep(500);
                                closeProgram = closeProgram + 1;
                            }
                        }
                    }
                }
            } while (userNumberInput < minimumNumber || userNumberInput > maximumNumber || closeProgram is 1); //repeat until hit exit
        }
    }
}
