using System;
namespace AbstractFactoryMethod
{
    public class Plane_F_35 : AbstractFactory
    {
        public override Autopilot CreateAutopilot()
        {
            return new AirPlane();
        }

        public override Movement CreateMovement()
        {
            return new FlyMovement();
        }
    }
}
