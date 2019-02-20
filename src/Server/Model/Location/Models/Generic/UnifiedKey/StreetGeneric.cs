using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using odec.Framework.Generic;

namespace odec.Server.Model.Location.Generic.UnifiedKey
{
    /// <summary>
    /// Обощенный класс - улица
    /// </summary>
    /// <typeparam name="TKey">Тип идентификатора</typeparam>
    /// <typeparam name="TCity">Тип города</typeparam>
    /// <typeparam name="THouse">Тип дома</typeparam>
    public class StreetGeneric<TKey, TCity, THouse> : Glossary<TKey>
    {
        /// <summary>
        /// название улицы
        /// </summary>
        [StringLength(255)]
        public override string Name { get; set; }
        /// <summary>
        /// Идентификатор города
        /// </summary>
        [Required]
        public TKey CityId { get; set; }
        /// <summary>
        /// Город
        /// </summary>
        public TCity City { get; set; }
        /// <summary>
        /// Список домов этой улицы
        /// </summary>
        public virtual ICollection<THouse> Houses { get; set; }
    }
}
