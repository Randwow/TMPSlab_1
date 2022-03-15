using System;
namespace AbstractFactoryMethod
{
    public class DriveMovement:Movement
    {
        public override void Move()
        {
            Console.WriteLine("Едим \n");
        }
    }
}
