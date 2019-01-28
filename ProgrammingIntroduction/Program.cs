using System;

namespace ProgrammingIntroduction
{
    class Program
    {
        public static void Main()
        {
            int a = 5, b = 15;
            printPrimeNumbers(a, b);

            int n1 = 5;
            double r1 = getSeriesResult(n1);
            Console.WriteLine("The sum of the series is:" + r1);

            long n2 = 15;
            long r2 = decimalToBinary(n2);
            Console.WriteLine("Binary conversion of the decimal number " + n2 + " is: " + r2);

            long n3 = 1111;
            long r3 = binaryToDecimal(n3);
            Console.WriteLine("Decimal conversion of the binary number " + n3 + " is: " + r3);

            int n4 = 5;
            printTriangle(n4);

            int[] arr = new int[] { 1, 2, 3, 2, 2, 1, 3, 2 };
            computeFrequency(arr);
        }

        public static void printPrimeNumbers(int x, int y)
        {
            try
            {
                int p = 0;
                Console.WriteLine("The prime numbers between {0} and {1} are: ", x, y);
                //This loop is for checking the numbers in the range provided
                for (int i = x; i <= y; i++)
                {
                    int cnt = 0;
                    cnt = isPrime(i);
                    if (cnt == 0)   //if count is 0, then given number is prime
                    {
                        if (p == 0)  //prints the first prime number in the given range without a comma
                        {
                            Console.Write(i); 
                            p = p + 1;
                        }
                        else //prints the consecutive prime numbers after first prime number with a comma
                        {
                            Console.Write(" , " + i);
                        }
                    }
                    cnt = 0;
                }
                Console.WriteLine();
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printPrimeNumbers()");
            }
        }
        public static int isPrime(int x)
        {
            int cnt = 0;
            try
            {
                //this loop checks if a number in the given range has factors
                for (int j = 2; j < x/2; j++)
                {
                    if (x % j == 0)
                    {
                        cnt++;
                    }
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while checking isPrime()");
            }
            return cnt;
        }

        public static double getSeriesResult(int n)
        {
            double SeriesResult = 0.0;
            int i = 0;
            double fact = 0.0;
            try
            {
                for (i = 1; i <= n; i++)
                {
                    fact = getFactorail(i); //calling method to calculate factorial value
                    fact = fact / (i + 1);
                    if (i % 2 == 0)   //to add appropriate sign value to the odd and even numbers
                    {
                        fact = fact * -1;
                    }
                    SeriesResult = SeriesResult + fact; //adding the elements in the series
                }
                SeriesResult = Math.Round(SeriesResult, 3); //to round off to 3 decimal places
                Console.WriteLine();
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("Exception occured while computing getSeriesResult()");
            }
            return SeriesResult;
        }
        public static double getFactorail(int n)
        {
            double fact = 1.00;
            int i = 0;
            try
            {
                for (i = 1; i <= n; i++) //to calculate factorial value of given number
                {
                    fact = fact * i;
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing getSeriesResult()");
            }
            return fact;
        }

        public static long decimalToBinary(long n)
        {
            try
            {
                long decimalNumber = n;
                long remainder;
                string result = string.Empty;
                while (decimalNumber > 0)
                {
                    remainder = decimalNumber % 2; // To obtain the remainder for binary digit
                    decimalNumber /= 2; // To obtain the quotient for next iteration
                    result = remainder.ToString() + result; //Storing the result to string
                }

                Console.WriteLine();
                Console.ReadKey();
               return Convert.ToInt32(result);   
            }
            catch
            {
                Console.WriteLine("Exception occured while computing decimalToBinary()");
            }
            return 0;
        }

        public static long binaryToDecimal(long n)
        {
            try
            {
                long binary_val, decimal_val = 0, base_val = 1, rem;
                binary_val = n;
                int power1 = 0;
                while (n > 0)
                {
                    rem = n % 10;
                    base_val = powern(power1); // calling method to calculate power value
                    decimal_val = decimal_val + rem * base_val;
                    n = n / 10;
                    power1 = power1 + 1;
                }
                Console.WriteLine();
                Console.ReadKey();
                return Convert.ToInt64(decimal_val);   
            }
            catch
            {
                Console.WriteLine("Exception occured while computing binaryToDecimal()");
            }
            return 0;
        }
        public static int powern(int x)
        {
            int base_val = 1;
            for (int i=1; i <= x; i++) // loop to calculate 2^n value
            {
                base_val = base_val * 2;
            }
            return base_val;
        }

        public static void printTriangle(int n)
        {
            try
            {
                int row, colSpace, colStar;
                Console.WriteLine();
                Console.ReadKey();
                Console.WriteLine("Triangle with {0} rows", n);
                for (row = 1; row <= n; row++) // To print requested numbers of rows
                {
                    
                    for (colSpace = n - row; colSpace >= 1; colSpace--) // To print required number of spaces in each row
                    {

                        Console.Write(" ");
                    }
                    for (colStar = 1; colStar <= (row*2) - 1; colStar++) // To print required number of stars in each row
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine("");
                }           
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printTriangle()");
            }
        }

        public static void computeFrequency(int[] a)
        {
            try
            {
                int[] arr1 = new int[8]; //array provided by the user
                int[] fr1 = new int[8]; //initiallising an array to store number of occurances
                arr1 = a;
                int n, i, j, count;
                n = arr1.Length;
                for (i = 0; i < n; i++) // Loop to store number of occurances
                {
                    fr1[i] = -1;
                }
                for (i = 0; i < n; i++) // Loop to count occurance of each number
                {
                    count = 1;
                    for (j = i + 1; j < n; j++)
                    {
                        //counting number of occurances
                        if (arr1[i] == arr1[j])
                        {
                            count++;
                            fr1[j] = 0;
                        }
                    }
                    // updating the count
                    if (fr1[i] != 0)
                    {
                        fr1[i] = count;
                    }
                }
                Console.Write("\nNumber \t Frequency \n");
                for (i = 0; i < n; i++) //Printing numbers and their frenquency in a given array
                {
                    if (fr1[i] != 0)
                    {
                        Console.Write("{0} \t {1} \n", arr1[i], fr1[i]); 
                    }
                }
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("Exception occured while computing computeFrequency()");
            }
        }
    }
}
