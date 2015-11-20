namespace andy250.Sandbox.TestApp.MapApp
{
    public abstract class Model
    {
        public string Id;
    }

    public class ModelUser : Model
    {
        public string Name;

        public override string ToString()
        {
            return string.Format("U {0} = {1}", Id, Name);
        }
    }

    public class ModelProduct : Model
    {
        public double Price;

        public override string ToString()
        {
            return string.Format("P {0} = {1}", Id, Price);
        }
    }
}