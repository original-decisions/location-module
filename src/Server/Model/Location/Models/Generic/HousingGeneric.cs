using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using odec.Framework.Generic;

namespace odec.Server.Model.Location.Generic
{
    public class HousingGeneric<T,THouseId,THouse> : Glossary<T>
    {

        [Column("Number")]
        [StringLength(10)]
        public override string Name { get; set; }

        [Required]
        public THouseId HouseId { get; set; }

        public THouse House { get; set; }
      
    }
}
