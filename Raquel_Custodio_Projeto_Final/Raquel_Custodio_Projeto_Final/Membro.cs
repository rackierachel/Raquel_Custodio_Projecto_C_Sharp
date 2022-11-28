using System;
namespace Raquel_Custodio_Projeto_Final
{
	public class Membro
	{

		public string idMembro { get; set; }

		public string nomeMembro { get; set; }

		public string moradaMembro { get; set; }

		public int telefoneMembro { get; set; }

		public string emailMembro { get; set; }

        public int idadeMembro { get; set; }



		public static void adicionaDadosMembro()


		{


            Console.WriteLine("Quantos Membros pretende Registar?");
            int nmembros = Convert.ToInt32(Console.ReadLine());

			for (int i = 0; nmembros>i; i++)

			{


                Membro lista_Membro = new Membro ();

                Guid idMembro = Guid.NewGuid();						//utilização do guid para construção do ID de equipa
                Console.WriteLine("ID Membro: {0}", idMembro);



                Console.WriteLine("Digite o Nome do Membro: ");
                lista_Membro.nomeMembro = Console.ReadLine();
                Program.listaMembro.Add(lista_Membro);

                Console.WriteLine("Digite a Morada do Membro: ");
                lista_Membro.moradaMembro = Console.ReadLine();
                Program.listaMembro.Add(lista_Membro);

                Console.WriteLine("Digite o telefone do Membro: ");
                lista_Membro.telefoneMembro = int.Parse(Console.ReadLine());
                Program.listaMembro.Add(lista_Membro);

                Console.WriteLine("Digite o email do Membro: ");
                lista_Membro.emailMembro = Console.ReadLine();
                Program.listaMembro.Add(lista_Membro);

                Console.WriteLine("Digite a idade do Membro: ");
                lista_Membro.idadeMembro = Convert.ToInt32(Console.ReadLine());
                Program.listaMembro.Add(lista_Membro);

                foreach (var elemento in Program.listaMembro) //ciclo foreach para impressão dos dados
                {
                    
                    Console.WriteLine(elemento.idMembro);
                    Console.WriteLine(elemento.nomeMembro);
                    Console.WriteLine(elemento.moradaMembro);
                    Console.WriteLine(elemento.telefoneMembro);
                    Console.WriteLine(elemento.emailMembro);
                    Console.WriteLine(elemento.idadeMembro);
                    

                }

                


            }

        }











    }
}

