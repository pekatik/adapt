using System;
using System.Collections.Generic;
using System.Linq;
using Adapt.Adaptors;
using Adapt.Target;

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
        /// 
        /// 

        private static readonly Dictionary<short, ICompanyAdapter> CompanyDictionary = new Dictionary<short, ICompanyAdapter>
        {
            { 1, new TeslaCompanyAdapter() },
            { 2, new AcmeCompanyAdapter() }
      
        };


        static void Main()
        {
            // Create adapter and place a request
            Console.Write("Press any key to acme data. Press 1 for tesla provider data.");
            var selection = Console.ReadLine();

            var companyService = CompanyDictionary[Convert.ToInt16(selection)];

            Console.WriteLine(string.Join(",",  companyService.UserList().Select(x => x.Name+" "+x.SurName)));


            Console.ReadKey();
            Main();
        }
    }
}
