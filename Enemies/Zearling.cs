using SuperMario.Interfaces;

namespace SuperMario.Enemies
{
    public class Zergling : IUnit
    {
        public void Attack(Target target)
        {
            target.Health -= 5;
        }
    }
}
