using System;

namespace Exercicio_Passagem_Aerea
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaração das variáveis
            string[] nomes = new string[5];//variável para nomes dos passageiros
            string[] origem = new string[5];//variável para origem do vôo
            string[] destino = new string[5];//variável para destino do vôo
            string[] data = new string[5];//variável para data do vôo

            //cabeçalho
            Console.WriteLine("---------------------------------");//exibição da mensagem
            Console.WriteLine("---Sistema de passagens aéreas---");//exibição da mensagem
            Console.WriteLine("---------------------------------");//exibição da mensagem


            bool senhaValida;//variável tipo bool (true or false) - para validação da senha 
            do //condicional do-while -- primeiro lê a senha e então valida 
            {
                Console.WriteLine("Digite sua senha");//exibição da mensagem
                string senha = Console.ReadLine();//entrada e armazenamento da senha 
                senhaValida = EfetuarLogin(senha);//validação da senha conforme função "EfetuarLogin"  

            }while(!senhaValida);//se a senha for diferente da senha válida,então retorna para digitar até que a senha seja validada
                Console.Clear();//limpeza do console


            //menu de opções
            int escolha; //variável para definir qual a opção escolhida
            int contador = 0;//variável contador

            do//condicional do-while -- primeiro lê o menu de opções 
            {
                Console.WriteLine("Menu inicial");//exibição da mensagem
                Console.WriteLine("Selecione uma opção");//exibição da mensagem
                Console.WriteLine("[1] - Cadastrar passagem");//exibição da mensagem
                Console.WriteLine("[2] - Listar passagens");//exibição da mensagem
                Console.WriteLine("[0] - Sair");//exibição da mensagem
                escolha = int.Parse(Console.ReadLine());//entrada e armazenamento da escolha

                //então avalie a escolha
                switch(escolha) 
                {   
                    case 1: //caso a opção seja 1,então cadastrar passagem
                        string resposta;//variável para resposta se quer efetuar novo cadastro

                        do//condicional do-while - efetue o primeiro cadastro máx de 5 clientes
                        {
                            if(contador < 5)//condicional if -- caso contador for menor que 5,então tem opção de cadastrar nova passagem 
                            {
                                Console.WriteLine($"Digite o nome do {contador+1}° passageiro");//exibição da mensagem
                                nomes[contador] = Console.ReadLine();//entrada e armazenamento do nome
                                Console.WriteLine($"Digite a origem do {contador+1}° passageiro");//exibição da mensagem
                                origem[contador] = Console.ReadLine();//entrada e armazenamento da origem
                                Console.WriteLine($"Digite o destino do {contador+1}° passageiro");//exibição da mensagem
                                destino[contador] = Console.ReadLine();//entrada e armazenamento do destino
                                Console.WriteLine($"Digite a data da viagem do {contador+1}° passageiro");//exibição da mensagem
                                data[contador] = Console.ReadLine();//entrada e armazenamento da data

                                contador++;//incremento de 1 em 1 no contador

                            }else// caso contrário, exibir que o limite de cadastro está excedido
                            {
                                Console.WriteLine("Limite de passagem excedido !");//exibição da mensagem
                                break;//encerrar
                            }

                            //perguntar se quer efetuar novo cadastro
                            Console.WriteLine("Gostaria de cadastrar uma nova passagem? s/n");//exibição da mensagem
                            resposta = Console.ReadLine();

                        }while(resposta == "s");//condicional while ,enquanto a resposta for igual a sim, então volte para o cadastro até que exceda o limite

                    break; //fim do cadastro de passagem (caso 1)

                    case 2: //caso a opção seja 2, então listar o nome dos passageiros cadastrados

                        for (var i = 0; i < 5; i++)//estrutura de repetição do tipo for para listar todos os nomes do array "nomes"
                        {
                            Console.WriteLine($"Passageiro {nomes[i]}");//exibição da mensagem
                        }

                    break;//encerrar

                    case 0: //caso a opção for 0, então sair do menu de opções
                        Console.WriteLine("---Fim---");//exibição da mensagem
                    break;//encerrar

                    default://caso a opção não seja nenhuma do menu,então exibir opção inválida
                        Console.WriteLine("Opção inválida");//exibição da mensagem
                    break;//encerrar

                }//fim do switch

            }while(escolha !=0);//fechamento da condicional do-while------enquanto a escolha for diferente de 0,então voltar para o início do menu

            
            //funções
            bool EfetuarLogin(string senha){//criado a função para validar a senha conforme pedido no projeto

                if(senha == "123456"){//caso senha for igual 123456 
                    return true;//retonar como senha válida
                }else{//caso contrário
                    Console.WriteLine("Senha incorreta !");//exibir mensagem de senha incorreta e  
                    return false;//retornar como senha inválida
                }
            }//fim da função 

        }//fim do main
    }
}
