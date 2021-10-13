using industry;
using System;
using System.Collections.Generic;

//some variable
bool isRunning = true;
bool processing = true;

var orderNumber = 0;
var choosing = 0;
var amount = 0;

//other classes instance 
Warehouse warehouse = new Warehouse();
CarIndustry carIndustry = new CarIndustry(warehouse.Wheel, warehouse.MetalFromWarehouse);
WheelsIndustry wheelsIndustry = new WheelsIndustry(warehouse.RubbersToWheels, warehouse.Wheel);

//RubberIndustry rubber = new RubberIndustry();

//Start point for material as (1000)

for (int i = 0; i <= 19; i++)
{
    warehouse.Metal.Add(1);
    warehouse.Glass.Add(1);
    warehouse.Wood.Add(1);
    warehouse.Rubber.Add(1);
    //warehouse.Wheel.Add(1);
}

Console.WriteLine("welcome to the factory\n");
//Console.Write("Can we get your name plz... ");
//var customerName = Console.ReadLine();

List<string> products = new List<string> { "Car", "Bicycle", "Table" };
List<int> CarOrder = new List<int>();
List<int> BicOrder = new List<int>();
List<int> TableOrder = new List<int>();


while (isRunning)

{   //interfaceL: Layer 1

    Console.Write("Please provide your name: ");
    var customerName = Console.ReadLine();
    Console.Clear();
    Console.WriteLine($"Welcome to Group 1 Factory {customerName}\n");
    Console.WriteLine("\nWe Can produce:\n");
    for (int i = 0; i < products.Count; i++)
    {
        Console.WriteLine($"{i + 1}. " + products[i]);
    }

    orderNumber += 1; //increment ordernumbers by 1 if last one is done and new customer is arrived 

    choosing = Convert.ToInt32(Console.ReadLine());


    Console.WriteLine($"How much item of {products[choosing - 1]} do you want?\n");

    amount = Convert.ToInt32(Console.ReadLine());

    //if (products[choosing - 1] == "Car")
    //{
    for (int i = 0; i < amount; i++)
    {
        CarOrder.Add(i);
    }
    //}
    //else if (products[choosing - 1] == "Bicycle")
    //{
    //    for (int i = 0; i < amount; i++)
    //    {
    //        TableOrder.Add(i);
    //    }
    //Later   //}
    //else if (products[choosing - 1] == "Table")          ////Later
    //{
    //    for (int i = 0; i < amount; i++)
    //    {
    //        BicOrder.Add(i);
    //    }
    //}
    //else
    //{
    //    Console.WriteLine("we dont have this product");
    //    break;
    //}
    Console.WriteLine("=============================================================================================\n");
    Console.WriteLine($"Order #({orderNumber}): Cars ({CarOrder.Count}) | Tables ({TableOrder.Count}) | Bicycles ({BicOrder.Count})\n");
    Console.WriteLine("=============================================================================================\n");


    Console.WriteLine("Press: 1. To Confirm | 2. To Add more items");
    var customerDecision = Convert.ToInt32(Console.ReadLine());
    if (customerDecision == 1)
    {
        while (processing)
        {

            //Jump to Layer 2 
            Console.Clear();
            Console.WriteLine("Warehouse");
            Console.WriteLine("=========\n");
            Console.WriteLine($"Warehouse Status Wood: Metal: ({warehouse.Metal.Count}) MetalFromWarehouse: ({warehouse.MetalFromWarehouse.Count})\nRubber: ({warehouse.Rubber.Count}) | RubbersToWheels : ({warehouse.RubbersToWheels.Count}) Wheels: ({ warehouse.Wheel.Count})\nCars: ({warehouse.Car.Count}) | Tables: ({warehouse.Table.Count}) | Bicycle: ({warehouse.Bicycle.Count})");

            Console.WriteLine("=============================================================================================");
            Console.WriteLine($"Order #({orderNumber}): Cars ({CarOrder.Count}) | Tables ({TableOrder.Count}) | Bicycles ({BicOrder.Count})\n");
            Console.WriteLine("=============================================================================================\n\n");

            Console.WriteLine("Producing:\n");
            Console.WriteLine("Press: 1. To Produce a Car | 2. To Produce ...");
            //ConsoleKeyInfo key = Console.ReadKey();
            var warehouseEmployee = Convert.ToInt32(Console.ReadLine());

            switch (warehouseEmployee)
            {

                case 1: //For now i will send order quantity and do some calc but in next version i will make it also to send static number 


                    carIndustry.CarProduction(CarOrder);
                    
                    warehouse.CheckingInventories(CarOrder, orderNumber, processing);

                    Console.WriteLine("\n\n1. Sending Metal to Car Factory");
                    Console.WriteLine("2. Sending Rubber to Rubber Factory");
                    Console.WriteLine("3. Producing Wheels");

                    var sending = Convert.ToInt32(Console.ReadLine());
                    switch (sending)
                    {
                        case 1:
                            warehouse.MetalToCarIndustry(CarOrder);
                            Console.ReadKey(true);
                            break;

                        case 2:
                            warehouse.RubberToWheelsIndustry(CarOrder);
                            break;

                        case 3:
                            Console.Write("How much wheels do you want? ");
                            var quantity = Convert.ToInt32(Console.ReadLine());
                            wheelsIndustry.WheelsProduction(CarOrder, orderNumber, quantity);
                            Console.ReadKey(true);
                            break;
                    }

                    break;
            }

            //OtherOption come later
        }
    }
}
