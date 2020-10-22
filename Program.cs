using System;
using System.Collections.Concurrent;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace SavageLab7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and welcome to Grand Circus. Please input some information...IF YOU DARE!>:)");
            Console.WriteLine();


            static bool NameValidator(string name)
            {
                Regex namePattern = new Regex(@"^([A-Z]{1}\w{4,29})$");
                if (namePattern.IsMatch(name))
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            static bool EmailValidator(string email)
            {
                Regex emailPattern = new Regex(@"^([A-z|0-9]{5,30})@([A-z|0-9]{5,10})\.([A-z]{2,3})$");
                if (emailPattern.IsMatch(email))
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            static bool PhoneNumberValidator(string phoneNumber)
            {
                Regex phoneNumberPattern = new Regex(@"^((\d{3}-)|(\(\d{3}\)(-| )))?\d{3}-\d{4}$");
                if (phoneNumberPattern.IsMatch(phoneNumber))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            static bool DateValidator(string date)
            {
                Regex datePattern = new Regex(@"^\d{2}/\d{2}/(\d{4}|\d{2})$");
                if (datePattern.IsMatch(date))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            static bool HTMLValidator(string html)
            {
                Regex htmlPattern = new Regex(@"^<[a-z]+>.+?<\/[a-z]+>$");
                if (htmlPattern.IsMatch(html))
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            Console.WriteLine("Please enter a valid name.(Must start with a capital letter).");
            string name = Console.ReadLine();
            bool nameIsValid = NameValidator(name);
            Console.WriteLine();

            if (nameIsValid)
            {
                Console.WriteLine("Name is valid, yay!");
            }
            else
            {
                Console.WriteLine("Name is invalid, sorry.");
            }
            Console.WriteLine();
            Console.WriteLine("Please enter a valid email.");
            string email = Console.ReadLine();
            bool emailIsValid = EmailValidator(email);
            Console.WriteLine();

            if (emailIsValid)
            {
                Console.WriteLine("Your email is valid.");
            }
            else
            {
                Console.WriteLine("Invalid email, sorry.");
            }
            Console.WriteLine();
            Console.WriteLine("Please enter a valid phone number.");
            string phoneNumber = Console.ReadLine();
            Console.WriteLine();
            bool phoneNumberIsValid = PhoneNumberValidator(phoneNumber);

            if (phoneNumberIsValid)
            {
                Console.WriteLine("Phone number is valid.");
            }
            else
            {
                Console.WriteLine("Phone number is invalid, sorry.");
            }
            Console.WriteLine();
            Console.WriteLine("Please enter a valid date.");
            string date = Console.ReadLine();
            Console.WriteLine();
            bool dateIsValid = DateValidator(date);

            if (dateIsValid)
            {
                Console.WriteLine("Date is valid.");
            }
            else
            {
                Console.WriteLine("Date is invalid, sorry.");
            }
            Console.WriteLine("Please enter a valid HTML element.");
            string html = Console.ReadLine();
            Console.WriteLine();
            bool htmlIsValid = HTMLValidator(html);

            if (htmlIsValid)
            {
                Console.WriteLine("The HTML element is valid!");
            }
            else
            {
                Console.WriteLine("HTML is invalid!");
            }
        }
    }    
}