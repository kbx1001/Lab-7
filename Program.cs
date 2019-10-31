using System;
using System.Text.RegularExpressions;

namespace Lab7
{
    class Program

    {
        static void Main(string[] args)
        {
            string userName;
            string userEmail;
            string userPhone;
            string userBirthday;

            Console.WriteLine("Hello, please enter a valid name.");
            userName = Console.ReadLine();
            validateName(userName);

            Console.WriteLine("Please enter a valid email address.");
            userEmail = Console.ReadLine();
            validateEmail(userEmail);

            Console.WriteLine("Please enter your phone number in the (xxx-xxx-xxxx) format.");
            userPhone = Console.ReadLine();
            validatePhone(userPhone);

            Console.WriteLine("Please enter your todays date in the (mm/dd/yyyy) format.");
            userBirthday = Console.ReadLine();
            validateBirthday(userBirthday);
        }
        public static void validateName(string userName)
        {
            if (Regex.IsMatch(userName, @"^[A-Z]+[a-z]{0,30}"))
            {
                Console.WriteLine("Nice to meet you!");
            }
            else
            {
                Console.WriteLine("That is an invalid input.");
            }
        }
        public static void validateEmail(string userEmail)
        {
            if (Regex.IsMatch(userEmail, @"([A-Za-z]){5,30}(\@)([a-zA-z]){5,30}(\.)([a-zA-z]){2,3}"))
            {
                Console.WriteLine("Thank you for the information!");
            }
            else
            {
                Console.WriteLine("That is an invalid input.");
            }
            //3
            //^(([0 - 9]){ 3} (\-)([0 - 9]){ 3} (\-)([0 - 9]){ 4}$)
        }
        public static void validatePhone(string userPhone)
        {
            if (Regex.IsMatch(userPhone, @"(^([0-9]){3}(\-)([0-9]){3}(\-)([0-9]){4}$)"))
            {
                Console.WriteLine("Thank you for the information!");
            }
            else
            {
                Console.WriteLine("That is an invalid input.");
            }
        }
        public static void validateBirthday(string userBirthday)
        {
            if (Regex.IsMatch(userBirthday, @"(^([0-9]){2}(\/)([0-9]){2}(\/)([0-9]){4}$)"))
            {
                Console.WriteLine("Thank you for the information!");
            }
            else
            {
                Console.WriteLine("That is an invalid input.");
            }
        }
    }
}
