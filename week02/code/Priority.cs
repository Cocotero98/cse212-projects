public static class Priority
{
    public static void Test()
    {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: Create a queue with the following priorities names and numbers: "P1, 1", "P2, 2", "P3, 3" ,"P4, 4"
        // Then dequeue two items.
        // Expected Result: "P1, 1", "P2, 2"
        Console.WriteLine("Test 1");
        priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("P1", 1);
        priorityQueue.Enqueue("P2", 2);
        priorityQueue.Enqueue("P3", 3);
        priorityQueue.Enqueue("P4", 4);
        priorityQueue.Dequeue();
        priorityQueue.Dequeue();
        Console.WriteLine(priorityQueue);


        // Defect(s) Found: 
        // Dequeue not working

        Console.WriteLine("---------");

        // Test 2
        // Scenario: Create a queue with the following priorities names and numbers: "P1, 1", "P2, 2", "P4-1, 4" ,"P4-2, 4", "P5, 5"
        // Then dequeue two items.
        // Expected Result: "P1, 1", "P2, 2", "P4-2, 4"
        Console.WriteLine("Test 2");
        priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("P1", 1);
        priorityQueue.Enqueue("P2", 2);
        priorityQueue.Enqueue("P4-1", 4);
        priorityQueue.Enqueue("P4-2", 4);
        priorityQueue.Enqueue("P5", 5);
        priorityQueue.Dequeue();
        priorityQueue.Dequeue();
        Console.WriteLine(priorityQueue);

        // Defect(s) Found: 
        // // Dequeue not working

        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below

        // Test 3
        // Scenario: Create an empty queue
        // Expected Result: Error message
        Console.WriteLine("Test 3");
        priorityQueue = new PriorityQueue();
        priorityQueue.Dequeue();
        Console.WriteLine(priorityQueue);

        // Defect(s) Found: 

        Console.WriteLine("---------");
    }
}