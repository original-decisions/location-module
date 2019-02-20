using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using odec.Framework.Generic;

namespace odec.Server.Model.Location.Generic
{
    public class AddressGeneric<T, TCountryId, TCountry, TStreetId, TStreet, TSubwayId, TSubway, TCityId, TCity, THouseId, THouse, THousingId, THousing, TFlatId, TFlat> :Glossary<T>
    {
        [Required(AllowEmptyStrings = true)]
        [DefaultValue("")]
        public string StringRepresentation { get; set; }
        public TCountry Country { get; set; }

        public TCountryId CountryId { get; set; }

        public TStreetId StreetId { get; set; }

        public TStreet Street { get; set; }

        public TSubwayId SubwayId { get; set; }

        public TSubway Subway { get; set; }

        public TCityId CityId { get; set; }

        public TCity City { get; set; }

        public THouseId HouseId { get; set; }


        public THouse House { get; set; }

        public THousingId HousingId { get; set; }
        public THousing Housing { get; set; }

        public TFlatId FlatId { get; set; }
        public TFlat Flat { get; set; }

    }
}