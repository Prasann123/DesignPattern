namespace DesignPattern.Creational_Design_Pattern.Builder_Design_Pattern
{
    public class BudgetHolidayPackage : HolidayPAckageBuilder
    {
        public override void BuildActivities()
        {
            holidayPackage.Activities = "Budget Activities";
        }

        public override void BuildCar()
        {
            holidayPackage.Car = "Budget Car";
        }

        //public override void BuildFlight()
        //{
        //    holidayPackage.Flight = "Budget Flight";
        //}

        public override void BuildFood()
        {
            holidayPackage.Food = "Budget Food";
        }

        public override void BuildHotel()
        {
            holidayPackage.Hotel = "Budget Hotel";
        }
    }
}
