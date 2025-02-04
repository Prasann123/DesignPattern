namespace DesignPattern.Behaviour_Design_Pattern.Command_design_pattern
{
    public class ActionCookBurger : IRestaurantActionListener
    {
        private ChefReciever chefReciever;

        public ActionCookBurger()
        {
            this.chefReciever = new ChefReciever();

        }

        public void execute()
        {
            chefReciever.PrepareBurger();
        }
    }
}
