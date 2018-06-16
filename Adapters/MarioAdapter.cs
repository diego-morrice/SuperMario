using SuperMario.Heros;
using SuperMario.Interfaces;

namespace SuperMario.Adapters
{
    public class MarioAdapter : IUnit
    {

        private Mario _mario;
        public MarioAdapter(Heros.Mario mario)
        {
            _mario = mario;
        }

        public void Attack(Target target)
        {
           target.Health -= _mario.JumpAttack();
        }
    }
}
