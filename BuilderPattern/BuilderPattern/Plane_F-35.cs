using System;
namespace BuilderPattern
{

    class Plane_F_35 : PlaneBuilder
    {
        public override void setWidth()
        {
            this.plane.width = new WidthClass { widthOfPlane = 12};
        }

        public override void setHeight()
        {
            this.plane.height = new HeightClass { heightOfPlane = 7 };
        }

        public override void setNameOfPilot()
        {
            this.plane.name = new NameOfPilotClass { name_of_pilot = " Joe " };
        }

        public override void setNumberOfRocket()
        {
            this.plane.rocket_counter = new NumberOfRocketClass { number_of_rocket = 6 };
        }

        public override void setCapacityTank()
        {
            this.plane.capacity_of_tank = new CapacityOfTankClass { volume_of_the_tank = 110 };
        }
    }
}
