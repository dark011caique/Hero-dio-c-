using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hero_dio_c_.src.Entities
{
     public class Knight : Hero
    {
        public Knight(string name, int level, string type, string hp, string mp)
            : base(name, level, type, hp , mp) // Chama o construtor da classe base
        {
        }

        public void DetalhesArus(){
            Console.WriteLine("História: Arus é um cavaleiro lendário, conhecido por sua bravura e habilidades de combate. Ele jurou proteger seu reino contra qualquer ameaça, usando sua espada mágica que foi passada de geração em geração em sua família.");
            System.Console.WriteLine("Habilidade Especial: Escudo de Luz - Arus pode criar um escudo de luz que reduz o dano recebido em 50% por 10 segundos.");
        }
    }

    
}