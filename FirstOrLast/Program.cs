using System;

namespace FirstOrLast
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada ees- ja perekonnanimi
            //programm kontrollib andmete pikkust
            //programm kuvab kumb nendest on pikem, kas ees- või perekonnanimi (IF)

            Console.WriteLine("Sisesta eesnimi:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Sisesta perekonnanimi:");
            string lastName = Console.ReadLine();

            int firstNameLength = firstName.Length;
            int lastNameLength = lastName.Length;
            //Console.WriteLine($"Sinu eesnimes on {firstName.Length} ja perekonnanimes {lastName.Length} sümbolit.");
            
            if(firstNameLength > lastNameLength)
            {
                Console.WriteLine("Eesnimi on pikem.");
            }
            else if(firstNameLength < lastNameLength)
            {
                Console.WriteLine("Perekonnanimi on pikem.");
            }
            else
            {
                Console.WriteLine("Ees- ja perekonnanimi on ühepikkused.");
            }

            Console.WriteLine($"Kena päeva!");
        }
    }
}
