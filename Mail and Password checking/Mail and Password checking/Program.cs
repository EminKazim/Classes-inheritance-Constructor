using System;

namespace Mail_and_Password_checking
{
    class Program
    {
        static void Main(string[] args)
        {
            string mail = "cavid@code.edu.az";
            string password = "12345";
            CheckLogin(mail, password); 

        }
        static void CheckLogin(string mail, string password)
        {
            if (mail == "cavid@code.edu.az" && password == "12345")
            {

                Console.WriteLine("Login succsessfully");
            }

            else
            {
                Console.WriteLine("Mail password is invalid");
            
            }
           
            
            
        }
    }
}

          
           


