using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using odec.Framework.Generic;

namespace odec.Server.Model.Location.Generic.UnifiedKey
{
    //TODO:Analize this class
    /// <summary>
    /// Обобщенный класс-метро
    /// </summary>
    /// <typeparam name="TKey">ТИп идентификатора</typeparam>
    /// <typeparam name="TCity">Тип города</typeparam>
    /// <typeparam name="TAddress">Тип адреса</typeparam>
    public class SubwayGeneric<TKey, TCity, TAddress> : Glossary<TKey>
    {
        /// <summary>
        /// Название метро
        /// </summary>
        [StringLength(50)]
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
        /// Список адресов этого метро
        /// </summary>
        public virtual ICollection<TAddress> Addresses { get; set; }
    }
}
