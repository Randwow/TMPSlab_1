using System;
namespace AbstractFactoryMethod
{
    public class AirPlane: Autopilot
    {
        public override void onAutopilot()
        {
            Console.WriteLine("Включение автопилота на самолете \n");
        }
    }
}
