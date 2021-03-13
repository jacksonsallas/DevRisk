using DevRiskConsole;
using System;
using System.IO;

namespace CategorizeConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to DevRisk");

            var validFile = false;
            var negotiations = new NegotiationTrade();

            while (!validFile)
            {
                Console.WriteLine("Please, inform the complet file path: ");
                var pathFile = Console.ReadLine();

                if (string.IsNullOrEmpty(pathFile) || !File.Exists(pathFile))
                    Console.WriteLine("Incorrect path file, inform a file path valid, please");
                else
                {
                    validFile = true;
                    var proccesFile = new ProcessFile();
                    negotiations = proccesFile.GetDataFile(pathFile);
                }
            }

            Console.WriteLine();
            var tc = new TradeClassifier();
            tc.Classifier(negotiations);

            Console.ReadKey();            
        }
    }
}
