using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LottoConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int antallRette = 0;
            Random random = new Random();
            //1 - trekke 7 tall, vi tar det vha random
            int[] lottoLapp = new int[7];
            HashSet<int> UlikeTall = new HashSet<int>(); // bruker hashset til å holde oversikt på hvilke tall som har blitt trukket. Hashset kan ikke ha duplikate verdier.
            for (int i = 0; i < lottoLapp.Length; i++)
            {
                int number;
                do
                {
                    number = random.Next(1, 35);
                } while (!UlikeTall.Add(number)); // sørger for at den finner en ny verdi helt til det kommer en verdi som ikke har blitt nevnt. 
                lottoLapp[i] = number;  
            }



                //nå har vi en ferdig lottolapp

                //2 - systemet skal trekke 7 tall og putte det i en array lottoTall. Samme som over.

                int[] lottoSystem = new int[7];
            UlikeTall.Clear();
            for (int i = 0; i < lottoSystem.Length; i++) // denne delen gjør det samme men for LottoSystem. 
            {
                int number;
                do
                {
                    number = random.Next(1, 35);
                } while(UlikeTall.Add(number));
                lottoSystem[i] = number;
            }

            //3 - Sjekke hvor mange rette man har


            foreach (int i in lottoLapp)
            {
                bool found=FindNumber(i, lottoSystem);
                if(found)
                    antallRette++;
            }

            //           Skrive ut antall rette:
            Console.WriteLine(antallRette);
            Console.ReadLine();

        }

        /// <summary>
        /// Leter etter et spesifikt tall i en array. Returnerer true om funnet.
        /// </summary>
        /// <param name="userNum"></param>
        /// <param name="lottoNum"></param>
        /// <returns> bool</returns>
        public static bool FindNumber(int userNum,int[] lottoNum)
        {            
            foreach(int num in lottoNum)
            {
                if(num==userNum)
                    return true;
            }
            return false;
        }
    }
}
