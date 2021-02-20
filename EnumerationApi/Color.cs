namespace EnumerationApi
{
    public class Color : Enumeration
    {
        public static Color Red = new Color(1, "Red");
        public static Color Purple = new Color(2, "Purple");
        public static Color Green = new Color(3, "Green");

        public Color(int id, string name) 
            : base(id, name) { }
    }
}
