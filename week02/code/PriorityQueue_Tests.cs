using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add items with unique priorities and dequeue them.
    // Expected Result: Items are dequeued in order of highest priority.
    // Defect(s) Found: Loop condition and tie-breaking logic needed fixing.
    public void TestPriorityQueue_UniquePriorities()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Item1", 1);
        priorityQueue.Enqueue("Item2", 3);
        priorityQueue.Enqueue("Item3", 2);

        Assert.AreEqual("Item2", priorityQueue.Dequeue());
        Assert.AreEqual("Item3", priorityQueue.Dequeue());
        Assert.AreEqual("Item1", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Add items with duplicate priorities and dequeue them.
    // Expected Result: Items with the same priority are dequeued in FIFO order.
    // Defect(s) Found: Tie-breaking logic needed fixing.
    public void TestPriorityQueue_DuplicatePriorities()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Item1", 3);
        priorityQueue.Enqueue("Item2", 3);
        priorityQueue.Enqueue("Item3", 1);

        Assert.AreEqual("Item1", priorityQueue.Dequeue());
        Assert.AreEqual("Item2", priorityQueue.Dequeue());
        Assert.AreEqual("Item3", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Dequeue from an empty queue.
    // Expected Result: Exception should be thrown.
    // Defect(s) Found: Exception was not thrown correctly.
    public void TestPriorityQueue_EmptyQueue()
    {
        var priorityQueue = new PriorityQueue();

        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Exception should have been thrown.");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
    }
}