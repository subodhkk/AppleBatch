using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftBatch.Test_Assignment
{
    internal class SpyNo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0, multi = 1, rem;

            while(num != 0)
            {
                rem = num % 10;
                sum=sum+rem;
                multi = multi * rem;
                num = num / 10;
            }
            if (sum == multi) 
                Console.WriteLine("The number is SPY Number");
            else
            Console.WriteLine("The number is NOT SPY number");

        }

        class Factors
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter the number");
                int a = Convert.ToInt32(Console.ReadLine());

                for (int i = 1; i < a; i++)
                {
                    if (a % i == 0)
                        Console.WriteLine(i);
                }
            }
        }

        class EvenoddSum
        {
            static void Main(string[] args)
            {
                for(int i = 1; i <= 50; i++)
                {
                    if(i % 2 == 0)
                    
                        Console.WriteLine("The number " + i + " is Even");
                    else
                    {
                        Console.WriteLine("The square of odd Number is " + i*i);
                    }
                    
                }
            }

            class Harshad
            {
                static void Main(string[] args)
                {
                    Console.WriteLine("Enter the number");
                    int a = Convert.ToInt32(Console.ReadLine());
                    int t = a;
                    int sum = 0;
                    while (a > 0)
                    {
                        int digit = a % 10;
                        sum = sum + digit;
                        a = a / 10;

                    }
                    if (t % sum == 0)
                        Console.WriteLine("Its Harshad No");
                    else
                        Console.WriteLine("Not harshad no");
                }
            }
        }


        class RedBlue
        {
            static void Main(string[] args)
            {
                
                for (int i = 1; i <= 100; i++)
                {
                    
                    if (i % 3 == 0 && i % 5 == 0)
                        Console.WriteLine(" Red Blue");
                    
                    else if (i % 3 == 0 )
                        Console.WriteLine(" Red Number");
                    else if (i % 5 == 0)
                        Console.WriteLine(" Blue Number");
                    else
                        Console.WriteLine(" "+i);
                }
            }
        }

        class Trimorphic
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter the number");
                int num = Convert.ToInt32(Console.ReadLine());

                int cube = num * num * num;
                int flag = 0;
                while (num != 0)
                {
                    if (num % 10 != cube % 10)
                    {
                        flag = 1;
                        break;
                    }
                    num =num / 10;
                  
                }
                if (flag == 0)
                   Console.WriteLine( "It is a Trimorphic Number.");
                else
                    Console.WriteLine("It is not a Trimorphic Number.");
            }
        }

        class Twin
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter 1st Number");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter 2nd Number");
                int b = Convert.ToInt32(Console.ReadLine());
                int c = a / 2;
                int d = b / 2;
                int flag = 0;
                for (int i = 2; i <= c; i++)
                {
                    if (a % i == 0)
                    {
                        Console.Write(" 1st Number is not Prime.");
                        flag++;
                        break;
                    }
                   
                }
               // if (flag == 0)
                 //   Console.WriteLine("1st Number is Prime.");
                for (int i = 2; i <= d; i++)
                {
                    if (b % i == 0)
                    {
                        Console.Write(" 2nd Number is not Prime.");
                        flag++;
                        break;
                    }
                   // if (flag == 0)
                     //   Console.WriteLine("2nd Number is Prime.");
                }
                //Console.WriteLine("2nd Number is Prime.");
                if(a-b==2 ||b-a==2)
                    Console.WriteLine("The entered no " +a + " & " +b + " are TWIN PRIME");
            }
        }

        class Amicable
        {
            static void Main(string[] args)
            {

                int sum1=0, sum2 = 0;
                Console.WriteLine("Enter a 1st  Number");
                int a=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter a 2nd Number");
                int b = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i <= a / 2; i++)
                {
                    if(a%i== 0)
                    {
                       sum1= sum1+i;
                    }
                }
                for(int i = 1; i <= b / 2; i++)
                {
                    if (b % i == 0)
                    {
                        sum2 = sum2 + i;
                    }
                }
                if(sum1==b && sum2==a)
                    Console.WriteLine("Number is Amicable number");
                else
                    Console.WriteLine("Not a Amicable number");
            }
        }
        class IMEI
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter the IMEI number " );
                long a = Convert.ToInt64(Console.ReadLine());
                int c = 0;
                long n = a;
                while (a > 0)
                {
                    c++;
                    a = a / 10;
                }
                n = a;
                //Console.WriteLine("Entered number is 15 digit number"+c);
                if (c == 15)
                {
                    int sum = 0;
                    for (int i=1;i <= 15; i++)
                    {
                        
                        int d = (int)(a % 10);
                        a = a / 10;
                        if (i % 2 == 0)
                        {
                            int du = 2 * d;
                            sum = sum + du;
                            if (du <= 9)
                                sum = sum + du;
                            else
                                sum = sum + du % 10 + du / 10;
                        }                            
                    }
                    if (sum%10==0)
                        Console.WriteLine("Valid IMEI number");
                    else
                        Console.WriteLine("Invalid IMEI number");
                }             
                else
                    Console.WriteLine("Not a 15 Digit Number"); 
            }
        }

    }
    
}
