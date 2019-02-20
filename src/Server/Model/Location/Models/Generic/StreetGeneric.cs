using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using odec.Framework.Generic;

namespace odec.Server.Model.Location.Generic
{
    public class StreetGeneric<T, TCityId, TCity, THouse>:Glossary<T>
    {

        
        [StringLength(255)]
        public override string Name { get; set; }

        [Required]
        public TCityId CityId { get; set; }

        public TCity City { get; set; }

        public virtual ICollection<THouse> Houses { get; set; }
    }
}
