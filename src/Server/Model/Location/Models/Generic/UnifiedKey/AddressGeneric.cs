using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using odec.Framework.Generic;

namespace odec.Server.Model.Location.Generic.UnifiedKey
{
    /// <summary>
    /// Обобщенный класс адреса
    /// </summary>
    /// <typeparam name="TKey">Тип идентификатора </typeparam>
    /// <typeparam name="TCountry">Тип страны</typeparam>
    /// <typeparam name="TStreet">Тип улицы</typeparam>
    /// <typeparam name="TSubway">Тип Метро</typeparam>
    /// <typeparam name="TCity">Тип города</typeparam>
    /// <typeparam name="THouse">Тип дома</typeparam>
    /// <typeparam name="THousing">Тип корпуса</typeparam>
    /// <typeparam name="TFlat">Тип квартиры</typeparam>
    public class AddressGeneric<TKey, TCountry, TStreet, TSubway, TCity, THouse, THousingKey,THousing, TFlat> : Glossary<TKey>
    {
        /// <summary>
        /// Страна
        /// </summary>
        public TCountry Country { get; set; }
        /// <summary>
        /// Идентификатор страны
        /// </summary>
        public TKey CountryId { get; set; }
        /// <summary>
        /// Идентификатор улицы
        /// </summary>
        public TKey StreetId { get; set; }
        /// <summary>
        /// Улица
        /// </summary>
        public TStreet Street { get; set; }
        /// <summary>
        /// Идентификатор метро
        /// </summary>
        public TKey SubwayId { get; set; }
        /// <summary>
        /// Метро
        /// </summary>
        public TSubway Subway { get; set; }
        /// <summary>
        /// Идентификатор города
        /// </summary>
        public TKey CityId { get; set; }
        /// <summary>
        /// Город
        /// </summary>
        public TCity City { get; set; }
        /// <summary>
        /// Идентификатор дома
        /// </summary>
        public TKey HouseId { get; set; }

        /// <summary>
        /// Дом
        /// </summary>
        public THouse House { get; set; }
        /// <summary>
        /// Идентификатор корпуса
        /// </summary>
        public THousingKey HousingId { get; set; }
        /// <summary>
        /// Корпус
        /// </summary>
        public THousing Housing { get; set; }
        /// <summary>
        /// Идентификатор квартиры
        /// </summary>
        public TKey FlatId { get; set; }
        /// <summary>
        /// Квартира
        /// </summary>
        public TFlat Flat { get; set; }
        /// <summary>
        /// Строковое представление адреса
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [DefaultValue("")]
        public string StringRepresentation { get; set; }

    }
}