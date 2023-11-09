/*
 * CSE212 
 * (c) BYU-Idaho
 * 02-Prove - Problem 2
 * 
 * It is a violation of BYU-Idaho Honor Code to post or share this code with others or 
 * to post it online.  Storage into a personal and private repository (e.g. private
 * GitHub repository, unshared Google Drive folder) is acceptable.
 *
 */
public static class Priority
{
    public static void Test()
    {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        // var priorityQueue = new PriorityQueue();
        // Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: The Enqueue function shall add an item (which contains both data and priority) to the back of the queue.
        // Expected Result: [laundry (Pri:4), homework (Pri:1)]
        Console.WriteLine("Test 1");
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("laundry", 4);
        priorityQueue.Enqueue("homework", 1);
        Console.WriteLine(priorityQueue);
        // Defect(s) Found: None!

        Console.WriteLine("---------");

        // Test 2
        // Scenario: The Dequeue function shall remove the item with the highest priority and return its value.
        // Expected Result: homework
        Console.WriteLine("Test 2");
        priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("laundry", 1);
        priorityQueue.Enqueue("pizza", 2);
        priorityQueue.Enqueue("homework", 4);
        var highestPriority = priorityQueue.Dequeue();
        Console.WriteLine(highestPriority);
        // Defect(s) Found: Not returning highest priority item. The loop was excluding the last item in the list.


        Console.WriteLine("---------");

        // Test 3
        // Scenario: If there are more than one item with the highest priority, then the item closest to the front of the queue will be removed and its value returned.
        // Expected Result: party
        Console.WriteLine("Test 3");
        priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("dinner", 4);
        priorityQueue.Enqueue("laundry", 1);
        priorityQueue.Enqueue("party", 5);
        priorityQueue.Enqueue("homework", 4);
        priorityQueue.Enqueue("sleep", 5);
        var highestSharedPriority = priorityQueue.Dequeue();
        Console.WriteLine(highestSharedPriority);
        // Defect(s) Found: Not returning the first highest priority item. The loop was replacing the highest priority index if it was the same priority. We only want to replace it if it is higher.


        Console.WriteLine("---------");

        // Test 4
        // Scenario: If the queue is empty, then an error message will be displayed when trying to get the person from the queue
        // Expected Result: The queue is empty. (Error message for empty queue)
        Console.WriteLine("Test 4");
        priorityQueue = new PriorityQueue();
        priorityQueue.Dequeue();
        // Defect(s) Found: None!



        // Add more Test Cases As Needed Below
    }
}