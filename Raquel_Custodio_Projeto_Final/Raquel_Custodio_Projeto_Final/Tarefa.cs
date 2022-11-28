using System;
namespace Raquel_Custodio_Projeto_Final
{
    public class Tarefa
    {

        public Tarefa()                                 //Construtor para utilizar o GUID
        {


            Guid idTarefa = Guid.NewGuid();
            String idTarefaS = idTarefa.ToString();
            Console.WriteLine("ID Tarefa: {0}", idTarefa);


        }



        //propriedades da tarefa

        public string idTarefa { get; set; } 

        public string tituloTarefa { get; set; }

        public int dataInicioTarefa { get; set; }

        public int dataFimTarefa { get; set; }

        public string estadoTarefa { get; set; }


        

    public static void adicionaDadosTarefa()   //Função para adicionar dados à Tarefa


    {


        Console.WriteLine("Quantas Tarefas pretende Registar?");
        int ntarefas = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; ntarefas > i; i++)

            {


                Tarefa lista_Tarefa = new Tarefa();

                /*Guid idTarefa = Guid.NewGuid();                     //utilização do guid para construção do ID de equipa
                Console.WriteLine("ID Tarefa: {0}", idTarefa);*/



                Console.WriteLine("Digite o Titulo da Tarefa: ");
                lista_Tarefa.tituloTarefa = Console.ReadLine();
                Program.listaTarefa.Add(lista_Tarefa);



                Console.WriteLine("Digite a Data de Inicio da Tarefa: ");
                lista_Tarefa.dataInicioTarefa = int.Parse(Console.ReadLine());
                Program.listaTarefa.Add(lista_Tarefa);

                Console.WriteLine("Digite a Data do Fim da Tarefa: ");
                lista_Tarefa.dataFimTarefa = int.Parse(Console.ReadLine());
                Program.listaTarefa.Add(lista_Tarefa);


                Console.WriteLine("Digite o Estado da Tarefa: ");
                lista_Tarefa.estadoTarefa = Console.ReadLine();
                Program.listaTarefa.Add(lista_Tarefa);




                foreach (var elemento in Program.listaTarefa) //ciclo foreach para impressão dos dados
                {


                    Console.WriteLine(elemento.tituloTarefa);
                    Console.WriteLine(elemento.dataInicioTarefa);
                    Console.WriteLine(elemento.dataFimTarefa);
                    Console.WriteLine(elemento.estadoTarefa);



                }

            }


        }
    }
}