namespace hero_dio_c_.src.Class
{
    class HeroClassSelector
    {
        private Dictionary<string, List<int>> _registraHero;

        public HeroClassSelector(Dictionary<string, List<int>> registraHero)
        {
            _registraHero = registraHero;
        }

        public void EscolherClasseHeroi()
        {
            Console.Clear();
            Console.WriteLine("1. Guerreiro");
            Console.WriteLine("2. Ninja");
            Console.WriteLine("3. Mago");
            Console.Write("\nDigite a sua opção: ");
            string classHero = Console.ReadLine()!;
            int classHeroType = int.Parse(classHero);
            Console.Clear();
            string chosenClass = string.Empty;

            switch (classHeroType)
            {
                case 1:
                    chosenClass = "Guerreiro";
                    Console.WriteLine("Você escolheu Guerreiro");
                    break;
                case 2:
                    chosenClass = "Ninja";
                    Console.WriteLine("Você escolheu Ninja");
                    break;
                case 3:
                    chosenClass = "Mago";
                    Console.WriteLine("Você escolheu Mago");
                    Console.Clear();
                    Console.WriteLine("1. White Wizard");
                    Console.WriteLine("2. Black Wizard");
                    Console.Write("\nDigite a sua opção: ");
                    string mago = Console.ReadLine()!;
                    int magoType = int.Parse(mago);
                    switch (magoType)
                    {
                        case 1:
                            chosenClass = "White Wizard";
                            Console.WriteLine("Você escolheu White Wizard");
                            break;
                        case 2:
                            chosenClass = "Black Wizard";
                            Console.WriteLine("Você escolheu Black Wizard");
                            break;
                        default:
                            Console.WriteLine("Opção inválida");
                            return;
                    }
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    return;
            }

            if (_registraHero.ContainsKey(chosenClass))
            {
                _registraHero[chosenClass].Add(1);
                Console.WriteLine($"{chosenClass} registrado com sucesso.");
            }
            else
            {
                _registraHero[chosenClass] = new List<int> { 1 };
                Console.WriteLine($"{chosenClass} adicionado e registrado com sucesso.");
            }

            Thread.Sleep(10000);
            Console.Clear();
        }
    }
}