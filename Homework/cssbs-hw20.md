## Oscar Brown
## 5/1/2018
## Read chapter 20, pages 439 – 466 in the C# Step by Step book.

1. What is a delegate? Explain delegates in terms of pointers and reference types.
Is a reference to a method. 

2. How do you declare a delegate? Include a discussion of types, return values, names, and parameters.
You declare a delegate by using the keyword delegate, the return type, the delegate name, and any parameters followed by semicolon.

3. How do you create instances of delegates and assign values to the instance? What are the values?
have an access modifier, type, and name. It's essentially a method.

4. How do you invoke a method that has been added to a delegate?
use the same syntax you would use to call a method to invoke a delegate.

5. What is an event? Why do we have events?
The event traps significant actions and arranges for a delegate to be called to immdediately handle a situation.

6. How do you declare events?
 same way you declare a field but with the event keyword followed by the delegate type, name, and then the event name. 

7. How do delegates recognize event subscriptions? How do you unsubscribe an event from a delegate?
Register events with a delegate. When event happens the delegate will execute. You register the event by using the += operator. pg 457

8. How do you raise an event? How do you declare code that raises an event?
You can raise an event by calling it like a mehod. 

9. Explain with specificity what happens when an event fires and that event has been attached to a delegate. 
It notifies a delegate and the delegate executes.