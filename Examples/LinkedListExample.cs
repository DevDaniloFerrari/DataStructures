namespace DataStructures.Examples
{
    public class LinkedListExample
    {
        private LinkedList<string> Pages { get; set; }
        private LinkedListNode<string> AtualPage { get; set; }

        public LinkedListExample()
        {
            Pages = new LinkedList<string>();
        }
        //public void Run()
        //{

        //    pages.AddLast("youtube");
        //    pages.AddLast("facebook");
        //    pages.AddLast("instagram");
        //    pages.AddLast("email");
        //    pages.AddLast("azure");

        //    NavigateTo("google");
        //}

        public void NavigateTo(string page)
        {
            Pages.AddLast(page);
            ChangeAtualPage();
        }

        public string Forward()
        {
            if (AtualPage == null)
                return "There is no page to moving forward!";

            AtualPage = AtualPage.Next;
            return AtualPage?.Value;
        }

        public string Backward()
        {
            if (AtualPage == null)
                return "There is no page to moving backward!";

            AtualPage = AtualPage.Previous;
            return AtualPage?.Value;

        }

        private void ChangeAtualPage()
        {
            var last = Pages.Last();
            AtualPage = Pages.FindLast(last);
        }
    }
}
