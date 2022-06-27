using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool? truth;
            //onnistuu true tai false arvot.
            //truth = true; truth = false;
            //null arvo ei onnistu ilman kysymysmerkkiä. ennen bool arvoa. eli ennen annettua arvoa (string, int, bool, jne.)
            truth = null;

            //tulostaa false, koska on bool arvo, joka aina palauttaa true tai false. nyt sisällä ei ole arvoa, joten se on false.
            Console.WriteLine(truth.HasValue);

            int? lie;
            lie = null;

            Console.WriteLine(lie);


            List<City> cities = new List<City>()
            {
            new City("Kuopio", 25),
            new City("Kerava", 22),
            new City("Tampere", 13),
            new City("Helsinki", null),
            new City("Turku", 32),
            new City("Lieksa", 12),
            };

            Console.WriteLine("Give ta first letter of the city: ");
            string firstLetter = Console.ReadLine();

            var foundCities = cities.Where(n => n.Name.StartsWith(firstLetter.ToUpper()));

            //var result = cities.Where(n => n.StartsWith(firstLetter));

            foreach(var city in cities)
            {
                if (city.Weather == null)
                {
                    continue;
                }
                Console.Write(city.Name + "lämpötila on tänään " + city.Weather + "C. ");
                Console.WriteLine("Fahrenheit: " + city.GetFahrenheit(city.Weather));

            }


            City newCity = null;
            try
            {
                Console.WriteLine(newCity.Weather);
            }
            catch(Exception e)
            {
                Console.WriteLine("Error! City not found");
            }


        }
    }

    public class City
    {
        public string Name;
        public int? Weather;

        public City(string name, int? weather)
        {
            this.Weather = weather;
            this.Name = name;
        }
        //metodin on oltava classin sisällä.
        public double? GetFahrenheit(int? celcius)
        {
            return celcius * 1.8;

        }
    }

    
}
