using System.Net.Sockets;

namespace ConsoleApp
{
    public class Person
    {
        public string Name { get; set; }
        public Address Address { get; set; }

        //public Person DeepCopy()
        //{
        //    // Create a new Person object
        //    Person newPerson = (Person)this.MemberwiseClone();

        //    // Create a new Address object for the deep copy
        //    newPerson.Address = new Address
        //    {
        //        City = this.Address.City,
        //        Street = this.Address.Street
        //    };
        //    return newPerson;
        //}
        public Person DeepCopy()
        {
            Person newPerson = (Person)this.MemberwiseClone();

            newPerson.Address = new Address
            {
                City = this.Address.City,
                Street = this.Address.Street,
            };

            return newPerson;
        }
    }

    public class Address
    {
        public string City { get; set; }
        public string Street { get; set; }
    }

    public class Program
    {
        public static void Main()
        {
            Person person1 = new Person
            {
                Name = "John",
                Address = new Address { City = "New York", Street = "5th Avenue" }
            };

            // Deep copy
            Person person2 = person1.DeepCopy();

            // Modify the Address of person2
            person2.Address.City = "Washington D.c";

            // This will NOT affect person1 since Address is deep copied
            Console.WriteLine(person2.Address.City); // Output: New York
        }
    }
}
