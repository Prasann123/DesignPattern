namespace DesignPattern.Creational_Design_Pattern.AbstractFactory
{
    public interface IAuthentication_Factory
    {
        IOAuth CreateOAuth();
        IMFA CreateMFA();
        IBasic CreateBasic();


    }

    public static class AuthenticationFactorySelector
    {
        public static IAuthentication_Factory CreateFactory(string factory)
        {
            return factory switch
            {
                "Google" => new AuthenticationFactory.GoogleAuthentication(),
                "Apple" => new AuthenticationFactory.AppleAuthentication(),
                _ => throw new ArgumentException("Invalid factory type")
            };
        }
    }
}
