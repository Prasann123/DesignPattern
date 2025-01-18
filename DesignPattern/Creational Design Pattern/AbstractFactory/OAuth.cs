namespace DesignPattern.Creational_Design_Pattern.AbstractFactory
{
    public class OAuth
    {
        public class GoogleAuth : IOAuth
        {
            public void Authenticate()
            {
                Console.WriteLine("Google OAuth Authenticated");
            }
        }


        public class AppleAuth : IOAuth
        {
            public void Authenticate()
            {
                Console.WriteLine("Apple Oauth Authenticated");
            }
        }



    }
}
