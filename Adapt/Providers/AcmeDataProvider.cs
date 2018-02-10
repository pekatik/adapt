using System.Collections.Generic;

namespace Adapt.Providers
{
    /// <summary>
    /// DO NOT CHANGE DEMO DATA
    /// provides acme data
    /// </summary>
    public class AcmeDataProvider
    {
        public  dynamic BadDataList =>

            new List<object>
            {
                new
                {
                    isim = "Ahmet",
                    Soyisim = "FENER"
                },
                new
                {
                    isim = "Turhan",
                    Soyisim = "GS"
                },
                new
                {
                    isim = "Kayu",
                    Soyisim = "BJK"
                },
            };

    }
}