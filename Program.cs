using DataStructures.Examples;

namespace DataStructures
{
    public class Program
    {
        static void Main(string[] args)
        {
            var browserTabs = new LinkedListExample();

            browserTabs.NavigateTo("youtube");
            browserTabs.NavigateTo("facebook");
            browserTabs.NavigateTo("instagram");
            browserTabs.NavigateTo("email");
            browserTabs.NavigateTo("azure");

            Console.WriteLine(browserTabs.GetCurrentPage()); //azure

            browserTabs.Backward();

            Console.WriteLine(browserTabs.GetCurrentPage()); //email

            browserTabs.Backward();
            browserTabs.Backward();

            Console.WriteLine(browserTabs.GetCurrentPage()); //facebook

            browserTabs.Forward();

            Console.WriteLine(browserTabs.GetCurrentPage()); //instagram

        }
    }
}