using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;

namespace VotingCalculator
{
    class DHondt
    {
        // the DHondt methods is used to calculate (number of sets / by the origanal votes)
        public Tuple<string, List<Party>> Calculate(Extractor data, System.IO.StreamReader textFile)
        {
            var (constituencyName, partyList, totalSeats, totalVotes) = data.Extract(textFile);
            
            // for the amount of total seats, divide current votes by original +1 and sort list for next iteration
            for (int i = 0; i < totalSeats; i++)
            {
                partyList.Sort((x, y) => y.currentVotes.CompareTo(x.currentVotes));
                partyList[0].amountOfSeats += 1;
                partyList[0].currentVotes = partyList[0].originalVotes / (partyList[0].amountOfSeats + 1);
            }

            return new Tuple<string, List<Party>>(constituencyName, partyList);

        }

        // outputs the names of the elected seats to the console (sorted)
        public void OutputToConsole(string constituencyName, List<Party> electorals)
        {
            // output constituency name, iterates through each seat
            Console.WriteLine(constituencyName);
            for (int i = 0; i < electorals.Count; i++) 
            {
                // if seats exist, output a seat name for each existing seat
                if (electorals[i].amountOfSeats > 0)
                {
                    Console.Write($"{electorals[i].name}");
                    for(int j = 0; j < electorals[i].amountOfSeats; j++)
                    {
                        Console.Write($",{electorals[i].namesOfSeats[j]}");
                    }
                    Console.WriteLine(";");

                }
            }
           
        }

    }


}
