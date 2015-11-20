namespace andy250.Sandbox.SmartMap
{
    public interface IMapper<in TSrc, out TDest>
    {
        TDest Map(TSrc item);
    }
}
