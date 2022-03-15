using System;
using System.Text;

namespace BuilderPattern
{
    public class AirPlane
    {
        public CapacityOfTankClass capacity_of_tank { get; set; }

        public HeightClass height { get; set; }

        public WidthClass width { get; set; }

        public NameOfPilotClass name { get; set; }

        public NumberOfRocketClass rocket_counter { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (!String.IsNullOrEmpty(name.name_of_pilot))
                sb.Append("Имя пилота: "+ name.name_of_pilot +  "\n");

            if (height != null)
                sb.Append("Ширина самолета: " + height.heightOfPlane + "\n");

            if (width != null)
                sb.Append("Высота: " + width.widthOfPlane + " \n");

            if (rocket_counter.number_of_rocket >= 0)
            {
                sb.Append("Количество ракет: " + rocket_counter.number_of_rocket + " \n");
            }else {
                sb.Append("Самолет какой-то странный имеет меньше 0 ракет наа борту ?:) \n");
            }

            if (capacity_of_tank.volume_of_the_tank > 100)
            {
                sb.Append("Вместимость топливного бака: " + capacity_of_tank.volume_of_the_tank + " \n");
            }else {
                sb.Append("Странный топливный бак, который меньше 100л ?) \n");
            }
            return sb.ToString();
        }

    }
}
