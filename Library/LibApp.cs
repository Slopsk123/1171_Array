using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library;

internal class LibApp
{
    public void Run()
    {
        var magazines = new Magazine[15];
        Random random = new Random();
        int min = 101;
        int avr = 0;
        var minName = "";


        for (int i = 0; i < magazines.Length; i++)
        {
            magazines[i] = new Magazine(NameGenerator(), NameGenerator(), random.Next(1,13), random.Next(1,100));
            avr += magazines[i].Pages;
            if(min > magazines[i].Pages)
            {
                min = magazines[i].Pages;
                minName = magazines[i].Name;
            }

        }
        // prumerny pocet stranek
        avr = avr/magazines.Length;
        Console.WriteLine(avr);

        //minimalni pocet stranek
        Console.WriteLine($"nejmenší počet stránek je :{min}");
        Console.WriteLine($"název knihy s nejmenším počtem stránek je {minName}");
    }
    // Tohle jsem ukradl z minuleho projektu
    public string NameGenerator()
    {
        Random random = new Random();
        string name = "";
        char[] samohlasky = { 'a', 'e', 'i', 'o', 'u', 'y' };
        for (int j = 0; j < 3; j++)
        {
            if (j % 2 == random.Next(0, 2))
            {
                name += samohlasky[random.Next(0, 6)];
            }
            else
            {
                name += (char)(random.Next(97, 122));
            }
        }
        return name;
    }
}
