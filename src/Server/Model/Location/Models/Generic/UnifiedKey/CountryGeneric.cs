using System.ComponentModel.DataAnnotations;
using odec.Framework.Generic;

namespace odec.Server.Model.Location.Generic.UnifiedKey
{
    /// <summary>
    /// Обобщенный класс - страна
    /// </summary>
    /// <typeparam name="TKey">Тип идентификатора</typeparam>
    public class CountryGeneric<TKey> : Glossary<TKey>
    {
        /// <summary>
        /// Имя
        /// </summary>
        [StringLength(70)]
        public override string Name { get; set; }

       
    }
}