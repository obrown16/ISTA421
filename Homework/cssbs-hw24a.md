## Oscar Brown
## 5/22/2018
## Read chapter 24, pages 559 – 575 in the C# Step by Step book.

1. What is an asynchronous method? When the book talks about a contract, what is the contract and who is it with?
An asynchronous method is one that does not block the current thread on which it starts to run
Asynchronous methods come into the discussion when we are talking about potentially lengthy operations. Typically we need such an operation to complete in order to meaningfully continue program execution, but we don't want to "pause" until the operation completes.


2. What can be the problem with decomposing a series of discrete method calls into a set of tasks, such as we saw in chapter 23?
Although the start method initiates a task, it does not wait for it to complete, so events can occur out of sequence.

3. What can be the problem with decomposing a series of discrete method calls into a set of continuations?
the task object that instigated the continuation is passed as a parameter to a continuation method.

Though the Start method initiates a Task, it does not wait for it to complete, so the message appear while the processing is being performed rather than when it has finished.
When does the last continuation “complete” as compared to the previous continuations? What problem might this cause?


4. What might be the problem with implementing te previous solution as a continuation passing a delegate?
the problem is that the user interface thread can manipulate user interface controls, and now you are attempting to write to a control from a different thread; the thread being used to run the Task.

What would be your interpretation with this error message: “The application called an interface that was marshaled for a different thread.”?


5. The book suggests a solution using a continuation delegate calling another continuation delegate via an anonymous function. What does the book ientify as a problem with this suggested solution?
you will get a System.Exception exception.

6. What does the async modifier do? What does the await operator do?(pg 564)
The purpose of the async and await keywords in C# is to enable you to define and call methods that can run asynchronously. The async modifier indicates that a method contains functionality that can be run asynchronously. The await operator specifies the points at which this asynchronous functionality should be performed.

7. What is an awaitable object? Be specific.
awaitable is a type that provides the GetAwaiter method, which returns an object that in turns provide methods for running code and waiting for it to complete.

8. In a method definition, how do you create and run a Task and return a reference to the Task? What is the type of such a method? What does the method return?
Within the method definition you declare a task object calling the .Run method and return the task object. The method type is Task.

9. How do you define method calls in the implementation of an async method? Specifically, you must define a task, you must run the task, you must implement the task, and you must await the task. What is the syntax for doing this?
use the generic Task class.

10. What is the difference between decomposing a series of method calls that do not return values, and
a series of method calls that return values? What is the Result property of a method that returns a
value? How do you use the await operator in this circumstance?


11. What is the difference between the await operator and the Wait method?



