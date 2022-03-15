using System;
namespace PrototypePattern
{
    public class Button: ButtonPrototype
    {
        int width = 0;
        int height = 0;
        string color = "";

        public Button(int width, int height, string color)
        {
            this.color = color;
            this.height = height;
            this.width = width;
        }

        public override ButtonPrototype Clone()
        {
            Console.WriteLine("Cloning button with width = {0,3}, height = {1,3}, and color: {2,3}", width,height,color);
            return this.MemberwiseClone() as ButtonPrototype;
        }
    }
}
