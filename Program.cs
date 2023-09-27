namespace DataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedListExample();
        }

        public static void LinkedListExample()
        {
            var pages = new LinkedList<string>();

            pages.AddLast("youtube");
            pages.AddLast("facebook");
            pages.AddLast("instagram");
            pages.AddLast("email");
            pages.AddLast("azure");

            var last = pages.Last();
            var atualPage = pages.FindLast(last);

            Console.WriteLine(atualPage.Value);
            Console.WriteLine(atualPage.Previous.Value);
        }

    }
}