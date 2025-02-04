namespace DesignPattern.Behaviour_Design_Pattern.Observer_Design_pattern
{
    public class Purchase : IInventory
    {
        public void UpdateStatus(string status)
        {
            Console.WriteLine($"Purchase - {status}");
        }
    }
}
