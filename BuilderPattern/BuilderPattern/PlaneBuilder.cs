using System;
namespace BuilderPattern
{
    abstract class PlaneBuilder
    {
        public AirPlane plane { get; protected set; }

        public void CreatePlane() {
            plane = new AirPlane(); 
        }
        public abstract void setWidth();

        public abstract void setHeight();

        public abstract void setNameOfPilot();

        public abstract void setNumberOfRocket();

        public abstract void setCapacityTank();

    }
}
