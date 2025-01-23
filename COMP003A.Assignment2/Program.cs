// Author: Alvaro Pulido
// Course: COMP003
// Faculty: Jonathan Cruz
// Purpose: Discount Calculator 
namespace COMP003A.Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userFistName; // Variable for user's first name
            string userLastName; // Variable for user's lasst name
            int userAge; // Variable for user's name
            double productPrice; // Variable for the price of the product
            bool isStudent; // Variable to store is the user is a student (true/false)


            Console.Write("What is your first name: ");
            userFistName= Console.ReadLine();

            Console.Write("What is your last name: ");
            userLastName= Console.ReadLine();

            Console.Write("How old are you: ");
            userAge = int.Parse(Console.ReadLine());

            Console.Write("What is the price of the item you're interested in? ");
            productPrice = double.Parse(Console.ReadLine());

            Console.Write("Are you a student? (true/false): ");
            isStudent = bool.Parse(Console.ReadLine());

            int futureAge = userAge + 5;
            bool ageAdult = userAge >= 65;
            double ifStudent = productPrice * .9;
            double ifSenior = productPrice * .8;



            Console.WriteLine($"\nHello, {userFistName} {userLastName}! ");
            Console.WriteLine($"In 5 years you will be {futureAge}");
            Console.WriteLine($"The original price of the item you are interested in is {productPrice}");
            Console.WriteLine($"As a student, your discounted price is {ifStudent.ToString("N")}");
            Console.WriteLine($"As a senior, your discounted price is {ifSenior.ToString("N")}");









        }
    }
}