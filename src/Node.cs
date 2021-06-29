namespace ListSortConsoleApp.src
{
    public class Node
    {
        public int data { get; set; } // Data
        public Node next { get; set; } // Next Node

        // Empty Constructor
        public Node() {
            this.next = null;
            this.data = 0;
        }

        // Constructor with a data reference
        public Node(int data) {
            this.next = null;
            this.data = data;
        }

        // Constructor with a next node reference
        public Node(Node next) {
            this.next = next;
            this.data = 0;
        }

        // Constructor with a data and next node refence
        public Node(int data, Node next) {
            this.next = next;
            this.data = data;
        }

        
    }
}