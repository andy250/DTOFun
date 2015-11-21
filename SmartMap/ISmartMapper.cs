using System.Collections.Generic;

namespace andy250.Sandbox.SmartMap
{
    public interface ISmartMapper<in TSrc, TDest>
    {
        List<TDest> Map(IEnumerable<TSrc> dataToMap);
        TDest Map(TSrc item);
    }
}