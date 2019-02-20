using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using odec.Framework.Generic;

namespace odec.Server.Model.Location.Generic
{
    public class SubwayGeneric<T, TCityId, TCity, TAddress> : Glossary<T>
    {
        [StringLength(50)]
        public override string Name { get; set; }

        [Required]
        public TCityId CityId { get; set; }
        public TCity City { get; set; }

        public virtual ICollection<TAddress> Adresses { get; set; }
    }
}
