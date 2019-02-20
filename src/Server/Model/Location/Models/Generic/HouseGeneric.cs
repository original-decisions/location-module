using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using odec.Framework.Generic;

namespace odec.Server.Model.Location.Generic
{
    public class HouseGeneric<T, TStreetId, TStreet, THousing, TFlat> : Glossary<T>
    {
        
        [Column("Number")]
        [StringLength(10)]
        public override string Name { get; set; }

        [Required]
        public TStreetId StreetId { get; set; }

        public TStreet Street { get; set; }

        public virtual ICollection<THousing> Housings { get; set; }

        public virtual ICollection<TFlat> Flats { get; set; }
    }
}
