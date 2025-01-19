namespace DesignPattern.Creational_Design_Pattern.Builder_Design_Pattern
{
    public abstract class HolidayPAckageBuilder
    {
        protected HolidayPackage holidayPackage = new();
        public virtual void BuildFlight() { }
        public abstract void BuildHotel();
        public abstract void BuildCar();
        public abstract void BuildFood();
        public abstract void BuildActivities();

        public HolidayPackage GetHolidayPackage
        {
            get => holidayPackage;

        }

    }
}
