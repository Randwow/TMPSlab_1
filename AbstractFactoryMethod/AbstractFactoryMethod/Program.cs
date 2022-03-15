using System;

namespace AbstractFactoryMethod
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Transport plane = new Transport(new Plane_F_35());
            plane.go();
            plane.onAuto();

            Transport car = new Transport(new TeslaModelS());
            car.go();
            car.onAuto();
        }
    }
}
