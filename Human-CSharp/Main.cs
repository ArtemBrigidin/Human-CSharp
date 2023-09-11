namespace Human
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human Child = new Human("имя", "Мужской", 5, null, null, null);
            Human Mother = new Human("имя", "Женский", 6, null, null, Child);
            Human Father = new Human("имя", "Мужской", 7, null, null, Child);

            Child.SetParent(Father, Mother);

            Child.GetInfo();
            Console.WriteLine(Mother.ToString());
        }
    }
}