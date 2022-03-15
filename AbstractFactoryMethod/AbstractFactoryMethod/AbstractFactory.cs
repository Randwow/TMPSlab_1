using System;
namespace AbstractFactoryMethod
{
    public abstract class AbstractFactory
    {
        public abstract Movement CreateMovement();

        public abstract Autopilot CreateAutopilot();

    }
}
