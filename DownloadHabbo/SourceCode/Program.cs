using System;
using System.IO;
using System.Threading;

namespace ConsoleApplication
{
    internal class Program
    {

        private static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("          ***** DuckieTM 64BIT BASIC V2.0 The New Generation *****         ");
            Console.WriteLine("                   64K RAM SYSTEM 38911 BASIC BYTES FREE                   ");
            Console.WriteLine("READY.                                                                     ");
            string
            myText = "LOAD " + (char)34 + "Habboloader" + (char)34 + ",8,1";
            for (int i = 0; i < myText.Length; i++)
            {
                Console.Write(myText[i]);
                System.Threading.
                Thread.Sleep(10);
            }
            Console.WriteLine("                                                     ");
            Console.WriteLine("LOADING                                                                    ");
            Thread.Sleep(150);
            Console.WriteLine("READY.                                                                     ");
            string
            myText1 = "SYS 2048";
            for (int i = 0; i < myText1.Length; i++)
            {
                Console.Write(myText1[i]);
                System.Threading.
                Thread.Sleep(10);
            }
            Console.WriteLine("");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("                                                                           ");
            Console.WriteLine("Lets get the Show started : Booter loading....                             ");
            Console.WriteLine("                                                                           ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Title = "Loading The core ....";
            Console.WriteLine("");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            if (Directory.Exists("./temp"))
            {
                foreach (string path in Directory.GetFiles("./temp"))
                    File.Delete(path);
            }
            Console.WriteLine("Checking folders");

            if (!Directory.Exists("./effect"))
            {
                Console.WriteLine("We need to create the effect folder.");
                Directory.CreateDirectory("./effect");
                Thread.Sleep(100);
                Console.WriteLine("Created effect folder.");
            }

            if (!Directory.Exists("./hof_furni"))
            {
                Console.WriteLine("We need to create the hof_furni folder.");
                Directory.CreateDirectory("./hof_furni");
                Thread.Sleep(100);
                Console.WriteLine("Created hof_furni folder.");
            }
            if (!Directory.Exists("./quests"))
            {
                Console.WriteLine("We need to create the quests folder.");
                Directory.CreateDirectory("./quests");
                Thread.Sleep(100);
                Console.WriteLine("Created quests folder.");
            }
            if (!Directory.Exists("./reception"))
            {
                Console.WriteLine("We need to create the reception folder.");
                Directory.CreateDirectory("./reception");
                Thread.Sleep(100);
                Console.WriteLine("Created reception folder.");
            }
            if (!Directory.Exists("./reception/web_promo_small"))
            {
                Console.WriteLine("We need to create the reception/web_promo_small folder.");
                Directory.CreateDirectory("./reception/web_promo_small");
                Thread.Sleep(100);
                Console.WriteLine("Created reception/web_promo_small folder.");
            }
            if (!Directory.Exists("./badges"))
            {
                Console.WriteLine("We need to create the badges folder.");
                Directory.CreateDirectory("./badges");
                Thread.Sleep(100);
                Console.WriteLine("Created badges folder.");
            }
            if (!Directory.Exists("./icons"))
            {
                Console.WriteLine("We need to create the icons folder.");
                Directory.CreateDirectory("./icons");
                Thread.Sleep(100);
                Console.WriteLine("Created icons folder.");
            }
            if (!Directory.Exists("./files"))
            {
                Console.WriteLine("We need to create the files folder.");
                Directory.CreateDirectory("./files");
                Thread.Sleep(100);
                Console.WriteLine("Created files folder.");
            }
            if (!Directory.Exists("./mp3"))
            {
                Console.WriteLine("We need to create the mp3 folder.");
                Directory.CreateDirectory("./mp3");
                Thread.Sleep(100);
                Console.WriteLine("Created mp3 folder.");
            }

            if (!Directory.Exists("./clothes"))
            {
                Console.WriteLine("We need to create the clothes folder.");
                Directory.CreateDirectory("./clothes");
                Thread.Sleep(100);
                Console.WriteLine("Created clothes folder.");
            }

            if (!Directory.Exists("./Custom_clothes"))
            {
                Console.WriteLine("We need to create the Custom_clothes folder.");
                Directory.CreateDirectory("./Custom_clothes");
                Thread.Sleep(100);
                Console.WriteLine("Created Custom_clothes folder.");
            }
            Thread.Sleep(500);
            Console.ResetColor();
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("                          Avalible commands:                               ");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine("-> Download Furniture                                                      ");
            Console.WriteLine("-> Download Effects (Download the XML off all effects)                     ");
            Console.WriteLine("-> Download Icons                                                          ");
            Console.WriteLine("-> Download Productdata                                                    ");
            Console.WriteLine("-> Download Furnidata                                                      ");
            Console.WriteLine("-> Download Variables                                                      ");
            Console.WriteLine("-> Download Texts                                                          ");
            Console.WriteLine("-> Download Badges                                                         ");
            Console.WriteLine("-> Download MP3                                                            ");
            Console.WriteLine("-> Download Quests                                                         ");
            Console.WriteLine("-> Download Reception                                                      ");
            Console.WriteLine("-> clothes                                                                 ");
            Console.WriteLine("-> customclothes                                                           ");
            Console.WriteLine("-> Download custfurni                                                      ");
            Console.WriteLine("-> version                                                                 ");
            Console.WriteLine("-> Exit                                                                    ");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("System initialized. ready to download!");
            Console.WriteLine("Type \"help\" for a overview of commands!");
            Console.ForegroundColor = ConsoleColor.Gray;
            ConsoleCommandHandeling.InvokeCommand(Console.ReadLine());
        }
    }
}
