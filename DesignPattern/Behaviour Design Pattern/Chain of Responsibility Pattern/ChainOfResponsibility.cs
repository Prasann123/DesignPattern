namespace DesignPattern.Behaviour_Design_Pattern.Chain_of_Responsibility_Pattern
{
    public class ChainOfResponsibility
    {
        public abstract class ApproverHandler
        {
            protected ApproverHandler _nextHandler;

            public void SetNextHandler(ApproverHandler handler)
            {
                _nextHandler = handler;
            }

            public abstract void HandleApprover(int amount);
        }

        public class Manager : ApproverHandler
        {
            public override void HandleApprover(int amount)
            {
                if (amount <= 1000)
                {
                    Console.WriteLine("Manager approved the request");
                }
                else
                {
                    _nextHandler.HandleApprover(amount);
                }

            }


        }

        public class Director : ApproverHandler
        {
            public override void HandleApprover(int amount)
            {
                if (amount <= 5000)
                {
                    Console.WriteLine("Director approved the request");
                }
                else
                {
                    _nextHandler.HandleApprover(amount);
                }

            }
        }


        public class CEO : ApproverHandler
        {
            public override void HandleApprover(int amount)
            {
                if (amount <= 10000)
                {
                    Console.WriteLine("CEO approved the request");
                }
                else
                {
                    Console.WriteLine("Request rejected");
                }

            }
        }
    }
}
