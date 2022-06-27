using System;
using System.Threading;

namespace ExtensionMethodsExerciseNiki
{

    public class Raffle
    {
        public bool victory;


            // display welcome message
            public void Welcome()
            {
                Console.WriteLine("\n\n*********************************");
                Console.WriteLine("Welcome to the lotto game\n");
            }

            // show dots while raffling
            static void ShowDots()
            {
                int i = 0;
                while (i < 3)
                {
                    Console.Write(".");
                    Thread.Sleep(1000);
                    i++;
                }
                Console.WriteLine("\n\n");
            }

            void GetResult()
            {
                var rand = new Random();
                if (rand.Next(100) > 70)
                {
                    this.victory = true;
                }
                else
                {
                    this.victory = false;
                }
            }

            // play the game
            public void Play()
            {
                Console.WriteLine("Press any key to play\n");
                Console.ReadKey(true);
                Console.Write("Raffling ");
                ShowDots();
                GetResult();
            }
        }

    // opettajan esimerkki
    public static class Extensions
    {
        // exmetodin nimi on Price(this kutsutaan Raffle luokasta, ja annetaan tyyppi stringille nimi 
        public static void Price(this Raffle raffle, string price)
        {
            Console.WriteLine("You won " + price);
           //tällä tyylillä kutsussa ei tarvitse antaa arvoa.
           //Console.WriteLine("You won 1 million euros");
        }

    }


        class Exercise
        {
            static void Main(string[] args)
            {

                Raffle lotto = new Raffle();

                lotto.Welcome();
                lotto.Play();
                
                //lotto.Prize();

                if (lotto.victory)
                {
                    Console.WriteLine(" Congratulations! You won! \n");
                    lotto.Price("1 million euros");
                //tässä on toinen tapa kutsua exMetodia. 
                //lotto.Price();

                }
                else
                {
                    Console.WriteLine(" You lost :( \n");
                }

                Console.WriteLine("*********************************");
            }
        }

    /*
     * oma yritys mikä meni pitkin vittua.
    public static class ExtensionPrize
    {

    //meni vituiksi kun kutsuin väärästä paikasta. kutsuin metodia enkä luokkaa.
        public static string Prize(this bool victory, string Palkinto)
        {
            string Palkinto = "Miljoona";
            string result = victory = Palkinto;
            return result;
        }

    }
    */


}
