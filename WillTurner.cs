using PA4.models;
namespace PA4
{
    public class WillTurner : Character
    {
        public WillTurner()
        {
            Name = "Will Turner";
            SetMaxPower();
            attackBehavior = new Sword();
        }
    }
}