using System;
namespace AbstractFactoryMethod
{
    class Transport
    {
        private Movement movement;

        private Autopilot autopilot;
         
        public Transport(AbstractFactory factory)
        {
            movement = factory.CreateMovement();
            autopilot = factory.CreateAutopilot();
        }
        public void go() {
            movement.Move();
        }
        public void onAuto() {
            autopilot.onAutopilot();
        }
    }
}
