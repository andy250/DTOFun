namespace andy250.Sandbox.TestApp.MapApp
{
    public abstract class DTO
    {
        public string Id;
    }

    public class DTOUser : DTO
    {
        public string Name;
    }

    public class DTOProduct : DTO
    {
        public double Price;
    }
}
