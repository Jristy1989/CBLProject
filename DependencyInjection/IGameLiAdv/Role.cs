using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.IGameLiAdv
{
    public class Role
    {

        public IAttackStrategy Weapon { get; set; }

        public void Attack(Monster monster)
        {
            this.Weapon.AttackTarget(monster);
        }
    }
}
