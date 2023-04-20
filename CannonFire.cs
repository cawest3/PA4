using PA4.models;
using PA4.interfaces;
namespace PA4
{
    public class CannonFire : IAttack 
    {
        public void Attack()
        {
            System.Console.WriteLine("Davy Jones use cannon fire to attack!");
        }
        
    }
}