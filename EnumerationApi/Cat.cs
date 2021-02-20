namespace EnumerationApi
{
    public class Cat : Enumeration
    {
        public static Cat BritishLongHair = new Cat(1, "British Long Hair");
        public static Cat BritishBlueShortHair = new Cat(2, "British Blue Short Hair");

        public Cat(int id, string name) 
            : base(id, name) { }
    }
}
