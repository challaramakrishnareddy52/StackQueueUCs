namespace StackQueueUCs
{
    public class LinkedListStack
    {
        private Node top;
        internal Node Top { get => top; set => top = value; }
        public void Push(int data)      
        {
            Node newNode = new Node(data);
            if (Top != null)
            {
                newNode.next = Top;   
            }
            Top = newNode;  
            Console.WriteLine($"New Node {data} is added.");
        }

        public void Display()           
        {
            Console.WriteLine("Displaying Nodes ");
            Node temp = this.Top;
            if (temp == null)
            {
                Console.WriteLine("List is Empty");
                return;
            }
            else
            {
                while (temp != null)
                {
                    Console.WriteLine("Value in the stack : " + temp.data);
                    temp = temp.next;
                }
            }
            Console.WriteLine();
        }
    }
}
