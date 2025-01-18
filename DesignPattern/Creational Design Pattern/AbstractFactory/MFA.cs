namespace DesignPattern.Creational_Design_Pattern.AbstractFactory
{
    public class MFA
    {
        public class GoogleMFA : IMFA
        {
            public void Authenticate()
            {
                Console.WriteLine("Google MFA Authentication");
            }
        }

        public class AppleMFA : IMFA
        {
            public void Authenticate()
            {
                Console.WriteLine("Apple MFA Authentication");
            }
        }



    }
}
