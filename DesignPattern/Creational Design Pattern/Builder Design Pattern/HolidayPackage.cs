namespace DesignPattern.Creational_Design_Pattern.Builder_Design_Pattern
{
    public class HolidayPackage
    {
        public string? Flight { get; set; }
        public string? Hotel { get; set; }
        public string? Car { get; set; }
        public string? Food { get; set; }
        public string? Activities { get; set; }

        public void display()
        {
            Console.WriteLine("Flight: " + Flight);
            Console.WriteLine("Hotel: " + Hotel);
            Console.WriteLine("Car: " + Car);
            Console.WriteLine("Food: " + Food);
            Console.WriteLine("Activities: " + Activities);
        }


    }
}
