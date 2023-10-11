using DataStructures.Examples;

namespace DataStructures
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedListExample();
            StackExample();
        }

        public static void LinkedListExample()
        {
            var browserService = new BrowserService();

            browserService.NavigateTo("youtube");
            browserService.NavigateTo("facebook");
            browserService.NavigateTo("instagram");
            browserService.NavigateTo("email");
            browserService.NavigateTo("azure");

            Console.WriteLine(browserService.GetCurrentPage()); //azure

            browserService.Backward();

            Console.WriteLine(browserService.GetCurrentPage()); //email

            browserService.Backward();
            browserService.Backward();

            Console.WriteLine(browserService.GetCurrentPage()); //facebook

            browserService.Forward();

            Console.WriteLine(browserService.GetCurrentPage()); //instagram

            browserService.Forward();
            browserService.Forward();
            browserService.Forward();

            Console.WriteLine(browserService.GetCurrentPage()); //azure
        }

        public static void StackExample()
        {

        }
    }
}