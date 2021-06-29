using System;

namespace ListSortConsoleApp.src {
    /* Singly Linked List */
    class LinkedList {
        public Node head { get; set; } // The head of the Linked List
      
        /* Empty Constructor */
        public LinkedList() { 
            this.head = null;
        }

        /* Constructor with a data reference */
        public LinkedList(int data) {
            this.head = new Node(data);
        }

        /* Constructor with a data and next node reference */
        public LinkedList(int data, Node next) {
            this.head = new Node(data, next);
        }

        /* Prints the Linked List */
        public void printLinkedList() {
            Node curr = this.head;
            while (curr != null) {
                Console.Write(curr.data + " ");
                curr = curr.next;
            }
            Console.Write("\n");
	    }
        
        /* We push a new node to the Linked List */
        public void push(int data) {
            Node node = new Node(data);
            node.next = this.head;
            this.head = node;
        }

        /* Method overload that calls the real Merge Sort function on the head of the current Linked List Instance */
        public void sort() {
            this.head = sort(this.head);
        }

        /* 
            Sorts the Linked List using Merge Sort 
            Merge Sort is a divide and conquer algorithm, so it splits the list in half until 
        */
        public Node sort(Node nodeRef) {
            
            /* If the reference node is null or its next node is null, just return the reference node */
            if (nodeRef == null || nodeRef.next == null) {
                return nodeRef;
            }

            /* We define a current, slowNode and fastNode pointer to be used for the list traversal and set all to the node reference*/
            Node curr = nodeRef;
            Node slowNode = nodeRef;
            Node fastNode = nodeRef;

            /* 
                Traverses the entire list to find the middle node and split the list up.
                The fastNode pointer moves twice as fast as the slowNode pointer.
            */
            while (fastNode != null && fastNode.next != null) {
                curr = slowNode;
                slowNode = slowNode.next;
                fastNode = fastNode.next.next;
            }
            curr.next = null; // Cuts off the current node's next node

            /* Merges the left node (sort at the node reference) and the right node(sort at the slowNode node) */
            return merge(sort(nodeRef), sort(slowNode));
            
        }

        /* Merge Function to be used for merging nodes */
        public Node merge(Node leftNode, Node rightNode) {

            Node temp = new Node();
            Node curr = temp;

            while (leftNode != null && rightNode != null) {
                /* 
                    If leftNode's data is smaller than rightNode's data => Set the current node's next node to leftNode and leftNode to it's next node 
                    If rightNode's data is smaller than leftNode's data => Set the current node's next node to rightNode and rightNode to it's next node
                */
                if (leftNode.data < rightNode.data) {
                    curr.next = leftNode;
                    leftNode = leftNode.next;
                } else {
                    curr.next = rightNode;
                    rightNode = rightNode.next;
                }
                curr = curr.next; // Go to the next node
            }

            /* Repeats the step from above one last time on leftNode */
            if (leftNode != null) {
                curr.next = leftNode;
                leftNode = leftNode.next;
            }

            /* Repeats the step from above one last time on rightNode */
            if (rightNode != null) {
                curr.next = rightNode;
                rightNode = rightNode.next;
            }

            return temp.next; // Returns the merged node
        }

    }
}