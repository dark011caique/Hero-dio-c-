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
    }
}