namespace DesignPattern.Behaviour_Design_Pattern.Command_design_pattern
{
    public class MenuOptionInvoker
    {
        private readonly Dictionary<string, IRestaurantActionListener> menuOptions = new Dictionary<string, IRestaurantActionListener>();

        public void AddMenuOption(string menuOption, IRestaurantActionListener action)
        {
            menuOptions.Add(menuOption, action);
        }

        public void InvokeMenuOption(string menuOption)
        {
            if (menuOptions.ContainsKey(menuOption))
            {
                menuOptions[menuOption].execute();
            }
            else
            {
                Console.WriteLine("Invalid menu option");
            }
        }
    }
}
