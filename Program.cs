using System;

namespace SelectionMinitasks
{
    class Program
    {
        static void Main(string[] args)
        {
        //Uncomment the one you need to check, I got help from Scott
        //Task1();
        //Task2();
        //Task3();
        }
        public static void Task1()
        {
            Console.WriteLine("Please type your age");
            int age = int.Parse(Console.ReadLine());
        
            if (age > 17) 
            {
                Console.WriteLine("Legally Adult Age");
            }
            else if (age <= 17); 
            {
                Console.WriteLine("Legally not Adult Age");
            }
        }    
        
        
        public static void Task2() 
        {
          Console.WriteLine("Please type your age");
            int age = int.Parse(Console.ReadLine());

          Console.WriteLine("Please type your gender, M/F");
            string gender = Console.ReadLine();

           
            if (age <= 17)
            {
                 if (gender == "M") 
                {
                   Console.WriteLine("Male is not an adult");
                }
                else if (gender == "F") 
                {
                    Console.WriteLine("Female is not an adult");
                }
            }

            else if (age > 17)
            {
                 if (gender == "M") 
                {
                   Console.WriteLine("Male is an adult");
                }
                else if (gender == "F") 
                {
                    Console.WriteLine("Female is an adult");
                }
            }
        
           
            
        }
        
        
        public static void Task3()
        {
                Console.WriteLine("Please enter a number.");
                int num1 = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Please enter another number");
                int num2 = Int32.Parse(Console.ReadLine());
                
                int num3 = num1 + num2;

                if (num3 > 10)
                {
                    Console.WriteLine("Sum of numbers is larger than 10");
                }
                else if (num3 < 10)
                {
                    Console.WriteLine("Sum of numbers is smaller than 10");
                }
                else
                {
                    Console.WriteLine("Sum of numbers is 10");
                }
        }

    }
}
