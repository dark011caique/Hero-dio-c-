using System;
using System.Collections.Generic;
using System.Threading;
using hero_dio_c_.src.Entities;
using hero_dio_c_.src.Class;

class Program
{
    static Dictionary<string, List<int>> registraHero = new Dictionary<string, List<int>>
    {
        { "Arus", new List<int> { 10 } },
        { "Jennica", new List<int>() },
        { "Wedge", new List<int>() },
        { "Topapa", new List<int>() }
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
        Console.WriteLine("Digite 3 para mostrar todas as bandas");
        Console.WriteLine("Digite 4 para avaliar uma banda");
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
                Console.WriteLine("Mostrar todas as bandas");
                break;
            case 4:
                Console.WriteLine("Avaliar uma banda");
                break;
            case 5:
                Console.WriteLine("Exibir os detalhes de uma banda");
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
}