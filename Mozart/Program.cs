using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Mozart
{
    class Program
    {
        static SoundPlayer sp = new SoundPlayer();
        static void Main(string[] args)
        {
            Minuetten();

            Trioen();
        }
        static void Minuetten()
        {
            string path = @"C:\Users\rasmu\source\repos\Mozart\Mozart\Mozart\Wave\M";
            string[] files = new string[177];

            for (int i = 1; i < files.Length; i++)
            {
                files[i] = path + i + ".wav";
                Console.WriteLine(files[i]);

                sp.SoundLocation = files[i];
                sp.Load();
                sp.PlaySync();
            }
        }
        static void Trioen()
        {
            string path = @"C:\Users\rasmu\source\repos\Mozart\Mozart\Mozart\Wave\T";
            string[] files = new string[97];

            for (int i = 1; i < files.Length; i++)
            {
                files[i] = path + i + ".wav";
                Console.WriteLine(files[i]);

                sp.SoundLocation = files[i];
                sp.Load();
                sp.PlaySync();
            }
        }
    }
}