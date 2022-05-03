using System;
using System.IO;

namespace QuakeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            const string path = "D:\\Pedro\\Teste Prático Quake\\Quake.txt";

            var lines = File.ReadAllLines(path);
            foreach(var line in lines)
            {
                Reader.NewGame(line);
                Reader.InitGame(line);
                Reader.ConnectedClients(line);
            }
        }
    }
}
