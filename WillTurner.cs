using PA4.models;
namespace PA4
{
    public class WillTurner : Character
    {
        public WillTurner()
        {
            name = "Will Turner";
            health = 100;
            int maxPower = SetMaxPower();
            SetAttackStrength(maxPower);
            SetDefensivePower(maxPower);
            attackBehavior = new Sword();
        }
    }
}