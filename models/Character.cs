using PA4.interfaces;
namespace PA4.models
{
    public class Character
    {
        public string Name {get; set;}
        public int MaxPower {get; set;}
        public int Health {get; set;}
        public double AttackStrength {get; set;}
        public double DefensivePower {get; set;}
        public string Stats {get; set;}

        public IAttack attackBehavior {get; set;}
        public Character()
        {
            attackBehavior = new CannonFire();
        }



    //public class Pitcher
    // {
    //     public string Name {get;set;}
    //     public string Team {get;set;}
    //     public string Throws {get;set;}

    //     public IPitch pitchBehavior {get; set;}
    //     public Pitcher()
    //     {
    //         pitchBehavior = new Fastball();
    //     }
    // }
    }
}
