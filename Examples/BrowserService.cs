namespace DataStructures.Examples
{
    public class BrowserService
    {
        private LinkedList<string> Pages { get; set; }
        private LinkedListNode<string> CurrentPage { get; set; }

        public BrowserService()
        {
            Pages = new LinkedList<string>();
        }

        public void NavigateTo(string page)
        {
            Pages.AddLast(page);
            ChangeCurrentPage();
        }

        public void Forward()
        {
            CurrentPage = CurrentPage?.Next;
        }

        public void Backward()
        {
            CurrentPage = CurrentPage?.Previous;
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
