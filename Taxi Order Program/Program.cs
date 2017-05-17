using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi_Order_Program
{
    class Program
    {
        static void Main(string[] args)
        {

            Customer one = new Customer("Rafiq", +994517474277, 50, 60, 140, 280);
            Console.WriteLine("Musterinin adi: " + one.Ad + "\n" + "Telefonu: " + "+" + one.TEL + "\n" + "Dayandigi yerin koordinatlar: " + one.In_latit + ":" + one.In_longtit + "\n" + "Gedeceyi Yerin Koordinatlari: " + one.O_latit + ":" + one.O_longtit + "\n" + "Mebleg: " + one.mebleg() + "man" +  "\n" + "Sefer muddeti: " + one.vaxt() + "deq");

            Taxi taxOne = new Taxi("Vuqar", 10, "BC", 254, 90, 90, one.In_latit, one.In_longtit);
            Taxi taxTwo = new Taxi("Valeh", 90, "SS", 054, 20, 70, one.In_latit, one.In_longtit);
            Taxi taxThree = new Taxi("Elman", 10, "JH", 111, 30, 10, one.In_latit, one.In_longtit);


            List<int> Mytaxi = new List<int>();
            Mytaxi.Add(taxOne.hesabla());
            Mytaxi.Add(taxTwo.hesabla());
            Mytaxi.Add(taxThree.hesabla());
            Mytaxi.Sort();
            Console.WriteLine(Mytaxi[0].Equals(taxTwo.hesabla()));
            bool a = Convert.ToBoolean(Mytaxi[0]);

            if (a)
            {
                Console.WriteLine("Taksi surucusunun adi: " + taxOne.Adi + "\n" + "Masin nomresi: " + taxOne.City_code + " " + taxOne.Seria + " " + taxOne.Number);
            }
            else if (a) {
                Console.WriteLine("Taksi surucusunun adi: " + taxTwo.Adi + "\n" + "Masin nomresi: " + taxTwo.City_code + " " + taxTwo.Seria + " " + taxOne.Number);
            }
            else
            {
                Console.WriteLine("Taksi surucusunun adi: " + taxTwo.Adi + "\n" + "Masin nomresi: " + taxTwo.City_code + " " + taxTwo.Seria + " " + taxOne.Number);
            }

            //Console.WriteLine()
            Console.ReadLine();

            
        }

    }
}
