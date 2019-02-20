using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using odec.Framework.Generic;

namespace odec.Server.Model.Location.Generic.UnifiedKey
{
    /// <summary>
    /// Обобщенный класс - корпус
    /// </summary>
    /// <typeparam name="TKey">Тип идентификтора</typeparam>
    /// <typeparam name="THouse">Тип дома</typeparam>
    public class HousingGeneric<TKey, THouse> : Glossary<TKey>
    {
        /// <summary>
        /// НОмер корпуса
        /// </summary>
        [Column("Number")]
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
