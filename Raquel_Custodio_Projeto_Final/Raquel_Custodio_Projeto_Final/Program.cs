using System;
using System.Collections.Generic;


namespace Raquel_Custodio_Projeto_Final
{
    public class Program
    {
        public static List<Equipa> listaEquipa = new List<Equipa>();  // listas de todas as entidades/classes. // Listas devem ser globais. 
        public static List<Membro> listaMembro = new List<Membro>();
        public static List<Projeto> listaProjeto = new List<Projeto>();
        public static List<Tarefa> listaTarefa = new List<Tarefa>();



        

        static void Main(string[] args)
        {
            Equipa lista_equipa = new Equipa();         //instânciação das listas - criar objeto- 
            Membro lista_membro = new Membro();
            Projeto lista_projeto = new Projeto();
            Tarefa lista_tarefa = new Tarefa();









            Console.WriteLine("**** Sistema de Gestão de Projectos ****\n");       

            Console.WriteLine("1- Adicionar e Remover Registos");                   // Menu para a escolha das opções.
            Console.WriteLine("2- Edição de Projectos, Equipas e Tarefas");         // através do switch (NOTA: será necessário criar mais menus  
            Console.WriteLine("3- Relatório de Tarefas Não Concluídas");            // devido às entidades. 
            Console.WriteLine("4- Impressão de um Relatório por Entidade\n");

            Console.WriteLine("Digite a Opção Pretendida: \n");

            int op = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n");

            switch (op)                                                             // switch para escolher entre adicionar e remover
            {


                case 1:

                    Console.WriteLine("**** Adicione ou Remova Dados ****\n");

                    Console.WriteLine("1- Adicionar Dados");
                    Console.WriteLine("2- Remover Dados\n");

                    Console.WriteLine("Digite a Opção Pretendida: \n");
                    int op1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("\n");







                    switch (op1)                                                     // switch para escolher qual das entidades inserir

                    {
                        case 1:

                            Console.WriteLine("**** Entidade a Adicionar ****\n");

                            Console.WriteLine("1-Equipa");
                            Console.WriteLine("2-Membro");
                            Console.WriteLine("3- Projeto");
                            Console.WriteLine("4- Tarefa\n");


                            Console.WriteLine("Digite a Opção Pretendida: \n");
                            int op2 = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("\n");



                            switch (op2)                                            //Adicionar Dados na Equipa
                            {
                                case 1:

                                    Equipa.adicionaDados();




                                break;


                                case 2:                                             //Adicionar Dados no Membro

                                    Membro.adicionaDadosMembro();



                                    break;



                                case 3:                                             //Adicionar Dados no Projeto







                                    break;

                                case 4:                                             //Adicionar Dados na Tarefa. 

                                    Tarefa.adicionaDadosTarefa();


                                    break;


                            }


                        break;





                    }

                    break;

            }





                    




















            }

        }

    }
