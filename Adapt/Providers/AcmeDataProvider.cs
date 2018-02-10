using System.Collections.Generic;

namespace Adapt.Providers
{
    /// <summary>
    /// DO NOT CHANGE DEMO DATA
    /// provides acme data
    /// </summary>
    public class AcmeDataProvider
    {
        public static dynamic BadDataList =>

            new List<object>
            {
                new
                {
                    isim = "Ahmet",
                    Soyisim = "Falanca"
                },
                new
                {
                    isim = "Turhan",
                    Soyisim = "Filanca"
                },
                new
                {
                    isim = "Kayu",
                    Soyisim = "Fisk"
                },
            };

    }
}