using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace learn_005_classes.Models
{
    internal class User
    {
        // Properties, based on the fact they use (get set which are classmembers)
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Constructor
        //Public User()
        //{
        //    FirstName = "";
        //    LastName = "";
        //}

        // The prior actions, can be shortened down to this instead. 
        public string Password { get; set; } = "";

        // Lets use them. 
        public User(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        // ALWAYS Write out a method in PascalCase and not in camelCase! same goes for properties.
        internal void MethodName()
        {

        }

        public static void Greeting()
        {
            Console.WriteLine("Greeting: Welcome back!");
        }

        public static string GreetingTwo()
        {
            return "GreetingTwo: Welcome back!";
        }
    }
}
