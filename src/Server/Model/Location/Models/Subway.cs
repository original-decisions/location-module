using odec.CP.Server.Model.Location;
using odec.Server.Model.Location.Generic.UnifiedKey;

namespace odec.Server.Model.Location
{
   // [Table("Subways", Schema = "location")]
    /// <summary>
    /// Серверный объект - метро?
    /// </summary>
    public class Subway:SubwayGeneric<int,City,Address>
    {
    }
}
