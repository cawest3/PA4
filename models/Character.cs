using PA4.interfaces;
namespace PA4.models
{
    public class Character
    {
        public string Name {get; set;}
        public int SetMaxPower()
        {
            Random ran = new Random();
            int MaxPower = ran.Next(0,100);
            return MaxPower;
        }
        
        public int Health {get; set;}
        // public double SetAttackStrength()
        // {
        //     Random ran = new Random(MaxPower);
        //     double AttackStrength = ran.Next(0,MaxPower);
        //     return AttackStrength;
        // }
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
