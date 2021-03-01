using System;
using System.Collections.Generic;
using System.IO;

namespace VotingCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // read assessment data file, access Extractor and DHondt classes
            System.IO.StreamReader textFile = new System.IO.StreamReader(@"Assessment1Data.txt");
            Extractor data = new Extractor();
            DHondt Calculator = new DHondt();

            // calculate final results and output them to console
            var (constituencyName, electorals) = Calculator.Calculate(data, textFile);
            Calculator.OutputToConsole(constituencyName, electorals);
        }
    }
}
