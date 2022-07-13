using System;


    internal class Class1
    {
        public void DisplayName()
        {
        

            Console.WriteLine("Enter Full Name: ");
            string Name = Console.ReadLine();
            Console.WriteLine();

        string[] fullName = Name.Split(" ");
            
       
        Console.WriteLine("Your Name is:\n {0}", fullName[1] +" "+ fullName[0]);
    
        }
    }

