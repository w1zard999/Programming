using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Discipline
    {
        public string Name { get; set; }
        public string Grade { get; set; }
        private int _score;

        public int Score
        {
            get { return _score; }
            set
            {
                if (value < 0 || value > 5) 
                    throw new ArgumentException("Оценка не может быть отрицательной");
                _score = value;
            }
        }

        public Discipline() { }

        public Discipline(string name, int credits, string grade)
        {
            this.Name = name;
            this.Score = credits;
            this.Grade = grade;
        }
    }
}
