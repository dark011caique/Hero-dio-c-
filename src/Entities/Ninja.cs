using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hero_dio_c_.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string name, int level, string type, string hp, string mp)
            : base(name, level, type, hp , mp) // Chama o construtor da classe base
        {
        }
        public override string Attack()
        {
            return $"{this.Name} Atacou usando kunai " ;
        }
    }
}