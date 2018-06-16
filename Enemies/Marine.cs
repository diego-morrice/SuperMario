using SuperMario.Interfaces;

namespace SuperMario.Enemies
{
    public class Marine : IUnit
    {
        public void Attack(Target target)
        {
            target.Health -= 6;
        }
    }
}
