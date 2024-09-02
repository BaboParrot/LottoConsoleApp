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
            for(int i=0;i<lottoLapp.Length;i++)
            {
                lottoLapp[i] = random.Next(1, 35);
            }

            //nå har vi en ferdig lottolapp

            //2 - systemet skal trekke 7 tall og putte det i en array lottoTall. Samme som over.

            //3 - Sjekke hvor mange rette man har

            foreach(int i in lottoLapp)
            {
                
            }

            //           Skrive ut antall rette:
            Console.WriteLine(antallRette);

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
