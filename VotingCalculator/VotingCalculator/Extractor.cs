using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace VotingCalculator
{
    class Extractor
    {
        public List<Party> Extract(string textFile)
        {
            string line;
            List<string> lines = new List<string>();
            System.IO.StreamReader file =
                new System.IO.StreamReader(@"Assessment1Data.txt");

            while ((line = file.ReadLine()) != null)
            {
                lines.Add(line);
            }

            int totalSeats = Int32.Parse(lines[1]);
            int totalVotes = Int32.Parse(lines[2]);
            List<Party> partyList = new List<Party>();

            for (int i = 3; i < lines.Count ; i++)
            {
                var lineList = lines[i].Substring(0, lines[i].Length - 1).Split(",").ToList();
                string partyName = lineList[0];
                int partyVotes = Int32.Parse(lineList[1]);

                List<string> partySeats = lineList.GetRange(2, lineList.Count - 2);
                Party partyObject = new Party(partyName, partyVotes, partySeats);
                partyList.Add(partyObject);
            }
            
            return partyList;
        }
    }
}
