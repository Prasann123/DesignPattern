namespace DesignPattern.Behaviour_Design_Pattern.Command_design_pattern
{
    public class ActionPreparePizza : IRestaurantActionListener
    {
        private ChefReciever chefReciever;

        public ActionPreparePizza()
        {
            this.chefReciever = new ChefReciever();

        }

        public void execute()
        {
            chefReciever.PreparePizza();
        }
    }
}
