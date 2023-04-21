using PA4.interfaces;
namespace PA4.models
{
    public class Character
    {
        public string name {get; set;}
        public double health {get; set;}
       
        public double defensivePower {get; set;}
        public double attackStrength {get; set;}
        public int SetMaxPower()
        {
            Random ran = new Random();
            int maxPower = ran.Next(0,100);
            return maxPower;
        }
        public double SetAttackStrength(int maxPower)
        {
            Random ran = new Random(maxPower);
            double attackStrength = ran.Next(0,maxPower);
            return attackStrength;
        }
        
    public double SetDefensivePower(int maxPower)
        {
            Random ran = new Random(maxPower);
            double attackStrength = ran.Next(0,maxPower);
            return defensivePower;
        }
    
        
        public IAttack attackBehavior {get; set;}
        public Character()
        {
            attackBehavior = new CannonFire();
        }
        public void Stats()
        {
            int maxPower = SetMaxPower();
            double attackStrength = SetAttackStrength(maxPower);
            double defensivePower = SetDefensivePower(maxPower);

            System.Console.WriteLine("Character's Name: {0}", name);
            System.Console.WriteLine("Health: {0}", health);
            System.Console.WriteLine("Maximum Power: {0}", maxPower);
            System.Console.WriteLine("Attack Strength: {0}", attackStrength);
            System.Console.WriteLine("Defensive Power: {0}", defensivePower);
        }
    

    }
}
