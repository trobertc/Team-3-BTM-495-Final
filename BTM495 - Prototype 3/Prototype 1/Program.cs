using Microsoft.VisualBasic.Logging;

namespace Prototype_1
{
    class Program
    {
        static void Main()
        {
            // Fill Adoption Form example
            Client client = new Client();
            Cat cat = new Cat(1, 1, "male", "brown", "medium", "cat", false);
            Dog dog = new Dog(1, 1, "female", "brown", "not medium", "dog", true);
            Dictionary<int, Animal> animals = new Dictionary<int, Animal>
        {
            { 1, dog },
            { 2, cat },
        };

            Console.WriteLine("Available Animals:");
            foreach (var entry in animals)
            {
                Console.WriteLine($"{entry.Key}. {entry.Value.Name}");
            }

            Console.Write("Select an animal (enter the number): ");
            int selectedAnimalKey = int.Parse(Console.ReadLine());

            Console.ReadKey();

            client.applyAdopt(animals[selectedAnimalKey]);



            // Book Appointment example
            Client client2 = new Client();
            Console.WriteLine("What date and time would work best for you?");
            DateTime dateTime = DateTime.Parse(Console.ReadLine());
            client2.bookAppoint(dateTime);


            // Process Payment example
            Accountant accountant = new Accountant(1, "jeff", DateTime.Now, 10);
            Invoice invoice = new Invoice( 1001, 100, 100, DateTime.Now, new DateTime(2023, 12, 16));


            Console.WriteLine($"How much of your balance of {invoice.Balance} will you be paying?");
            string pmtAmount = Console.ReadLine();
            double paymentAmount = double.Parse(pmtAmount);
            accountant.ProcessPmt(invoice, paymentAmount);
            Console.WriteLine($"Your balance is now ${invoice.Balance}.);



        }
    }
}