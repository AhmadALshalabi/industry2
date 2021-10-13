using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace industry
{
    class Warehouse 
    {

        //Why i cant make instance from Other classes here ??? 
        public List<int> Glass { get; set; } = new List<int>();
        public List<int> Wood { get; set; } = new List<int>();
        public List<int> Rubber { get; set; } = new List<int>();
        public List<int> Metal { get; set; } = new List<int>();
     
        //Products

        public List<int> Wheel { get; set; } = new List<int>();   // A wheel need 2 Rubbers
        public List<int> Table { get; set; } = new List<int>();   // A table need 4 woods 
        public List<int> Bicycle { get; set; } = new List<int>(); // A bicycle need 2 wheels & 1 metal 
        public List<int> Car { get; set; } = new List<int>();     // A car need 4 wheels & 2 Metal

        //Implementing interfaces for WheelIndustry
        public List<int> RubbersToWheels { get; set; } = new List<int>();

        //Implementing interfaces for CarIndustry
        public List<int> MetalFromWarehouse { get; set; } = new List<int>();


        //Sending items to Car Industry
        public void MetalToCarIndustry(List<int> carOrder)
        {
            for (int i = 0; i < 2 * carOrder.Count; i++)
            {
                if (Metal.Count >= 2)
                {
                    MetalFromWarehouse.Add(1);
                    Metal.Remove(1);
                }
            }
            Console.WriteLine($" ({2 * carOrder.Count}) Metal Had Been Sent");
        }
     
        //Sending items to Wheels Industry
        public void RubberToWheelsIndustry(List<int> Calc) //this param should be int because warehouse employee will control 
        {

            for (int i = 0; i < 8 * Calc.Count; i++)
            {
                if (Rubber.Count > 2)
                {
                    RubbersToWheels.Add(1);
                    Rubber.Remove(1);
                }
            }
            Console.WriteLine($"({8 * Calc.Count}) Rubbers had been sent to wheel factory!");
            Console.ReadKey();
        }
      
        public void CheckingInventories(List<int> carOrder, int order, bool process)
        {
            //What happen if warehouse employee sent more Rubber than order need? will you keep it in WheelsIndustry inventory 
            //or send it back to warehouse? 

            if (carOrder.Count == Car.Count) // it should be in warehouse
            {
                Console.WriteLine($"\nOrder#{order} is Complete");

                // warehouse.Car.Clear(); to study
                // warehouse.Wheel.Clear(); to study                
            }

            if (carOrder.Count == 0)
            {

                if (Rubber.Count >= 1 || Metal.Count >= 1 && carOrder.Count == 0)
                {
                    Console.WriteLine("Do you want to keep those extra Rubber here or send back to Warehouse? Y/N");
                    var wheelIndustryResponse = Console.ReadLine().ToLower();

                    if (wheelIndustryResponse == "y")
                    {
                        Console.WriteLine("Ok raw material will not move!");
                    }
                    else
                    {
                        for (int i = 0; i < RubbersToWheels.Count; i++)
                        {
                            Rubber.Add(1);
                        }

                        for (int i = 0; i < MetalFromWarehouse.Count; i++)
                        {
                            Metal.Add(1);
                        }

                        RubbersToWheels.Clear(); // i think its not necessary
                        MetalFromWarehouse.Clear(); // i think its not necessary
                    }
                }
            }
        }


    }
}

