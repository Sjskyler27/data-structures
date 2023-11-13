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
public static class Priority {
    public static void Test() {
        // Create a priority queue
        var priorityQueue = new PriorityQueue();

        // Test 1
        // Scenario: Enqueue items with priorities and check if Dequeue returns them in the correct order
        // Expected Result: Dequeue should return items in descending order of priority
        Console.WriteLine("Test 1");
        priorityQueue.Enqueue("Item A", 3);
        priorityQueue.Enqueue("Item B", 2);
        priorityQueue.Enqueue("Item C", 4);
        priorityQueue.Enqueue("Item D", 1);

        // Dequeue should return "Item C" first (priority 4), then "Item A" (priority 3), "Item B" (priority 2), and finally "Item D" (priority 1).
        Console.WriteLine(priorityQueue.Dequeue()); // Expected: "Item C"
        Console.WriteLine(priorityQueue.Dequeue()); // Expected: "Item A"
        Console.WriteLine(priorityQueue.Dequeue()); // Expected: "Item B"
        Console.WriteLine(priorityQueue.Dequeue()); // Expected: "Item D"

        // Defect(s) Found: None

        Console.WriteLine("---------");

        // Test 2
        // Scenario: Enqueue items with priorities that are the same and check if Dequeue returns them in the correct order
        // Expected Result: Dequeue should return items in descending order of priority
        Console.WriteLine("Test 1");
        priorityQueue.Enqueue("Item A", 3);
        priorityQueue.Enqueue("Item B", 2);
        priorityQueue.Enqueue("Item C", 4);
        priorityQueue.Enqueue("Item D", 1);
        priorityQueue.Enqueue("Item E", 4);
        priorityQueue.Enqueue("Item F", 1);

        // Dequeue should return "Item C" first (priority 4) "Item E" tied for (priority 4) , then "Item A" (priority 3), "Item B" (priority 2), and finally "Item D" (priority 1) "Item F" tied for (priority 1).
        Console.WriteLine(priorityQueue.Dequeue()); // Expected: "Item C"
        Console.WriteLine(priorityQueue.Dequeue()); // Expected: "Item E"
        Console.WriteLine(priorityQueue.Dequeue()); // Expected: "Item A"
        Console.WriteLine(priorityQueue.Dequeue()); // Expected: "Item B"
        Console.WriteLine(priorityQueue.Dequeue()); // Expected: "Item D"
        Console.WriteLine(priorityQueue.Dequeue()); // Expected: "Item F"

        // Defect(s) Found: None

        Console.WriteLine("---------");



        // Test 3
        // Scenario: Try to dequeue from an empty queue
        // Expected Result: An error message should be displayed
        Console.WriteLine("Test 3");
        
        // Try to dequeue when the queue is empty, which should result in an error message.
        Console.WriteLine(priorityQueue.Dequeue()); // Expected: "Queue is empty."

        // Defect(s) Found: None

        Console.WriteLine("---------");
    }
}