namespace DesignPattern.Creational_Design_Pattern.AbstractFactory
{
    public class Basic
    {
        public class GoogleBasic : IBasic
        {
            public void Authenticate()
            {
                Console.WriteLine("Google Basic Authentication");
            }
        }

        public class AppleBasic : IBasic
        {
            public void Authenticate()
            {
                Console.WriteLine("Google Basic Authentication");
            }
        }
    }
}
