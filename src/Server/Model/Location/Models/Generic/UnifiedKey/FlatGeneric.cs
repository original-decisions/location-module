using System.ComponentModel.DataAnnotations;
using odec.Framework.Generic;

namespace odec.Server.Model.Location.Generic.UnifiedKey
{
    /// <summary>
    /// Обощенный класс- Квартира
    /// </summary>
    /// <typeparam name="TKey">Тип идентификатора</typeparam>
    /// <typeparam name="THouse">Тип Дома</typeparam>
    public class FlatGeneric<TKey, THouse> : Glossary<TKey>
    {
        /// <summary>
        /// Номер дома
        /// </summary>
        [StringLength(10)]
        public override string Name { get; set; }
        /// <summary>
        /// Идентификатор дома
        /// </summary>
        [Required]
        public TKey HouseId { get; set; }
        /// <summary>
        /// Дом
        /// </summary>
        public THouse House { get; set; }

       
    }
}
