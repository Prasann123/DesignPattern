namespace DesignPattern.Behaviour_Design_Pattern.Observer_Design_pattern
{
    public class Product
    {
        private string _name;

        public int stocklevel;

        public string status
        {
            get { return _name; }
            set
            {
                _name = value;
                if (stocklevel < 10)
                {
                    Notify();
                }
            }
        }


        public List<IInventory> inventories = new List<IInventory>();
        public void Attach(IInventory inventory)
        {
            inventories.Add(inventory);
        }
        public void Detach(IInventory inventory)
        {
            inventories.Remove(inventory);
        }
        public void Notify()
        {
            foreach (var inventory in inventories)
            {
                inventory.UpdateStatus(status);
            }
        }

    }
}
