using PA4.models;
namespace PA4
{
    public class JackSparrow : Character
    {
        public JackSparrow()
        {
            attackBehavior = new Distract();
        }
    }
}