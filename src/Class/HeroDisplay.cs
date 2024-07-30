using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hero_dio_c_.src.Class
{
    public class HeroDisplay
    {
        private Dictionary<string, List<int>> _registraHero;

        public HeroDisplay(Dictionary<string, List<int>> registraHero)
        {
            _registraHero = registraHero;
        }

        public void MostrarHerois()
        {
            Console.Clear();
            Console.WriteLine("Mostra todos os Heróis");
            foreach (var hero in _registraHero)
            {
                Console.WriteLine($"Herói: {hero.Key}, Pontos: {string.Join(", ", hero.Value)}");
            }
            Thread.Sleep(10000); // Pausa para o usuário ler a lista de heróis
            Console.Clear();
        }
    }
}