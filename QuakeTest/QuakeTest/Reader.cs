using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuakeTest
{
    class Reader
    {
        public static List<Match> Matchs { get; set; }

        public static void ReadLine(string line)
        {
            if (NewGame(line))
            {

            }
        }

        public static bool NewGame(string line)
        {
            if (line.EndsWith("---"))
            {
                Console.WriteLine("---------------------------------------------------");
                return true;
            }

            return false;
        }

        public static bool InitGame(string line)
        {
            if (line.Contains("InitGame")){
                Console.WriteLine("Game iniciado: " + line.Substring(1, 5));
                return true;
            }

            return false;
        }

        public static int ConnectedClients(string line)
        {
            if (line.Contains("ClientConnect"))
            {
                string clients = line.Substring(22);
                int clientsQuantity = int.Parse(clients);
                Console.WriteLine("Clientes conectados: " + clientsQuantity);
                return clientsQuantity;
            }
            return 0;
        }
    }
}
