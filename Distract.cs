using PA4.models;
using PA4.interfaces;
namespace PA4
{
    public class Distract : IAttack
    {
        public void Attack()
        {
            System.Console.WriteLine("character using distract attack");
        }
    }
}