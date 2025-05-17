using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Discipline
    {
        public string _name;
        public string _group;
        private int _score;

        public string Name
        {
            get { return _name; }
            set
            {
                Validator.AssertStringContainsOnlyLetters(value, nameof(Name));
                _name = value;
            }
        }

        public string Group
        {
            get { return _group; }
            set
            {
                Validator.AssertStringContainsOnlyLetters(value, nameof(Group));
                _group = value;
            }
        }

        public int Score
        {
            get { return _score; }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Score));
                _score = value;
            }
        }

        public Discipline() { }

        public Discipline(string name, int credits, string group)
        {
            this.Name = name;
            this.Score = credits;
            this.Group = group;
        }
    }
}
