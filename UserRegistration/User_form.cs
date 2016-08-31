using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement;
using UserManagement.Entities;
using UserValidation;

namespace UserRegistration
{
    class User_form
    {
        private static bool valid_lastName;
        private static bool valid_firstName;
        private static bool valid_userId;

        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to regitration page !");
            User user = new User();
            UserServices service = new UserServices();

            do
            {
                Console.WriteLine("Enter you first name !");
                user.FirstName = Console.ReadLine();
                valid_firstName = Validations.valid_firstName(user.FirstName);

                Console.WriteLine("Enter you last name !");
                user.LastName = Console.ReadLine();
                valid_lastName = Validations.valid_firstName(user.LastName);

                if (valid_firstName && valid_lastName)
                {
                    user.Id = service.CreateUser(user);
                    Console.WriteLine("Your user id is {0}.", user.Id);
                }
                else
                {
                    Console.WriteLine("Please enter proper name.");
                }
            } while (!valid_lastName || !valid_firstName);

            Console.WriteLine("Do you want to update you first name? (y/n)");
            if (Console.ReadLine() == "y")
            {
                do
                {
                    Console.WriteLine("Enter new first name.");
                    user.FirstName = Console.ReadLine();
                    valid_firstName = Validations.valid_firstName(user.FirstName);
                    if (valid_firstName)
                    {
                        user.Id = service.update_user_firstName(user.Id, user.FirstName);
                    }
                    else
                    {
                        Console.WriteLine("Please enter proper name.");
                    }
                } while (!valid_firstName);
            }

            Console.WriteLine("Do you want to delete your account? (y/n)");
            if (Console.ReadLine() == "y")
            {
                do
                {
                    Console.WriteLine("Enter yout id.");
                    string id = Console.ReadLine();
                    valid_userId = Validations.valid_userID(id);
                    if (valid_userId)
                    {
                        user.Id = Int64.Parse(id);
                        service.delete_user(user.Id);
                    }
                    else
                    {
                        Console.WriteLine("Enter proper user id");
                    }
                } while (!valid_userId);
            }
        }
    }
}
