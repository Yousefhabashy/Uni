namespace DoublyLinkedListAddition
{
    // write a C# program to implement Doubly Linked List insertion a node at the beginning, end, and at a given position in a Doubly Linked List 
    internal class Program
    {
        
        public class LinkedList
        {

            public class Node
            {
                public int data;
                public Node next;
                public Node prev;

                public Node()
                {
                    next = null;
                    prev = null;
                }
                public Node(int value)
                {
                    data = value;
                    next = null;
                    prev = null;
                }
            }

            Node head;
            public LinkedList()
            {
                head = null;
            }

            public void insert(int value)
            {
                Node newNode = new Node(value);

                if (head == null)
                {
                    head = newNode;
                }
                else 
                {
                    Node temp = head;
                    while (temp.next != null)
                    {
                        temp = temp.next;
                    }
                    temp.next = newNode;
                    newNode.prev = temp;
                }
            }

            public void appendAt (int value, int index)
            {
                Node newNode = new Node(value);

                if (head == null)
                {
                    head = newNode;
                    return;
                }
                
                if (index == 0 )
                {
                    newNode.next = head;
                    head.prev = newNode;
                    head = newNode;
                    return;
                }

                Node temp = head;
                
                for (int i = 0; i < index && temp != null; i++ )
                {
                    temp = temp.next;
                }

                if (temp == null) 
                {
                    insert(value);
                    return;
                }

                newNode.prev = temp.prev;
                temp.prev.next = newNode;
                temp.prev = newNode;
                newNode.next = temp;
            }

            public void remove (int value)
            {
                if (head == null)
                {
                    return;
                }

                Node temp = head;
                if (temp.data == value)
                {
                    head = temp.next;
                    if (head != null)
                    {
                        head.prev = null;
                        return;
                    }
                }

                while (temp!= null && temp.data != value)
                {
                    temp = temp.next;
                }

                if (temp == null) return;
                
                temp.prev.next = temp.next;
                if (temp.next != null)
                {    
                    temp.next.prev = temp.prev;
                }
            }

            public void removeAt (int index)
            {
                if (head == null) return;

                Node temp = head;

                if (index == 0)
                {
                    head = temp.next;
                    if (head != null)
                    {
                        head.prev = null;
                        return;
                    }
                }

                for (int  i = 0; i < index && temp != null; i++)
                {
                    temp = temp.next;
                }

                if (temp == null) return;

                temp.prev.next = temp.next;
                if (temp.next != null)
                {
                    temp.next.prev = temp.prev;
                }
            }

            public void display()
            {
                Node temp = head;
                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.insert(10);
            list.insert(20);
            list.insert(30);
            list.display();

            list.appendAt(5, 0); // Insert at the beginning
            Console.WriteLine(" - - - - - - - - - - - - -");
            list.display();

            list.appendAt(25, 3); // Insert at index 2
            Console.WriteLine(" - - - - - - - - - - - - -");
            list.display();

            list.appendAt(40, 10); // Insert at the end (index out of bounds)
            Console.WriteLine(" - - - - - - - - - - - - -");
            list.display();


            list.remove(40); // Remove a node with value 20
            Console.WriteLine(" - - - - - - - - - - - - -");
            list.display();

            list.removeAt(2); // Remove a node at index 1
            list.removeAt(0); // Remove a node at index 0
            list.removeAt(3); // Remove a node at index out of bounds
            list.removeAt(2); // Remove a node at last index
            Console.WriteLine(" - - - - - - - - - - - - -");
            list.display();
        }
    }
}
