using ContactBook;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Intrinsics.X86;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Slect Operation");
            Console.WriteLine("1.Add Conatct");
            Console.WriteLine("2.Display Contact");
            Console.WriteLine("3.View all contact");
            Console.WriteLine("4.Search Contact by name");
            Console.WriteLine("Press x to exit");


            var userInput = Console.ReadLine();

            PhoneBook phonebook = new PhoneBook();


            while(true)
            {
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Contact Name: ");
                        var name = Console.ReadLine();

                        Console.WriteLine("Contact Number: ");
                        var number = Console.ReadLine();

                        var newContact = new Contact(name, number);
                        phonebook.AddContact(newContact);
                        break;

                    case "2":
                        Console.WriteLine("ENTER the contact number u want to search");
                        var searchNumber= Console.ReadLine();
                        phonebook.DisplayContact(searchNumber);
                        break;

                    case "3":
                        phonebook.DisplayAllContact();
                        break;

                    case "4":
                        Console.WriteLine("ENter name u want to search : ");
                        var searchPhrase = Console.ReadLine();
                        phonebook.DisplayMatchingContact(searchPhrase);

                        break;

                    case "x":
                        return;

                    default:
                        Console.WriteLine("Please Slect vaid options");
                        break;

                }
                Console.WriteLine("Select Operation");
                userInput = Console.ReadLine();

            }


        }
    }
}