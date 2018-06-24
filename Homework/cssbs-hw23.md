## Oscar Brown
## 5/22/2018
## Read chapter 23, pages 517 – 558 in the C# Step by Step book.

1 List two reasons for multitasking, and explain the rationale for them.
Improve responsiveness and Improve scalability

2 Explain Moore’s law. What does Moore’s law have to do with multitasking?
multitasking ability to attach tran

3 In UWP, what namespace is used as the container for the multitasking methods?
System.Threading.Tasks namespace

4 What is the difference between tasks and threads? Explain.
Task is an abstaction of a concurrent operation/unity of work. Thread a context frame on a precessor to execute.

5 What is the ThreadPool?
The ThreadPool class implements a number of optimization and uses a work-stealing algorithm to ensure that threads are scheduled efficiently.

6 What parameters does the Task() constructor take?
Action delegate as a parameter

7 How do you start a thread?


8 What is the difference between the Start() and Run() methods?


9 What is the difference between creating independent tasks with Tasks and paralleliztion with Parallel? Explain.
When you us task you the programmer decide how to divide the work. Parallelization the compiler divides all the work.

10 Explain how manual cancellation works using a cancellation token.



