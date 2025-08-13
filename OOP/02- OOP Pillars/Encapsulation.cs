namespace OOP
{
    public class CoffeeAutomation
    {
        public void ServeCoffee()
        {
            var coffeeMachine = new CoffeeMachine();
            coffeeMachine.TurnOn();
            coffeeMachine.Prepare();
            coffeeMachine.TurnOff();
        }
    }
}
