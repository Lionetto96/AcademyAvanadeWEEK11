using GestioneOrdiniService;
using System;

namespace GestioneOrdini_CLIENT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ClienteServiceClient client = new ClienteServiceClient();
            Console.WriteLine("Gestione Ordini");
            bool exit = true;
            do
            {
                Console.WriteLine("inserisci l'opzione di tuo interesse " +
                "\n[1] visualizza tutti clienti" +
                "\n[2]  crea nuovo cliente " +
                "\n[3] aggiorna cliente" +
                "\n[4]  elimina cliente"+
                "\n[5] visualizza uno specifico cliente "+
                "\n[6] esci");
                var scelta = Console.ReadKey().KeyChar;

                switch (scelta)
                {
                    case '1':
                        var clienti = client.GetAllClienti();
                        Console.WriteLine("lista clienti");
                        foreach (var item in clienti)
                        {
                            Console.WriteLine($"cliente: {item.Id} - {item.CodiceCliente} - {item.Nome} - {item.Cognome}");
                        }
                        break;
                    case '2':
                        Console.WriteLine("aggiunta cliente");


                        var nuovoCliente = new Cliente()
                        {
                            Id = 3,
                            CodiceCliente = "C003",
                            Nome = "Franco",
                            Cognome = "Gialli",

                        };
                        var AddC = client.CreateCliente(nuovoCliente);
                        Console.WriteLine(AddC);
                        break;
                    case '3':
                        Console.WriteLine("aggiorna cliente");
                        Console.WriteLine("inserisci id cliente da aggiornare");
                        var id = int.Parse(Console.ReadLine());
                        var cliente = client.GetClienteById(id);
                        var upC = client.UpdateCliente(cliente);
                        Console.WriteLine(upC);
                        break;
                    case '4':
                        Console.WriteLine("elimina cliente");
                        Console.WriteLine("inserisci id cliente da eliminare ");
                        var id1 = int.Parse(Console.ReadLine());
                        var delC = client.DeleteClienteById(id1);
                        Console.WriteLine(delC);
                        break;
                    case '5':

                        Console.WriteLine("stampa un cliente specifico");
                        Console.WriteLine("inserisci id cliente da visualizzare ");
                        var id2 = int.Parse(Console.ReadLine());
                        var stampaC = client.GetClienteById(id2);
                        Console.WriteLine($"cliente: {stampaC.Id} - {stampaC.CodiceCliente} - {stampaC.Nome} - {stampaC.Cognome}");
                        break;
                    case '6':
                        exit = false;
                        Console.WriteLine("arrivederci");
                        break;
                    default:
                        Console.WriteLine("scelta non valida!! scegli un numero tra quelli proposti");
                        break;
                }
            } while (exit);
          
            
            

          

           




        }
    }
}
