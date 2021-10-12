using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace industry
{
    class CarIndustry : Warehouse
    {

        public void test()
        {

            for (int i = 0; i < metaltest.Count; i++)
            {
                Console.WriteLine(i);
            }
        }

        //public  void CarProduction(List<int> carOrder)
        //{
        //    for (int i = 0; i < carOrder.Count; i++)
        //    {
        //        if (MetalFromWarehouse.Count >= (2 * carOrder.Count) && Wheel.Count >= (4 * carOrder.Count))
        //        {
        //            Car.Add(1);
        //            MetalFromWarehouse.Remove(2);
        //            Wheel.Remove(4);
        //            Console.WriteLine($"{carOrder.Count} car/s had been produced!");
        //            carOrder.Remove(1);

        //        }
        //    }


        //    if (Wheel.Count < (4 * carOrder.Count))
        //    {

        //        Console.WriteLine($"we are missing Wheels to produce a Car! Contact warehouse to send {(8 * carOrder.Count) - Wheel.Count} Rubbers to Wheels Factory!");
        //        Console.WriteLine("Sending...");
        //    }

        //    if (MetalFromWarehouse.Count < (2 * carOrder.Count))
        //    {
        //        Console.WriteLine($"we are missing Metal to produce a Car! Contact warehouse to send {(2 * carOrder.Count) - MetalFromWarehouse.Count} Metal to Car Factory!");
        //        Console.WriteLine("Sending...");
        //    }
        //}


    }
}
