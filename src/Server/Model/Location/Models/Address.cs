using odec.Server.Model.Location;
using odec.Server.Model.Location.Generic.UnifiedKey;

namespace odec.CP.Server.Model.Location
{
    /// <summary>
    /// серверный объект - адрес
    /// </summary>
    public class Address : AddressGeneric<int,Country,Street,Subway,City,House,int?,Housing,Flat>
    {
    }
}