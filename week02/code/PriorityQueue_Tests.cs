using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Create a queue with the following items and priority: item1(1), item2(2), item3(3), item4(4)
    // and find the highest priority item in the queue.
    // Expected Result: item4
    // Defect(s) Found: 
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("item1", 1);
        priorityQueue.Enqueue("item2", 2);
        priorityQueue.Enqueue("item3", 3);
        priorityQueue.Enqueue("item4", 4);

        var expectedResult = "item4";
        var new_item = priorityQueue.Dequeue();
        
        Assert.AreEqual(expectedResult, new_item);
        
    }

    [TestMethod]
    // Scenario: Create a queue with the following items and priority: item1(3), item2(4), item3(4), item4(2)
    // and find the highest priority item in the queue.
    // Expected Result: item2
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("item1", 3);
        priorityQueue.Enqueue("item2", 4);
        priorityQueue.Enqueue("item3", 4);
        priorityQueue.Enqueue("item4", 2);

        var expectedResult = "item2";
        var new_item = priorityQueue.Dequeue();

        Assert.AreEqual(expectedResult, new_item);
    }
}