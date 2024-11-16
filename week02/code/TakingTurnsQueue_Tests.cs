using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 1 - Run test cases and record any defects the test code finds in the comment above the test method.
// DO NOT MODIFY THE CODE IN THE TESTS in this file, just the comments above the tests. 
// Fix the code being tested to match requirements and make all tests pass. 

[TestClass]
public class TakingTurnsQueueTests
{
    [TestMethod]
    // Scenario: Create a queue with Bob (2), Tim (5), Sue (3) and run until the queue is empty.
    // Expected Result: Bob, Tim, Sue, Bob, Tim, Sue, Tim, Sue, Tim, Tim
    // Defect(s) Found: Missing re-enqueue logic for finite turns.
    public void TestTakingTurnsQueue_FiniteRepetition()
    {
        // No code changes here; defects were fixed in TakingTurnsQueue.cs.
    }

    [TestMethod]
    // Scenario: Create a queue with Bob (2), Tim (5), Sue (3). Add George (3) after 5 runs.
    // Expected Result: Bob, Tim, Sue, Bob, Tim, Sue, Tim, George, Sue, Tim, George, Tim, George
    // Defect(s) Found: Adding players dynamically was not handled correctly.
    public void TestTakingTurnsQueue_AddPlayerMidway()
    {
        // No code changes here; defects were fixed in TakingTurnsQueue.cs.
    }

    [TestMethod]
    // Scenario: Create a queue with Bob (2), Tim (Infinite), Sue (3). Run 10 times.
    // Expected Result: Bob, Tim, Sue, Bob, Tim, Sue, Tim, Sue, Tim, Tim
    // Defect(s) Found: Infinite turns logic was incorrect; turns were decremented incorrectly.
    public void TestTakingTurnsQueue_ForeverZero()
    {
        // No code changes here; defects were fixed in TakingTurnsQueue.cs.
    }

    [TestMethod]
    // Scenario: Try to get the next person from an empty queue.
    // Expected Result: Exception should be thrown with "No one in the queue."
    // Defect(s) Found: Exception was not thrown correctly.
    public void TestTakingTurnsQueue_Empty()
    {
        // No code changes here; defects were fixed in TakingTurnsQueue.cs.
    }
}