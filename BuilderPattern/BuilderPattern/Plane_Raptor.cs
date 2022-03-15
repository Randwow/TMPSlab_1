using System;
namespace BuilderPattern
{
    class Plane_Raptor: PlaneBuilder
    {
        public override void setWidth()
        {
            this.plane.width = new WidthClass { widthOfPlane = 13 };
        }

        public override void setHeight()
        {
            this.plane.height = new HeightClass { heightOfPlane = 8 };
        }

        public override void setNameOfPilot()
        {
            this.plane.name = new NameOfPilotClass { name_of_pilot = " Brett " };
        }

        public override void setNumberOfRocket()
        {
            this.plane.rocket_counter = new NumberOfRocketClass { number_of_rocket = 6 };
        }

        public override void setCapacityTank()
        {
            this.plane.capacity_of_tank = new CapacityOfTankClass { volume_of_the_tank = 125 };
        }
    }
}
