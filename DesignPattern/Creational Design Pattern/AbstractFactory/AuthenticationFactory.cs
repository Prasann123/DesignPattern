namespace DesignPattern.Creational_Design_Pattern.AbstractFactory
{
    public class AuthenticationFactory
    {
        public class GoogleAuthentication : IAuthentication_Factory
        {

            public IOAuth CreateOAuth()
            {
                return new OAuth.GoogleAuth();
            }

            public IMFA CreateMFA()
            {
                return new MFA.GoogleMFA();
            }

            public IBasic CreateBasic()
            {
                return new Basic.GoogleBasic();
            }
        }

        public class AppleAuthentication : IAuthentication_Factory
        {
            public IOAuth CreateOAuth()
            {
                return new OAuth.AppleAuth();
            }

            public IMFA CreateMFA()
            {
                return new MFA.AppleMFA();
            }

            public IBasic CreateBasic()
            {
                return new Basic.AppleBasic();
            }
        }
    }
}
