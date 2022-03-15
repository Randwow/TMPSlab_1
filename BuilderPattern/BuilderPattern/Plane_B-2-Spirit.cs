using System;
namespace BuilderPattern
{
    class Plane_B_2_Spirit: PlaneBuilder
    {
        public override void setWidth()
        {
            this.plane.width = new WidthClass { widthOfPlane = 12 };
        }

        public override void setHeight()
        {
            this.plane.height = new HeightClass { heightOfPlane = 10 };
        }

        public override void setNameOfPilot()
        {
            this.plane.name = new NameOfPilotClass { name_of_pilot = " Nichita " };
        }

        public override void setNumberOfRocket()
        {
            this.plane.rocket_counter = new NumberOfRocketClass { number_of_rocket = 8 };
        }

        public override void setCapacityTank()
        {
            this.plane.capacity_of_tank = new CapacityOfTankClass { volume_of_the_tank = 150 };
        }
    }
}
