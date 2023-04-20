using PA4.models;
namespace PA4
{
    public class JackSparrow : Character
    {
        public JackSparrow()
        {
            name = "Jack Sparrow";
            health = 100;
            int maxPower = SetMaxPower();
            SetAttackStrength(maxPower);
            SetDefensivePower(maxPower);
            attackBehavior = new Distract();
        }
    }
}