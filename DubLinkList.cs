namespace DoubleLinkedLists
{
    public class DoubleLinkedList
    {
        public DllNode Head;
        public DoubleLinkedList()
        {
            this.Head = null;
        }

        public void Add(int value)
        {
            DllNode newNode = new DllNode(value);
            if(this.Head == null)
            {
                this.Head = newNode;
            }
            else
            {
                DllNode runner = this.Head;
                while(runner.Next != null)
                {
                    runner = runner.Next;
                }
                runner.Next = newNode;
                runner.Next.Prev = runner;
            }

        }
    }
}