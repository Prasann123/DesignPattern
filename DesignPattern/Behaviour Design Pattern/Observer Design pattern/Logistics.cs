namespace DesignPattern.Behaviour_Design_Pattern.Observer_Design_pattern
{
    public class Logistics : IInventory
    {
        public void UpdateStatus(string status)
        {
            Console.WriteLine($"Logistics  {status}");

        }
    }
}
