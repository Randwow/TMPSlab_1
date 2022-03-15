using System;
namespace BuilderPattern
{
    class DirectorClass
    {
        public AirPlane Create(PlaneBuilder planeBuilder)
        {
            planeBuilder.CreatePlane();
            planeBuilder.setNameOfPilot();
            planeBuilder.setHeight();
            planeBuilder.setWidth();
            planeBuilder.setCapacityTank();
            planeBuilder.setNumberOfRocket();
            return planeBuilder.plane;
        }
    }
}
