using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.IGameLiAdv
{
    public class Monster
    {
        public string Name { get; set; }

        private Int32 HP { get; set; }

        public Monster(String name, Int32 hp)
        {
            this.Name = name;
            this.HP = hp;
        }

        public void Notify(Int32 loss)
        {
            if (this.HP <= 0)
            {
                Console.WriteLine("此怪物已死");
                return;
            }
            this.HP -= loss;
            if (this.HP <= 0)
            {
                Console.WriteLine("怪物" + this.Name + "被打死");
            }
            else
            {
                Console.WriteLine("怪物" + this.Name + "损失" + loss + "HP");
            }
        }
    }
}
