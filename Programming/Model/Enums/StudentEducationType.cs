using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Enums
{
    /// <summary>
    /// Типы образовательных программ студента.
    /// </summary>
    public enum StudentEducationType
    {
        /// <summary>
        /// Очное обучение.
        /// </summary>
        FullTime,

        /// <summary>
        /// Заочное обучение.
        /// </summary>
        PartTime,

        /// <summary>
        /// Вечерняя форма обучения.
        /// </summary>
        Evening,

        /// <summary>
        /// Дистанционное обучение.
        /// </summary>
        DistanceLearning
    }
}
