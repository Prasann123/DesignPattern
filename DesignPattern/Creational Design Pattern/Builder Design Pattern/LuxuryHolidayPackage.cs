namespace DesignPattern.Creational_Design_Pattern.Builder_Design_Pattern
{
    public class LuxuryHolidayPackage : HolidayPAckageBuilder
    {
        public override void BuildActivities()
        {
            holidayPackage.Activities = "Luxury Activities";
        }

        public override void BuildCar()
        {
            holidayPackage.Car = "Luxury Car";
        }

        public override void BuildFlight()
        {
            holidayPackage.Flight = "Luxury Flight";
        }

        public override void BuildFood()
        {
            holidayPackage.Food = "Luxury Food";
        }

        public override void BuildHotel()
        {
            holidayPackage.Hotel = "Luxury Hotel";
        }
    }
}
