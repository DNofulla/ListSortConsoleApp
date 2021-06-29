using System;
using ListSortConsoleApp.src;

namespace ListSortConsoleApp {
    class Program {
        static void Main(string[] args) {
            
            // Creating a new Linked List
            LinkedList li = new LinkedList();


            /* Pushing 20 Random Numbers from -10000 to 10000 to the Linked List */
            Random rand = new Random();
            for (int i = 0; i < 20; i++) {
                li.push(rand.Next(-10000, 10000));               
            }

            
            Console.WriteLine("Original List");
            li.printLinkedList();
            li.sort();
            Console.WriteLine("Sorted List");
            li.printLinkedList();
        }
    }
}
