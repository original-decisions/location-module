using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using odec.Framework.Generic;

namespace odec.Server.Model.Location.Generic.UnifiedKey
{
    /// <summary>
    /// Обоющенный класс - Дом
    /// </summary>
    /// <typeparam name="TKey">Тип идентификатора</typeparam>
    /// <typeparam name="TStreet">Тип улицы</typeparam>
    /// <typeparam name="THousing">ТИп корпуса</typeparam>
    /// <typeparam name="TFlat">Тип квартиры</typeparam>
    public class HouseGeneric<TKey, TStreet, THousing, TFlat> : Glossary<TKey>
    {
        /// <summary>
        /// Номер дома
        /// </summary>
        [Column("Number")]
        [StringLength(10)]
        public override string Name { get; set; }
        /// <summary>
        /// Идентификтор улицы
        /// </summary>
        [Required]
        public TKey StreetId { get; set; }
        /// <summary>
        /// Улица
        /// </summary>
        public TStreet Street { get; set; }
        /// <summary>
        /// Список корпусов этого дома
        /// </summary>
        public virtual ICollection<THousing> Housings { get; set; }
        /// <summary>
        /// Список квартир этого дома
        /// </summary>
        public virtual ICollection<TFlat> Flats { get; set; }
    }
}
