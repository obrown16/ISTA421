## Oscar Brown
## 5/22/2018
## Read chapter 24, pages 575 – 600 in the C# Step by Step book.

1. What are the two scenarios in which you can use PLINQ to speed up operations? Why does using PLINQ in these scenarios speed up processing?
Data sets with large numbers of elements or if the criteria specified for matching data involve complex, computationally expensive operations.

2. How does As Parallel qualify as an extension method? First, explain what an extension method is and how you define entension methods, and them explain why AsParallel qualifies as an extension method.
The AsParallel method returns a ParallelQuery object that acts in a similar manner to the original enumerable object.

3. How do you cancel a PLINQ query before it finishes? Be specific with respect to the variables and methods used for the cancellation operation, and how the variables and methods are used.
You specify a CancellationToken object from a CancellationTokenSource and use the WithCancellation ectension method of the ParallelQuery

4. Why is it important to synchronize concurrent access to a server? Give an example of a specific condition that will cause an error in your application if concurrent access is not synchronized.
when you are iterating through a loop and two threads access i. If one thread is moving through the loop and changing i each time and the first thread is moving slow and still accessing the first i, then the next time the slow thread iterates through the loop i might not be correct.

5. What does the lock statement do?
Attempts to obtain a mutual-exclusion lock over the specified object, and it blocks if this same object is currently locked by another thread.

6. This is not in the book. Define mutex, define semaphore, and explain the difference between them.
A mutex provides mutual exclusion, either producer or consumer can have the key (mutex) and proceed with their work. As long as the buffer is filled by producer, the consumer needs to wait, and vice versa.
A semaphore is a generalized mutex. In lieu of single buffer, we can split the 4 KB buffer into four 1 KB buffers (identical resources). A semaphore can be associated with these four buffers. The consumer and producer can work on different buffers at the same time.

7. What does it mean to say that some collection classes are not thread safe? Explain how not being thread safe may lead one of these collection classes to produce a malfunction in the program.
 means it can be changed by one thread in the middle of another threads operation that uses that data.

8. Explain how thread safe collection classes are made thread safe.
9. Why are thread safe classes slower than non-thread safe classes? Be specific.
