using System;
using LamdaHarjoitus.Models;
using System.Linq;

namespace LamdaHarjoitus
{
    class Program
    {
        static void Main(string[] args)
        {

            using (TestiContext testiYhteys = new TestiContext())
            {
                //paikallisesti tehty topic olio.
                var taulu = testiYhteys.Topics.Select(topikki => topikki);
                Topic uusi = new Topic()
                {
                    Id = 1,
                    Title = "Title",
                    Descrpition = "Testi",
                    TimeToMaster = 3,
                    TimeSpent = 2,
                    StartLearningDate = DateTime.Now,
                    InProgress = false,


                };
                //mikä,minne,mitä
                testiYhteys.Topics.Add(uusi);
                //tallennamuutokset
                testiYhteys.SaveChanges();

                taulu = testiYhteys.Topics.Select(topikki => topikki);
                foreach(var rivi in taulu)
                {
                    Console.WriteLine(rivi.Descrpition);
                }

                //Console.WriteLine(taulu);


            }
        }
    }
}
