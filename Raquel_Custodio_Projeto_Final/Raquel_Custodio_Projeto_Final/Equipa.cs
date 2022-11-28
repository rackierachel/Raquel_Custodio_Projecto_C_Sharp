using System;
using System.Collections;
using System.Collections.Generic;

namespace Raquel_Custodio_Projeto_Final
{
	public class Equipa
	{
		/*public Equipa() {				// construtor - Bob. 

			

		}*/

		public string idEquipa { get; set; }

		public string nomeEquipa { get; set; }

		public string membrosEquipa { get; set; }

		public List<Membro> Membro { get; set; }			//associação da lista membros a propriedade




		public static void adicionaDados()					//chamada da lista por parametro
		{

			Console.WriteLine("Quantas Equipas pretende Registar?");
			int nequipas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n");





            for (int i = 0; nequipas > i; i++)
			{

				

                Equipa lista_equipa = new Equipa();



                String idEquipa = System.Guid.NewGuid().ToString();					//utilização do guid para construção do ID de equipa
                Console.WriteLine("ID Equipa: {0}", idEquipa);

                




                Console.WriteLine("Digite o Nome da Equipa: ");
				lista_equipa.nomeEquipa = Console.ReadLine();
                Program.listaEquipa.Add(lista_equipa);

				
				
				


                




            }

            foreach (var elemento in Program.listaEquipa)			//ciclo foreach para impressão dos dados
            {
                Console.WriteLine(elemento.idEquipa);
                Console.WriteLine(elemento.nomeEquipa);
				Console.WriteLine(elemento.Membro);

				
			

            }

            




        }



	}



}




			

	

		

		








	



	


