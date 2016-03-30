using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.IGameLiAdv
{
    public class WoodSword : IAttackStrategy
    {
        public void AttackTarget(Monster monster)
        {
            monster.Notify(20);
        }
    }
}
