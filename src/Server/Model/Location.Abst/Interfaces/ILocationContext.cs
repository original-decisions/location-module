
using Microsoft.EntityFrameworkCore;
namespace odec.CP.Server.Model.Location.Abst.Interfaces
{
    /// <summary>
    /// Прокси объект контекста расположения
    /// </summary>
    /// <typeparam name="TAddress">Тип адреса</typeparam>
    /// <typeparam name="TCountry">Тип страны</typeparam>
    /// <typeparam name="TCity">Тип города</typeparam>
    /// <typeparam name="TSubway">Тип метро</typeparam>
    /// <typeparam name="TStreet">Тип улицы</typeparam>
    /// <typeparam name="THouse">Тип дома</typeparam>
    /// <typeparam name="THousing">Тип коруса</typeparam>
    /// <typeparam name="TFlat">Тип квартиры</typeparam>
    public interface ILocationContext<TAddress, TCountry, TCity, TSubway, TStreet, THouse, THousing, TFlat>
        where THousing : class
        where TFlat : class
        where THouse : class
        where TStreet : class
        where TSubway : class
        where TCity : class
        where TCountry : class
        where TAddress : class
    {
        /// <summary>
        /// Таблица связи адресов
        /// </summary>
        DbSet<TAddress> Addresses { get; set; }

        /// <summary>
        /// Таблица связи стран
        /// </summary>
        DbSet<TCountry> Countries { get; set; }

        /// <summary>
        /// Таблица связи городов
        /// </summary>
        DbSet<TCity> Cities { get; set; }

        /// <summary>
        /// Таблица связи метро
        /// </summary>
        DbSet<TSubway> Subways { get; set; }

        /// <summary>
        /// Таблица связи улиц
        /// </summary>
        DbSet<TStreet> Streets { get; set; }

        /// <summary>
        /// Таблица связи домов
        /// </summary>
        DbSet<THouse> Houses { get; set; }

        /// <summary>
        /// Таблица связи корпусов
        /// </summary>
        DbSet<THousing> Housings { get; set; }

        /// <summary>
        /// Таблица связи квартир
        /// </summary>
        DbSet<TFlat> Flats { get; set; }
    }
}
