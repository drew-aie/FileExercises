using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Write a Serialize and DeSerialize function for the Contact struct.
 * Serialize should write the contents of the object into a file.
 * DeSerialize should read the contents of a file and assign them to the object's variables.
 */
namespace FileExercises
{
    struct Contact
    {
        public string name;
        public string email;
        public int id;

        public Contact(string name, string email, int id)
        {
            this.name = name;
            this.email = email;
            this.id = id;
        }

        public void Print()
        {
            Console.WriteLine(name + " | " + email + " | " + id);
        }
    }
    internal class SerializeIO
    {
        public void Run()
        {
            // Make 3 contacts
            Contact bob = new Contact("Bob", "bob@email.com", 1234);
            Contact fred = new Contact("Fred", "fred@email.com", 2345);
            Contact jane = new Contact("Jane", "jane@email.com", 3456);

            // Write each contact to file
            bob.Serialize(@"bob.txt");
            fred.Serialize(@"fred.txt");
            jane.Serialize(@"jane.txt");

            // Clear out contacts
            bob = new Contact();
            fred = new Contact();
            jane = new Contact();

            // Load contacts from file
            bob.DeSerialize(@"bob.txt");
            fred.DeSerialize(@"fred.txt");
            jane.DeSerialize(@"jane.txt");

            // Print contacts
            bob.Print();
            fred.Print();
            jane.Print();
        }
    }
}
