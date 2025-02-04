namespace DesignPattern.Behaviour_Design_Pattern.Observer_Design_pattern
{
    public class Stores : IInventory
    {

        public void UpdateStatus(string status)
        {
            Console.WriteLine($"Stores - {status}");
        }
    }
}
