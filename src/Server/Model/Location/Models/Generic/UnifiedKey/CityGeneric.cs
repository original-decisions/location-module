using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using odec.Framework.Generic;

namespace odec.Server.Model.Location.Generic.UnifiedKey
{
    /// <summary>
    /// Обобщенный класс город
    /// </summary>
    /// <typeparam name="TKey">ТИп идентификатора</typeparam>
    /// <typeparam name="TAddress">Тип Адреса</typeparam>
    /// <typeparam name="TSubway">Тип Метро</typeparam>
    public class CityGeneric<TKey, TAddress, TSubway> : Glossary<TKey>
    {
        /// <summary>
        /// Имя
        /// </summary>
        [StringLength(255)]
        public override string Name { get; set; }

        /// <summary>
        /// Регион
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [StringLength(100)]//name 2
        [DefaultValue("")]
        public string Region { get; set; }
        /// <summary>
        /// Название в родительном
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [StringLength(100)]//name 2
        [DefaultValue("")]
        public string Genitive { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [StringLength(100)]//name 3
        [DefaultValue("")]
        public string Prepositional { get; set; }
        /// <summary>
        /// Телефонный код
        /// </summary>
        [Required]
        [DefaultValue(0)]
        public int PhoneCode { get; set; }
        //TODO:Возможно они не нужны
        /// <summary>
        /// Список адресов
        /// </summary>
        public virtual ICollection<TAddress> Addresses { get; set; }
        /// <summary>
        /// Список метро
        /// </summary>
        public virtual ICollection<TSubway> Subways { get; set; }
    }
}
