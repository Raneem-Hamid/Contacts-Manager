using System;
using System.Collections.Generic;

namespace Contacts_Manager
{
    public class Program
    {
        static Dictionary<string, string> contacts = new Dictionary<string, string>();

        static void Main(string[] args)
        {
            ContactsManager();
        }

        public static void ContactsManager()
        {
            //colors
            string RED = "\u001b[31m";
            string GREEN = "\u001b[32m";
            string RESET = "\u001b[0m";
            string YELLOW = "\u001b[33m";
            string CYAN = "\u001b[36m";
            string ORANGE = "\u001b[38;5;208m";
            string PINK = "\u001b[38;5;205m";
            string PURPLE = "\u001b[35m";
            string LIGHT_BLUE = "\u001b[94m";
            string LIGHT_GREEN = "\u001b[92m";
            string LIGHT_CYAN = "\u001b[96m";
            string LIGHT_RED = "\u001b[91m";
            string LIGHT_PURPLE = "\u001b[38;5;183m";

            while (true)
            {
                Console.Clear(); 

                Console.WriteLine($"{LIGHT_PURPLE}                                                         Contact Manager{RESET}");
                Console.WriteLine($"{LIGHT_CYAN}\n Welcome to our Contact Manager where you can manage your contacts :){RESET}");
                Console.WriteLine($"{PURPLE}************************************************************************************************************************{RESET}");
                Console.WriteLine($"{LIGHT_CYAN}Our services ^_^ :{RESET}");
                Console.WriteLine($"{LIGHT_CYAN}1. Add Contact{RESET}");
                Console.WriteLine($"{LIGHT_CYAN}2. Remove Contact{RESET}");
                Console.WriteLine($"{LIGHT_CYAN}3. Search Contact{RESET}");
                Console.WriteLine($"{LIGHT_CYAN}4. View All Contacts{RESET}");
                Console.WriteLine($"{LIGHT_CYAN}5. Exit{RESET}");
                Console.Write($"{LIGHT_PURPLE}What do you want to do?! Choose an option: {RESET}");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine($"{PINK}\n--- Add Contact ---{RESET}");
                        Console.Write("Enter contact name: ");
                        string nameToAdd = Console.ReadLine();
                        Console.Write("Enter contact phone: ");
                        string phoneToAdd = Console.ReadLine();
                        string addResult = AddContact(nameToAdd, phoneToAdd);
                        Console.WriteLine($"{GREEN}{addResult}{RESET}");
                        break;
                    case "2":
                        Console.WriteLine($"{LIGHT_RED}\n--- Remove Contact ---{RESET}");
                        Console.Write("Enter contact name to remove: ");
                        string nameToRemove = Console.ReadLine();
                        string removeResult = RemoveContact(nameToRemove);
                        Console.WriteLine($"{YELLOW}{removeResult}{RESET}");
                        break;
                    case "3":
                        Console.WriteLine($"{LIGHT_BLUE}\n--- Search Contact ---{RESET}");
                        Console.Write("Enter contact name to search: ");
                        string nameToSearch = Console.ReadLine();
                        string searchResult = SearchContact(nameToSearch);
                        Console.WriteLine($"{GREEN}{searchResult}{RESET}");
                        break;
                    case "4":
                        Console.WriteLine($"{LIGHT_GREEN}\n--- All Contacts ---{RESET}");
                        Dictionary<string, string> allContacts = ViewAllContacts();
                        if (allContacts.Count == 0)
                        {
                            Console.WriteLine($"{RED}No contacts found ; try to add ;){RESET}");
                        }
                        else
                        {
                            foreach (var contact in allContacts)
                            {
                                Console.WriteLine($"{contact.Key}: {contact.Value}");
                            }
                        }
                        break;
                    case "5":
                        Console.WriteLine($"{ORANGE}\nExiting the Contact Manager. Goodbye!{RESET}");
                        return;
                    default:
                        Console.WriteLine($"{RED}Invalid option. Please choose a valid option.{RESET}");
                        break;
                }

                Console.WriteLine($"{CYAN}\nPress any key to continue...{RESET}");
                Console.ReadKey(); 
            }
        }

        public static string AddContact(string name, string phone)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(phone))
            {
                return "Name and phone number cannot be empty.";
            }

            if (contacts.ContainsKey(name.ToLower()))
            {
                return "This contact already exists.";
            }
            else
            {
                contacts[name.ToLower()] = phone;
                return "The contact has been added successfully.";
            }
        }

        public static Dictionary<string, string> ViewAllContacts()
        {
            return contacts;
        }

        public static string SearchContact(string name)
        {
            if (contacts.ContainsKey(name.ToLower()))
            {
                return $"{name}: {contacts[name.ToLower()]}";
            }
            else
            {
                return "Contact not found.";
            }
        }

        public static string RemoveContact(string name)
        {
            if (contacts.ContainsKey(name.ToLower()))
            {
                contacts.Remove(name.ToLower());
                return "The contact has been removed successfully.";
            }
            else
            {
                return "Contact not found.";
            }
        }
    }
}
