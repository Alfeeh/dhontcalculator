using System;
using System.Collections.Generic;
using System.IO;

namespace VotingCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string textFile = File.ReadAllText("Assessment1Data.txt");
            Extractor data = new Extractor();
            //List<Party> partyList = Extractor.Extract(textFile);
            DHondt x = new DHondt();
            DHondt.Calculate(data, textFile);
        }
    }
}
