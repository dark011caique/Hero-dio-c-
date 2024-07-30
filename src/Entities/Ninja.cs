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

        public override void Detalhes()
    {
        base.Detalhes(); // Chama o método Detalhes da classe base
        // Adiciona detalhes específicos do Ninja
        if (Name == "Wedge")
        {
            Console.WriteLine("História: Wedge é um mestre das sombras e da furtividade, vindo de um clã secreto de ninjas. Sua agilidade e precisão o tornam um adversário mortal em combate.");
            Console.WriteLine("Habilidade Especial: Ataque Sombra - Wedge pode se tornar invisível por 5 segundos e aumentar seu próximo ataque em 100%.");
        }
        else
        {
            // Detalhes genéricos para outros ninjas, se necessário
            Console.WriteLine("Classe: Ninja - Especializado em furtividade e agilidade.");
        }
    }
        public override string Attack()
        {
            return $"{this.Name} Atacou usando kunai " ;
        }
    }
}