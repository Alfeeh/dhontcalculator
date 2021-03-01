using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace VotingCalculator
{
    class Extractor
    {
        // Extracts information from the supplied text file and uses it to return a list of Party objects, 
        // each element containing all the relevant information to each party, and other important information.
        public Tuple<string, List<Party>, int, int> Extract(System.IO.StreamReader file)
        {
            string line;
            List<string> lines = new List<string>();

            while ((line = file.ReadLine()) != null) // Prevents the program from crashing when the end of the file is reached.
            {
                lines.Add(line);
            }

            // Extracts the constituency name, total seats and total votes from the first 3 lines.
            string constituencyName = lines[0];
            int totalSeats = Int32.Parse(lines[1]);
            int totalVotes = Int32.Parse(lines[2]);
            List<Party> partyList = new List<Party>();

            // Extracts the party name, original number votes and names of the seats for each party found in the text file.
            for (int i = 3; i < lines.Count; i++)
            {
                var lineList = lines[i].Substring(0, lines[i].Length - 1).Split(",").ToList();
                string partyName = lineList[0];
                int partyVotes = Int32.Parse(lineList[1]);

                List<string> partySeats = lineList.GetRange(2, lineList.Count - 2);
                Party partyObject = new Party(partyName, partyVotes, partySeats); // Instantiates each party object.
                partyList.Add(partyObject);
            }

            return new Tuple<string, List<Party>, int, int>(constituencyName, partyList, totalSeats, totalVotes);
        }
    }
}
