using PA4.models;
using PA4.interfaces;
namespace PA4
{
    public class Sword : IAttack
    {
        public void Attack()
        {
            System.Console.WriteLine("Will Turner uses a sword attack!");
        }
    }
}