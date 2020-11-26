using System;

namespace Exercício___Sistema_de_produtos
{
    class Program
    { // Sistema de gerenciamento de 10 produtos
        static void Main(string[] args)
        {
             string [] nome = new string[10];
             float [] preco = new float[10];

            Console.Clear();
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Sistema de Gerenciamento de Produtos");
            Console.WriteLine("---------------------------------------");

            // Criação do menu
            int menu;
            do
            {
                Console.WriteLine("Menu principal");
                Console.WriteLine("Selecione uma opção válida.");
                Console.WriteLine("[1] Cadastrar Produto");
                Console.WriteLine("[2] Listar Produtos Cadastrados");            
                Console.WriteLine("[0] Sair");
                menu = int.Parse(Console.ReadLine());  

                switch (menu)
                {
                    case 1:
                    string resposta;
                    int x =0;
                    Console.WriteLine("Atenção, você só pode cadastrar até 10 produtos");
                    Console.WriteLine("Para verificar quantos produtos já foram cadastrados, selecione a opção 2.");
                    for (var i = 0; i < 10; i = x)
                        {
                            Console.WriteLine($"Digite o nome do {i+1}º Produto");
                            nome[i] = Console.ReadLine();
                            Console.WriteLine($"Digite o preço do {i+1}º Produto");
                            preco[i] = float.Parse(Console.ReadLine());

                            Console.WriteLine("Você gostaria de cadastrar outro produto? Responda apenas com Sim ou Não ");
                            resposta = Console.ReadLine();
                                if(resposta == "Sim")
                                {
                                    x++;
                                    
                                }
                                else
                                {
                                    x=11;
                                }
                        }
                        break;
                case 2:
                    //Listar produtos
                            Console.WriteLine("Lista de produtos já cadastrados:");
                            for (var i = 0; i < 10; i++)
                            {   
                                Console.WriteLine("--------------------------------------");
                                Console.WriteLine($"Nome do {i+1}º Produto : {nome[i]}");
                                Console.WriteLine($"Preço do {i+1}º Produto : {preco[i]}");
                                if(preco[i] > 0 && preco[i] <= 10)
                                {
                                    Console.WriteLine("Esse produto está em promoção");
                                }
                                else if(preco[i]>10)
                                {
                                    Console.WriteLine("Esse produto não esta em promoção");
                                }
                                else
                                {
                                    Console.WriteLine("Esse produto ainda não foi cadastrado");
                                }
                                Console.WriteLine("--------------------------------------");
                            }
                break;
                
                case 0:
                break;

                default:
                break;
                }

            } while (menu != 0);


        }
    }
}
