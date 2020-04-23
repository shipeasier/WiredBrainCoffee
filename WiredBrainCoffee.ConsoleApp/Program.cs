using System;
using WiredBrainCoffee.Simulators;

namespace WiredBrainCoffee.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var coffeeMachine = new CoffeeMachine();
            coffeeMachine.MakeCappuccino();
            coffeeMachine.MakeCappuccino();
            
            Console.WriteLine($"Counter cappuccino : {  coffeeMachine.CounterCappuccino}");

        }
    }
}
