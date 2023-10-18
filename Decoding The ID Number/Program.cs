using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decoding_The_ID_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a South African ID number: ");
            string idNumber = Console.ReadLine();

            string dateOfBirth = idNumber.Substring(0, 6);
            int genderDigit = int.Parse(idNumber.Substring(6, 1));
            char citizenStatus = idNumber[10];


            string gender = (genderDigit < 5) ? "Female" : "Male";
            string citizenship = (citizenStatus == '0') ? "SA Citizen" : "Permanent Resident";

            Console.WriteLine("Date of Birth: " + dateOfBirth);
            Console.WriteLine("Gender:" + gender);
            Console.WriteLine("Citizenship:" + citizenship);
            Console.ReadLine();
        }
        static bool ValidateIDNumber(string idNumber)
        {
            int sum = 0;

            bool doubleDigit = false;

            for (int i = idNumber.Length - 1; i >= 0; i--)
            {
                int digit = int.Parse(idNumber[i].ToString());

                if (doubleDigit)
                {
                    digit *= 2;

                    if (digit > 9)

                        digit -= 9;
                }

                sum += digit;
                doubleDigit = !doubleDigit;
            }

            return (sum % 10 == 0);


        } 
}    }
