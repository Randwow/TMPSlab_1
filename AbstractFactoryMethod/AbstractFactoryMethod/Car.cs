using System;
namespace AbstractFactoryMethod
{
    public class Car:Autopilot
    {
        public override void onAutopilot()
        {
            Console.WriteLine("Машина может ездить на автопилоте \n");
        }
    }
}
