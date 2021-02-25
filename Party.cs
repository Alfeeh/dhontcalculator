using System;
using System.Collections.Generic;
using System.Text;

namespace VotingCalculator
{
    class Party
    {
        private int _votes;
        private string _name;
        private List<string> _seats = new List<string>();

        public int votes
        {
            get { return _votes; }
            set { _votes = value; }
        }

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        public List<string> seats
        {
            get { return _seats; }
            set { _seats = value; }

        }

        public Party(string partyName, int partyVotes, List<string> partySeats)
        {
            name = partyName;
            votes = partyVotes;
            seats = partySeats;
        }


    }
}
    