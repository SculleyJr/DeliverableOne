using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberOne, numberTwo;                  //initializing variables
            float sumOne;
            int n = 0;
            bool statement = true;

            Console.WriteLine("enter any number");          //clollecting user input

            numberOne = Console.ReadLine();                 //naming user input

            float[] digitsOne = numberOne.ToCharArray().Select(x => (float)Char.GetNumericValue(x)).ToArray();      //breaking apart user input into seperate workable floats


            Console.WriteLine("enter any number with the same amount of digits");         //collecting user input

            numberTwo = Console.ReadLine();                                               //naming user input   

            float[] digitsTwo = numberTwo.ToCharArray().Select(x => (float)Char.GetNumericValue(x)).ToArray();      //breaking apart user input into seperate workable floats


            sumOne = (digitsOne[0] + digitsTwo[0]);          //naming the sum of the first digits


            if (numberOne.Length != numberTwo.Length)       //this makes sure both numbers entered have the same amount of digits

            {
                Console.WriteLine("the numbers are invalid, amount of digits do not match");

            }

            else
            {

                for (n = 0; n < digitsOne.Length; n++)                          //this tells what "n" does in the next statement

                    if (sumOne == digitsOne[n] + digitsTwo[n])                 //this says if the first sum equals the sum of the next digits

                    { statement = true; }
                    else { statement = false; }

                Console.WriteLine(statement);                                   //this is telling the console to write the value of bool statement
            }


        }
    }
}

