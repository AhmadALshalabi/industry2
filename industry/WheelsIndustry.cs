using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace industry
{
    //Q: Ideas how to return directly to a field of type list throw return keyword? 



    class WheelsIndustry
    {
        public List<int> ERubber { get; set; }
        public List<int> EWheel { get; set; }

        public WheelsIndustry(List<int> r , List<int> w)
        {
            ERubber = r;
            EWheel = w;
        }
        public void WheelsProduction(List<int> carOrder, int order, int quantity)
        {
            if (ERubber.Count < 2)
            {
                if (ERubber.Count >= 2 && EWheel.Count < 1)
                {
                    Console.WriteLine("Calling warehouse Ring Ring... Ring Ring...");
                    //i can calculate how much rubbers i need to fullfill order or warehouse employee can send more
                    Console.WriteLine($"Hi warehouse i see ({ERubber.Count}) Rubbers please send ({8 * carOrder.Count}) to complete the order #{order}");
                }
                else
                {
                    Console.WriteLine("we have wheels");
                }
                Console.ReadKey(true);
            }

            else
            {
                Console.Clear();
                for (int j = 0; j < quantity; j++)
                {
                    if (ERubber.Count >= 2)
                    {
                        Console.WriteLine("Processing Wheels");
                        Console.WriteLine("Wheel had been produced and sent to warehouse");
                        ERubber.Remove(1);
                        ERubber.Remove(1);
                        EWheel.Add(1); //send to warehouse

                    }
                    else
                    {
                        Console.WriteLine("WheelsIndustry inventory Does Not have enough raw material");
                    }
                }
            }     
        }
    }
}
