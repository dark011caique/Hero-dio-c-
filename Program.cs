using System;
using hero_dio_c_.src.Entities;

class Program
{
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
        Console.WriteLine("Digite 2 para registrar o álbum de uma banda");
        Console.WriteLine("Digite 3 para mostrar todas as bandas");
        Console.WriteLine("Digite 4 para avaliar uma banda");
        Console.WriteLine("Digite 5 para exibir os detalhes de uma banda");
        Console.WriteLine("Digite -1 para sair");

        Console.Write("\nDigite a sua opção: ");
        string opcaoEscolhida = Console.ReadLine()!;
        int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

        switch (opcaoEscolhidaNumerica)
        {
            case 1:
                EscolherClasseHeroi();
                break;
            case 2:
                Console.WriteLine("Registrar o álbum de uma banda");
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

    static void EscolherClasseHeroi()
    {
        Console.Clear();
        Console.WriteLine("1. Guerreiro");
        Console.WriteLine("2. Ninja");
        Console.WriteLine("3. Mago");
        Console.Write("\nDigite a sua opção: ");
        string classHero = Console.ReadLine()!;
        int classHeroType = int.Parse(classHero);
        Console.Clear();
        switch (classHeroType)
        {
            case 1:
                Console.WriteLine("Você escolheu Guerreiro");
                break;
            case 2:
                Console.WriteLine("Você escolheu Ninja");
                break;
            case 3:
                Console.WriteLine("Você escolheu Mago");
                    Console.Clear();
                        Console.WriteLine("1. White Wizard");
                        Console.WriteLine("2. Bleack Wizard");
                        Console.Write("\nDigite a sua opção: ");
                        string mago = Console.ReadLine()!;
                        int magoType = int.Parse(mago);
                        switch(magoType){
                            case 1:
                                Console.WriteLine("Você escolheu Mago White");
                            break;

                            case 2:
                                Console.WriteLine("Você escolheu Mago Bleack");
                            break;
                        }
                break;
            default:
                Console.WriteLine("Opção inválida");
                break;
        }
        Thread.Sleep(10000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}



