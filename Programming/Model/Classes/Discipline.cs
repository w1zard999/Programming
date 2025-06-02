using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Discipline
    {
        /// <summary>
        /// Название дисциплины.
        /// </summary>
        public string _name;

        /// <summary>
        /// Группа студентов, изучающая дисциплину.
        /// </summary>
        public string _group;

        /// <summary>
        /// Оценка по дисциплине.
        /// </summary>
        private int _score;

        /// <summary>
        /// Возвращает и задаёт название дисциплины.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                Validator.AssertStringContainsOnlyLetters(value, nameof(Name));
                _name = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт группу студентов.
        /// </summary>
        public string Group
        {
            get { return _group; }
            set
            {
                Validator.AssertStringContainsOnlyLetters(value, nameof(Group));
                _group = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт оценку по дисциплине.
        /// </summary>
        public int Score
        {
            get { return _score; }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Score));
                _score = value;
            }
        }

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public Discipline() { }

        /// <summary>
        /// Конструктор с основными параметрами дисциплины.
        /// </summary>
        /// <param name="name">Название дисциплины.</param>
        /// <param name="credits">Оценка (количество баллов).</param>
        /// <param name="group">Группа студентов.</param>
        public Discipline(string name, int credits, string group)
        {
            this.Name = name;
            this.Score = credits;
            this.Group = group;
        }
    }
}
