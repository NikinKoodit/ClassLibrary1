using System;
using System.Runtime;

namespace ClassLibrary1
{
    public class Class1
    {
        
        public bool Totuus { get; set; }
        public DateTime StartLearninDate { get; set; }
        public bool InProgress { get; set; }
        public DateTime CompletionDate { get; set;}

        public string Paivat()
        {
            return $"Olet myöhässä!{(CompletionDate - StartLearninDate).TotalDays}";
        }

        public void Tarkistus()
        {
            if (CompletionDate > DateTime.Today)
            {
                Totuus = true;

            }

            else
            {
                Totuus = false;
            }

        }

        public void Myohassa()
        {
            if (InProgress == false)
            {
                if(CompletionDate <= DateTime.Today)
                {
                    TimeSpan i = new TimeSpan(); 
                    //(CompletionDate - StartLearninDate)i.TotalDays;
                    Console.WriteLine(Paivat());

                }
            }

            else
            {
                Console.WriteLine("Opiskelusi on aikataulussa.");
            }

        }


    }
}
