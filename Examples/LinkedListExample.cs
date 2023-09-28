namespace DataStructures.Examples
{
    public class LinkedListExample
    {
        private LinkedList<string> Pages { get; set; }
        private LinkedListNode<string> CurrentPage { get; set; }

        public LinkedListExample()
        {
            Pages = new LinkedList<string>();
        }

        public void NavigateTo(string page)
        {
            Pages.AddLast(page);
            ChangeCurrentPage();
        }

        public string Forward()
        {
            if (CurrentPage == null)
                return "There is no page to moving forward!";

            CurrentPage = CurrentPage.Next;
            return CurrentPage?.Value;
        }

        public string Backward()
        {
            if (CurrentPage == null)
                return "There is no page to moving backward!";

            CurrentPage = CurrentPage.Previous;
            return CurrentPage?.Value;

        }

        private void ChangeCurrentPage()
        {
            var last = Pages.Last();
            CurrentPage = Pages.FindLast(last);
        }

        public string GetCurrentPage()
        {
            return CurrentPage?.Value;
        }
    }
}
