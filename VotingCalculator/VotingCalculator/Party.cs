using System;
using System.Collections.Generic;
using System.Text;

namespace VotingCalculator
{
    class Party
    {
        // Private Variables 
        private int _originalVotes;
        private int _currentVotes;
        private string _name;
        private List<string> _namesOfSeats = new List<string>();
        private int _amountOfSeats;
        // Prrivate Variables

        // Public Variables / Get and Set
        public int originalVotes
        {
            get { return _originalVotes; }
            set { _originalVotes = value;  }

        }

        public int currentVotes
        {
            get { return _currentVotes; }
            set { _currentVotes = value; }
        }

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        public List<string> namesOfSeats
        {
            get { return _namesOfSeats; }
            set { _namesOfSeats = value; }

        }

        public int amountOfSeats
        {
            get { return _amountOfSeats;  }
            set { _amountOfSeats = value; }
        }
        // Public Variables / Get and Set

        // Constructor - Allows object variables to be set upon instantiation of the object.
        public Party(string partyName, int partyVotes, List<string> partySeats)
        {
            name = partyName;
            originalVotes = currentVotes = partyVotes;
            namesOfSeats = partySeats;
            amountOfSeats = 0;
        }
        // Constructor


    }
}
    
