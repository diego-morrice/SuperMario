using SuperMario.Interfaces;

namespace SuperMario.Enemies
{
    public class Zealot : IUnit
    {
        public void Attack(Target target)
        {
            target.Health -= 8;
        }
    }
}
