namespace DesignPattern.Behaviour_Design_Pattern.Strategy_Design_pattern
{
    public class DtrategyDesignPattern_Payment_processing
    {

        public interface IPaymentstrategy
        {
            void Pay(int amount);
        }

        public class CreditCardPayment : IPaymentstrategy
        {
            public void Pay(int amount)
            {
                Console.WriteLine($"CreditCardPayment - {amount}");
            }
        }

        public class PaypalPayment : IPaymentstrategy
        {
            public void Pay(int amount)
            {
                Console.WriteLine($"PaypalPayment - {amount}");
            }

        }

        public class CryptoCurrency : IPaymentstrategy
        {
            public void Pay(int amount)
            {
                Console.WriteLine($"CryptoCurrency - {amount}");
            }

        }

        class PaymentStrategyFactory
        {
            public static IPaymentstrategy GetPaymentStrategy(string paymentType)
            {
                switch (paymentType)
                {
                    case "CreditCard":
                        return new CreditCardPayment();
                    case "Paypal":
                        return new PaypalPayment();
                    case "CryptoCurrency":
                        return new CryptoCurrency();
                    default:
                        return new CreditCardPayment();
                }
            }
        }

        public class PaymentProcessor
        {
            private IPaymentstrategy _paymentstrategy;


            public void SetPaymentstrategy(string paymentType)
            {
                _paymentstrategy = PaymentStrategyFactory.GetPaymentStrategy(paymentType);
            }

            public void ProcessPayment(int amount)
            {
                _paymentstrategy.Pay(amount);
            }
        }

        public class PaymentMain
        {
            public void Main()
            {
                PaymentProcessor paymentProcessor = new PaymentProcessor();
                paymentProcessor.SetPaymentstrategy("CreditCard");
                paymentProcessor.ProcessPayment(100);

                paymentProcessor.SetPaymentstrategy("Paypal");
                paymentProcessor.ProcessPayment(200);

                paymentProcessor.SetPaymentstrategy("CryptoCurrency");
                paymentProcessor.ProcessPayment(300);
            }
        }



    }
}
