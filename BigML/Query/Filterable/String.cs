namespace BigML.Meta
{
    public class String : Object
    {
        String(string name): base(name)
        {
        }

        public static Bool operator ==(String c1, string c2)
        {
            return default(Bool);
        }

        public static Bool operator !=(String c1, string c2)
        {
            return default(Bool);
        }
    }
}