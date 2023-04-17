using PA4.models;
namespace PA4
{
    public class DavyJones : Character
    {
        public DavyJones()
        {
            Name = "Davy Jones";
            SetMaxPower();
            Health = 100;
            attackBehavior = new CannonFire();

        }
    }
}