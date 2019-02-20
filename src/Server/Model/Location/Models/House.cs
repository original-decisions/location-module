using odec.Server.Model.Location.Generic.UnifiedKey;

namespace odec.Server.Model.Location
{
    /// <summary>
    ///серверный объект, характеризующий номер дома 
    /// </summary>
    public class House:HouseGeneric<int,Street,Housing,Flat>
    {
    }
}
