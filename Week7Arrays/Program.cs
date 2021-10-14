using System;

namespace Week7Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab kasutajale hommikusöögi menüüd 
            //programm palub kasutajal teha valikut
            //programm kuvab kasutaja valikut konsoolis

            string[] menu = { "omlett,", "pannkoogid", "keedumuna", "neljaviljapuder", "singivõileib" };
            Console.WriteLine($"Meie menüüs on {menu.Length} valikut");

            // menu[4] = "juustuvõileib";
            // menu[3] = "kaerapuder";

            Console.WriteLine("Tänases menüüs:");
            
            for(int i = 0; i < menu.Length; i++)
            {
                if(menu[i] == "neljaviljapuder")
                {
                    menu[i] = "kareapuder";
                }

                else if(menu[i] == "singivõileib")
                {
                    menu[i] = "juustuvõileib";
                }
                Console.WriteLine(menu[i]);              
            }
            Console.WriteLine("Tee palun oma valik(sisesta numbe 1-5):");
            int userChoice = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.WriteLine($"Sa oled valinud {menu[userChoice]}");

            /*foreach(string menuElement in menu)
            {               
                Console.WriteLine(menuElement);
            }*/
        }
    }
}
