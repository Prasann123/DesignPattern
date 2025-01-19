namespace DesignPattern.Creational_Design_Pattern.Builder_Design_Pattern
{
    public class HolidayPackageDirector
    {

        public HolidayPackage BuildHolidayPackage(HolidayPAckageBuilder pavkage)
        {
            pavkage.BuildFlight();
            pavkage.BuildHotel();
            pavkage.BuildCar();
            pavkage.BuildFood();
            pavkage.BuildActivities();

            return pavkage.GetHolidayPackage;
        }
    }
}
