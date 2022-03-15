using System;
namespace AbstractFactoryMethod
{
    public class FlyMovement:Movement
    {
        public override void Move()
        {
            Console.WriteLine("Летим \n");
        }
    }
}
