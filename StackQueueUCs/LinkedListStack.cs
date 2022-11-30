namespace StackQueueUCs
{
    public class LinkedListStack
    {
        private Node top;

        internal Node Top { get => top; set => top = value; }

        public void Push(int data)      //UC1 .
        {
            Node newNode = new Node(data);
            if (Top != null)
            {
                newNode.next = Top;   
            }
            Top = newNode;  
            Console.WriteLine($"New Node {data} is added.");
        }
        public int Peek()      
        {
            if (Top == null)
            {
                Console.WriteLine("List is Empty");
                return 0;
            }
            else
            {
                Console.WriteLine("Top most element is : " + Top.data);
                return Top.data;
            }
        }
        public void Pop()       
        {
            if (Top == null)
            {
                Console.WriteLine("List is Empty");
            }
            else
            {
                Console.WriteLine("Removed top most element : " + Peek());
                Top = Top.next;
            }
        }
        public bool isEmpty()
        {
            if (Top == null)
            {
                Console.WriteLine("Stack is Empty");
                return true;
            }
            else
            {
                while (Top != null)
                {
                    Pop();
                }
                return true;
            }
        }

        public void Display()           //Display()
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
