using PA4.models;
namespace PA4
{
    public class DavyJones : Character
    {
        public DavyJones()
        {
            name = "Davy Jones";
            health = 100;
            int maxPower = SetMaxPower();
            SetAttackStrength(maxPower);
            SetDefensivePower(maxPower);
            attackBehavior = new CannonFire();

        }
    }
}