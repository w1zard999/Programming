using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Song
    {
        /// <summary>
        /// Название композиции.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Исполнитель композиции.
        /// </summary>
        public string Artist { get; set; }

        /// <summary>
        /// Длительность композиции в секундах.
        /// </summary>
        private int _duration;

        /// <summary>
        /// Возвращает и задаёт длительность композиции.
        /// </summary>
        public int Duration
        {
            get { return _duration; }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Duration));
                _duration = value;
            }
        }

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public Song() { }

        /// <summary>
        /// Конструктор с заполненными свойствами.
        /// </summary>
        /// <param name="title">Заголовок композиции.</param>
        /// <param name="artist">Исполнитель композиции.</param>
        /// <param name="duration">Продолжительность композиции в секундах.</param>
        public Song(string title, string artist, int duration)
        {
            this.Title = title;
            this.Artist = artist;
            this.Duration = duration;
        }
    }
}
