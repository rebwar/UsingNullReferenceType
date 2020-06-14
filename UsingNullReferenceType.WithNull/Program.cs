using System;

namespace UsingNullReferenceType.WithNull
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Rebwar", "Poori");
            Person person1 = new Person("Rebwar", "Hosein", "Poori");
            Console.WriteLine($"Welcome, {person.Name} {person.LastName}");
           Console.WriteLine($"The Length of {person.Middle}={GetMiddleLength(person)}");
            Console.WriteLine("---------------------------");
            Console.WriteLine($"Welcome, {person1.Name} {person1.Middle} {person1.LastName}");
            Console.WriteLine($"The Length of {person1.Middle}={GetMiddleLength(person1)}");

        }
        static int GetMiddleLength(Person person)
        {
            var middleName = person.Middle;
            return middleName?.Length ?? 0;
        }
    }
}
