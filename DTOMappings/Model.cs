namespace ConsoleApplication1
{
    public abstract class Model { }

    public class ModelUser : Model
    {
        public string Name;

        public override string ToString()
        {
            return "U " + Name;
        }
    }

    public class ModelProduct : Model
    {
        public string Id;

        public override string ToString()
        {
            return "P " + Id;
        }
    }
}