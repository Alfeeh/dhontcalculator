using System;
using System.Collections.Generic;
using System.Text;

namespace VotingCalculator
{
    class DHondt
    {
        // int amount of seats
        //for (int x = 0, int y = 5; x < y; x++ )
        //{
        //new votes =  votes /(1 + seats)
        // seats = seats + 1 
        //}


        public void Calculate(Extractor data, string textFile)
        {
            List<Party> partyList = data.Extract(textFile);
            Console.WriteLine(partyList);
        }
    }
}
