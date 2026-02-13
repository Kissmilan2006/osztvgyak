// See https://aka.ms/new-console-template for more information
using RealEstate.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    public static double DistanceTo(string kordinate)
    {
        double a = 47.4164220114023;
        double b = 19.066342425796986;
        string[] darabolo = new string[2];
        darabolo = kordinate.Split(',');

        double dx = a - Convert.ToDouble(darabolo[0], CultureInfo.InvariantCulture);
        double dy = b - Convert.ToDouble(darabolo[1], CultureInfo.InvariantCulture);
        return Math.Sqrt(dx * dx + dy * dy);


    }
    static void Main()
    {
        List<Ad> ads = Ad.LoadFromJson("ingatlanok.json");

        float area = 0;
        float count = 0;

        for (int i = 0; i < ads.Count; i++)
        {
            if (ads[i].Floors == 0)
            {
                area += ads[i].Area;
                count++;
            }
        }

        Console.WriteLine(Math.Round((area / count), 2));

        double distance = DistanceTo(ads[0].LatLong);
        double numb = 0;
        int result = 0;

        for (int i = 0; i < ads.Count; i++)
        {
            if (ads[i].FreeOfCharge)
            {
                numb = DistanceTo(ads[0].LatLong);
                if (numb < distance)
                {
                    result = i;
                    distance = numb;
                }
            }
        }
        Console.WriteLine("2. Mesevár óvodához légvonalban legközelebbi tehermentes ingatlan adatai:");
        Console.WriteLine("     Előadó neve     :" + ads[result].Seller.Name);
        Console.WriteLine("     Előadó Telefonja:" + ads[result].Seller.Phone);
        Console.WriteLine("     Alapterület     :" + ads[result].Area);
        Console.WriteLine("     Szobá kszáma    :" + ads[result].Rooms);

        Console.ReadLine();
    }

           

}



