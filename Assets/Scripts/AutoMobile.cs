using System;

namespace Assets.Scripts
{
    public abstract class AutoMobile
    {
        protected string Description = "Unknown AutoMobile";

        public virtual string GetDescription()
        {
            return Description;
        }

        public abstract double Cost();

    }

    public class Car : AutoMobile
    {
        public Car()
        {
            Description = "Car";
        }

        public override double Cost()
        {
            return 5000;
        }
    }

    public class Truck : AutoMobile
    {
        public Truck()
        {
            Description = "Truck";
        }

        public override double Cost()
        {
            return 20000;
        }
    }


    public class Climatization : AutoMobile
    {
        private readonly AutoMobile _autoMobile;

        public Climatization(AutoMobile autoMobile)
        {
            _autoMobile = autoMobile;
        }

        public override string GetDescription()
        {
            return _autoMobile.GetDescription() + ", Climatization";
        }

        public override double Cost()
        {
            return _autoMobile.Cost() + 1000;
        }
    }

    public class Radio : AutoMobile
    {
        private readonly AutoMobile _autoMobile;

        public Radio(AutoMobile autoMobile)
        {
            _autoMobile = autoMobile;
        }

        public override string GetDescription()
        {
            return _autoMobile.GetDescription() + ", Radio";
        }

        public override double Cost()
        {
            return _autoMobile.Cost() + 500;
        }
    }
}