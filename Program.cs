using System;
using System.Collections.Generic;
using System.Threading;
using hero_dio_c_.src.Entities;
using hero_dio_c_.src.Class;
using System.Runtime.InteropServices;

class Program
{
    static Dictionary<string, List<int>> registraHero = new Dictionary<string, List<int>>
    {
        { "Arus", new List<int> { 10 } },
        { "Jennica", new List<int>() },
        { "Wedge", new List<int>() },
        { "Topapa", new List<int>() }
    };

    static Dictionary<string, Hero> herois = new Dictionary<string, Hero>
    {
        { "Arus", new Knight("Arus", 42,"Knight", "100", "80") },
        { "Jennica", new Wizard("Jennica", 42, "White Wizard", "100", "120") },
        { "Wedge", new Ninja("Wedge", 42, "Ninja", "100", "50") },
        { "Topapa", new Wizard("Topapa", 42, "Black Wizard", "95", "130") }
    };

    static void Main()
    {
        while (true)
        {
            ExibirOpcoesDoMenu();
        }
    }

    static void ExibirLogo()
    {
        System.Console.WriteLine(@"
            
    ██╗░░██╗███████╗██████╗░░█████╗░  ░█████╗░░█████╗░░█████╗░██████╗░███████╗███╗░░░███╗██╗░░░██╗
    ██║░░██║██╔════╝██╔══██╗██╔══██╗  ██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝████╗░████║╚██╗░██╔╝
    ███████║█████╗░░██████╔╝██║░░██║  ███████║██║░░╚═╝███████║██║░░██║█████╗░░██╔████╔██║░╚████╔╝░
    ██╔══██║██╔══╝░░██╔══██╗██║░░██║  ██╔══██║██║░░██╗██╔══██║██║░░██║██╔══╝░░██║╚██╔╝██║░░╚██╔╝░░
    ██║░░██║███████╗██║░░██║╚█████╔╝  ██║░░██║╚█████╔╝██║░░██║██████╔╝███████╗██║░╚═╝░██║░░░██║░░░
    ╚═╝░░╚═╝╚══════╝╚═╝░░╚═╝░╚════╝░  ╚═╝░░╚═╝░╚════╝░╚═╝░░╚═╝╚═════╝░╚══════╝╚═╝░░░░░╚═╝░░░╚═╝░░░");
            
        System.Console.WriteLine("                                  welcome to the hero academy     ");
    }

    static void ExibirOpcoesDoMenu()
    {
        ExibirLogo();
        Console.WriteLine("\nDigite 1 para Escolher uma classe de herói");
        Console.WriteLine("Digite 2 para Mostrar todos os Heróis");
        Console.WriteLine("Digite 3 para atacar");
        Console.WriteLine("Digite 4 para avaliar um hero");
        Console.WriteLine("Digite 5 para exibir os detalhes de uma banda");
        Console.WriteLine("Digite -1 para sair");

        Console.Write("\nDigite a sua opção: ");
        string opcaoEscolhida = Console.ReadLine()!;
        int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

        HeroClassSelector heroClassSelector = new HeroClassSelector(registraHero);
        HeroDisplay heroDisplay = new HeroDisplay(registraHero);

        switch (opcaoEscolhidaNumerica)
        {
            case 1:
                heroClassSelector.EscolherClasseHeroi();
                break;
            case 2:
                heroDisplay.MostrarHerois();
                break;
            case 3:
                HeroAttack();
                break;
            case 4:
                AvaliarHero();
                break;
            case 5:
                DetalhesHero();
                break;
            case -1:
                Console.WriteLine("Tchau tchau :)");
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Opção inválida");
                break;
        }
    }

    static void AvaliarHero()
    {
        Console.Clear();
        Console.Write("Digite o nome do personagem: ");
        string nomeHero = Console.ReadLine()!;
        if (registraHero.ContainsKey(nomeHero))
        {
            Console.Write($"Qual nota o Hero {nomeHero} merece: ");
            int nota = int.Parse(Console.ReadLine()!);
            registraHero[nomeHero].Add(nota);
            System.Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para o Hero {nomeHero}");
            Thread.Sleep(6000);
            Console.Clear();
        }
        else
        {
            System.Console.WriteLine($"O hero {nomeHero}, não foi encontrado");
            ExibirOpcoesDoMenu();
        }
    }

    static void HeroAttack()
    {
        Console.Clear();
        Console.WriteLine("**************************************");
        Console.WriteLine("             Ataque do herói");
        Console.WriteLine("**************************************");
        Console.Write("\nEscolha um herói para atacar o inimigo: ");
        string nomeHero = Console.ReadLine()!;

        if (herois.ContainsKey(nomeHero))
        {
            switch (nomeHero)
            {
                case "Jennica":
                    Wizard jennica = (Wizard)herois[nomeHero];
                    Console.WriteLine(jennica.Attack(7));
                    break;
                case "Arus":
                    Knight arus = (Knight)herois[nomeHero];
                    Console.WriteLine(arus.Attack());
                    break;
                case "Wedge":
                    Ninja wedge = (Ninja)herois[nomeHero];
                    Console.WriteLine(wedge.Attack());
                    break;
                case "Topapa":
                    Wizard topapa = (Wizard)herois[nomeHero];
                    Console.WriteLine(topapa.Attack(5));
                    break;
                default:
                    Console.WriteLine("Hero não encontrado");
                    break;
            }
            Thread.Sleep(10000);
            Console.Clear();
            ExibirOpcoesDoMenu();
        }
        else
        {
            Console.WriteLine("O herói não foi encontrado!");
            Thread.Sleep(10000);
            Console.Clear();
            ExibirOpcoesDoMenu();
        }
    }

    static void DetalhesHero()
    {
        Console.Clear();
        Console.WriteLine("**************************************");
        Console.WriteLine("             Detalhes do herói");
        Console.WriteLine("**************************************");
        Console.Write("\nEscolha o herói: ");
        string nomeHero = Console.ReadLine()!;

        if (herois.ContainsKey(nomeHero))
        {
            Hero heroi = herois[nomeHero];
            
            // Chama o método Detalhes para exibir informações do herói
            heroi.Detalhes();
        }
        else
        {
            Console.WriteLine("O herói não foi encontrado!");
            Thread.Sleep(10000);
            Console.Clear();
            ExibirOpcoesDoMenu();
        }
    }
}
