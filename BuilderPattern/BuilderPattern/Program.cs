using System;

namespace BuilderPattern
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Создаем строителя

            DirectorClass director = new DirectorClass();

            //Создаем билдера для каждого самолета и билдим их

            PlaneBuilder builder = new Plane_F_35();

            AirPlane f_35 = director.Create(builder);
            Console.WriteLine("Название самолета F-35 \n" + f_35.ToString());

            builder = new Plane_B_2_Spirit();

            AirPlane B_2_spirit = director.Create(builder);
            Console.WriteLine("Название самолета B-2 Spirit \n" + B_2_spirit.ToString());

            builder = new Plane_Raptor();

            AirPlane raptor = director.Create(builder);
            Console.WriteLine("Название самолета Raptor \n" + raptor.ToString());
        }
    }
}
