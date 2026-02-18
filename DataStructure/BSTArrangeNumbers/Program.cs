namespace BSTArrangeNumbers
{
    internal class Program
    {
        public class BST
        {
            public class Node
            {
                public int data;
                public Node right;
                public Node left;

                public Node(int value)
                {
                    data = value;
                    right = null;
                    left = null;
                }
            }

            private Node root;

            public BST()
            {
                root = null;
            }

            public void insert(int value)
            {
                root = insertRec(root ,value);
            }

            private Node insertRec(Node current, int value)
            {
                if (current == null)
                    return new Node(value);
                
                if (value < current.data)
                {
                    current.left = insertRec(current.left, value);
                }
                else if (value > current.data)
                {
                    current.right = insertRec(current.right, value);
                }
                return current;
            }

            public void displayInOrder()
            {
                displayInOrderRec(root);
            }

            private void displayInOrderRec(Node current)
            {
                if (current == null) return;

                displayInOrderRec(current.left);
                Console.Write(current.data + " ");
                displayInOrderRec(current.right);
            }
        }

        static void Main(string[] args)
        {
            int[] numbers = {20, 5, 25, 48, 35, 247, 28, 5, 0, -5, -55, 99, -111};
            BST bst = new BST();
            foreach (var number in numbers)
            {
                bst.insert(number);
            }

            Console.WriteLine("Numbers arranged in ascending order using BST:");
            bst.displayInOrder();
        }
    }
}
