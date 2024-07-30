using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hero_dio_c_.src.Entities
{
    public class Wizard : Hero
    {
        //  Herança
        public Wizard(string name, int level, string type, string hp, string mp)
            : base(name, level, type, hp , mp) // Chama o construtor da classe base
        {
        }

        // Você pode adicionar métodos ou propriedades adicionais específicos do Wizard aqui, se necessário
        public override string Attack()
        {
            return $"{this.Name}, Lançou magia";
        }

        public string Attack(int Bonus)// polimorfismo 
        {

            if(Bonus > 6){
                return $"{this.Name}, Lançou magia com bonus de ataque de super forte +{Bonus}";
                // Sobrecarga de metodo 
            }else{
                return $"{this.Name}, Lançou magia com bonus de ataque de fraco  +{Bonus}"; 
                 // Sobrecarga de metodo
            }
            
        }

        public override void Detalhes()
    {
        base.Detalhes(); // Exibe detalhes da classe base
        // Adiciona detalhes específicos do Wizard
        if (Name == "Jennica")
        {
            Console.WriteLine("História: Jennica é uma maga poderosa conhecida por suas habilidades em magia branca. Ela usa seu conhecimento para curar e proteger seus aliados.");
            Console.WriteLine("\nHabilidade Especial: Cura Divina - Pode restaurar HP de um aliado em 50%.");
        }
        else if (Name == "Topapa")
        {
            Console.WriteLine("História: Topapa é um mestre das artes negras, utilizando magia negra para infligir grandes danos aos inimigos.");
            Console.WriteLine("\nHabilidade Especial: Explosão das Trevas - Lança uma poderosa explosão mágica que causa grandes danos ao inimigo.");
        }
    }
    }
}