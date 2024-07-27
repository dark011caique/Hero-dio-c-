using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hero_dio_c_.src.Entities
{
    public abstract class Hero
    {
        public Hero(string name, int level, string herotype, string hp, string mp)
        {
            this.Name = name;
            this.Level = level;
            this.HeroType = herotype;
            this.Hp = hp;
            this.Mp = mp;
        }

        public string Name { get; set; }
        public int Level { get; set; }
        public string HeroType { get; set; }

        public string Hp { get; set; }
        public string Mp{ get; set; }

        public override string ToString()
        {
            return $"Name:{this.Name}, Lvel:{this.Level}, Type:{this.HeroType}, HP:{this.Hp}, mp:{this.Mp}";
        }

        public virtual string Attack(){
            return $"{this.Name}, Atacou usando espada";
        }

        
    }
}