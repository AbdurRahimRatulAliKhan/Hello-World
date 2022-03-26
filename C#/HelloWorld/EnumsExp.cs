using System;

namespace HelloWorld
{
    class EnumsExp
    {
        static void checkAge(int age)
        {
            if (age < 18)
            {
                throw new Exception("Access denied");
            }
            else
            {
                Console.WriteLine("Access granted");
            }
        }
       static void Main(string[] args)
        {
            checkAge(20);
        }
    }
}
