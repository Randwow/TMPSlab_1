using System;

namespace PrototypePattern
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ButtonManager buttonmanager = new ButtonManager();
            // Initialize with standard buttons
            buttonmanager["small"] = new Button(50,50,"red");
            buttonmanager["medium"] = new Button(100,100,"black");
            buttonmanager["big"] = new Button(150, 150, "green");
            // User adds personalized parameters
            buttonmanager["angry"] = new Button(25, 25, "red");
            buttonmanager["myCustemButton"] = new Button(50, 50, "black");
            buttonmanager["Nichita's Button"] = new Button(75, 75, "green");
            // User clones selected buttons
            Button button1 = buttonmanager["small"].Clone() as Button;
            Button button2 = buttonmanager["myCustemButton"].Clone() as Button;
            Button button3 = buttonmanager["big"].Clone() as Button;
            // Wait for user
            Console.ReadKey();
        }
    }
}
