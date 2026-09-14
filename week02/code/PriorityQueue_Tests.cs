using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.
// Added actual test cases to the PriorityQueueTests class in the PriorityQueue_Tests.cs file.  
// Run the tests and fix any defects found in the code being tested.  
// Add more test cases as needed to ensure all requirements are met.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("low", 1);
        priorityQueue.Enqueue("medium", 3);
        priorityQueue.Enqueue("highest", 5);

        var result = priorityQueue.Dequeue();

        Assert.AreEqual("highest", result);
    }

    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("first", 5);
        priorityQueue.Enqueue("second", 5);

        var result = priorityQueue.Dequeue();

        Assert.AreEqual("first", result);
    }

    // Add more test cases as needed below.
}