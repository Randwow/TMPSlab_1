using System;
namespace AbstractFactoryMethod
{
    public class TeslaModelS:AbstractFactory
    {
        public override Movement CreateMovement()
        {
            return new DriveMovement();
        }

        public override Autopilot CreateAutopilot()
        {
            return new Car();
        }
    }
}
