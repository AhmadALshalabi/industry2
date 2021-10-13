using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace industry
{
    class CarIndustry
    {
     
        
        public List<int> Ewheel { get; set; }
        public List<int> IMetalFromWarehouse { get; set; }
      
        public CarIndustry(List<int> wheel, List<int> metalfromwarehouse)
        {
            Ewheel = wheel;
            IMetalFromWarehouse = metalfromwarehouse;
        }

        public void CarProduction(List<int> carOrder)
        {
            for (int i = 0; i < carOrder.Count; i++)
            {
                if (IMetalFromWarehouse.Count >= (2 * carOrder.Count) && Ewheel.Count >= (4 * carOrder.Count))
                {
                    //Car.Add(1);
                    IMetalFromWarehouse.Remove(2);
                    Ewheel.Remove(4);
                    Console.WriteLine($"{carOrder.Count} car/s had been produced!");
                    carOrder.Remove(1);

                }
            }

            if (Ewheel.Count < (4 * carOrder.Count))
            {

                Console.WriteLine($"we are missing Wheels to produce a Car! Contact warehouse to send {(8 * carOrder.Count) - Ewheel.Count} Rubbers to Wheels Factory!");
                Console.WriteLine("Sending...");
            }

            if (IMetalFromWarehouse.Count < (2 * carOrder.Count))
            {
                Console.WriteLine($"we are missing Metal to produce a Car! Contact warehouse to send {(2 * carOrder.Count) - IMetalFromWarehouse.Count} Metal to Car Factory!");
                Console.WriteLine("Sending...");
            }
        }


    }
}
