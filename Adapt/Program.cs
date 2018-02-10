using System;
using System.Linq;
using Adapt.Adaptors;

namespace Adapt
{
    /// <summary>
    /// MainApp startup class for Structural
    /// Adapter Design Pattern.
    /// </summary>
    class MainApp

    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        static void Main()
        {
            // Create adapter and place a request
            Console.Write("Press any key to acme data. Press 1 for tesla provider data.");
            var selection = Console.ReadLine();
            

            if (selection == "1")
            {
                Console.WriteLine("tesla provider selected");
                Console.WriteLine(string.Join(",", new TeslaCompanyAdapter().UserList().Select(x => x.Name)));
            }
            else
            {
                Console.WriteLine("acme provider selected");
                Console.WriteLine(string.Join(",", new AcmeCompanyAdapter().UserList().Select(x => x.Name)));
            }

            Console.ReadKey();
            Main();
        }
    }
}
