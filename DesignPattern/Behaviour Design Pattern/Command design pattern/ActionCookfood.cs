namespace DesignPattern.Behaviour_Design_Pattern.Command_design_pattern
{
    public class ActionCookfood : IRestaurantActionListener
    {
        private ChefReciever chefReciever;

        public ActionCookfood()
        {
            this.chefReciever = new ChefReciever();

        }

        public void execute()
        {
            chefReciever.CookFood();
        }

    }
}
