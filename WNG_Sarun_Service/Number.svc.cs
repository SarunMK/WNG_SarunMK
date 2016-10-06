using System.Collections.Generic;

namespace WNG_Sarun_Service
{
    public class Number : INumber
    {
        /// <summary>
        /// Get all whole numbers till the input value
        /// </summary>
        /// <param name="longNumber">Input number</param>
        /// <returns>Returns array of long numbers</returns>
        long[] INumber.GetAllNumbers(long number)
        {
            List<long> lstAllNumber = new List<long>();
            for (long i = 0; i <= number; i++)
            {
                lstAllNumber.Add(i);
            }
            return lstAllNumber.ToArray();
        }

        /// <summary>
        /// Get all even numbers till the input value
        /// </summary>
        /// <param name="longNumber">Input number</param>
        /// <returns>Returns array of long numbers</returns>
        long[] INumber.GetAllEvenNumbers(long number)
        {
            List<long> lstEvenNumber = new List<long>();
            for (long i = 2; i <= number; i++)
            {
                if (i % 2 == 0)
                    lstEvenNumber.Add(i);
            }
            return lstEvenNumber.ToArray();
        }

        /// <summary>
        /// Get all odd numbers till the input value
        /// </summary>
        /// <param name="longNumber">Input number</param>
        /// <returns>Returns array of long numbers</returns>
        long[] INumber.GetAllOddNumbers(long number)
        {
            List<long> lstOddNumber = new List<long>();
            for (long i = 1; i <= number; i++)
            {
                if (i % 2 != 0)
                    lstOddNumber.Add(i);
            }
            return lstOddNumber.ToArray();
        }

        /// <summary>
        /// Get all numbers till the input value
        /// Display letter C for the numbers that are multiples of 3,
        /// Display letter E for the numbers that are multiples of 5,
        /// Display letter Z for the numbers that are multiples of 3 % 5
        /// </summary>
        /// <param name="longNumber">Input long numbers</param>
        /// <returns>Returns array of string</returns>
        string[] INumber.GetAllNumbersExceptMultiplesOfThreeAndFive(long number)
        {
            List<string> lstNumberExceptMultiple3N5 = new List<string>();
            lstNumberExceptMultiple3N5.Add("0");
            for (long i = 1; i <= number; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    lstNumberExceptMultiple3N5.Add("Z");
                else if (i % 3 == 0)
                    lstNumberExceptMultiple3N5.Add("C");
                else if (i % 5 == 0)
                    lstNumberExceptMultiple3N5.Add("E");
                else
                    lstNumberExceptMultiple3N5.Add(i.ToString());
            }
            return lstNumberExceptMultiple3N5.ToArray();
        }

        /// <summary>
        /// Get all numbers in fibonacci series till the input value
        /// </summary>
        /// <param name="longNumber">Input number</param>
        /// <returns>Returns array of long numbers</returns>
        long[] INumber.GetAllFibonacciNumbers(long number)
        {
            List<long> lstFibonacci = new List<long>();
            if(number > 0)
            { 
                long longPreviousNumber = 0, longCurrentNumber = 1, longNextNumber = 0;

                lstFibonacci.Add(longPreviousNumber);
                lstFibonacci.Add(longCurrentNumber);

                while (longCurrentNumber < number)
                {
                    longNextNumber = longCurrentNumber + longPreviousNumber;
                    if (longNextNumber > number)
                        break;

                    lstFibonacci.Add(longNextNumber);

                    longPreviousNumber = longCurrentNumber;
                    longCurrentNumber = longNextNumber;
                }
            }
            return lstFibonacci.ToArray();
        }
    }
}
