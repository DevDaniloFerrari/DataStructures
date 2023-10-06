namespace DataStructures.Examples
{
    public class StackExample
    {
        public string[] Stack { get; set; }
        public int Top { get; set; }
        public int MaxSize { get; set; }

        public StackExample(int size)
        {
            Stack = new string[size];
            Top = -1;
            MaxSize = size;
        }

        public void Push(string value)
        {
            if (IsFull())
            {
                Console.WriteLine("Stack Overflow");
                return;
            }

            Stack[Top++] = value;
        }

        public string Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack Underflow");
                return null;
            }

            var value = Stack[Top];
            Stack[Top] = null;
            Top = Top--;

            return value;
        }

        public string Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack Underflow");
                return null;
            }

            return Stack[Top];
        }

        private bool IsFull() => Top + 1 == MaxSize;
        private bool IsEmpty() => Top == -1;
    }
}
