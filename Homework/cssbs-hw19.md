## Oscar Brown
## 4/24/2018
## Read chapter 19, pages 423 – 438 in the C# Step by Step book.

1. What is an enumerable collection?
implements the IEnumerable interface.

2. What properties and methods does the IEnumerable interface contain?
Has an IEnumerable is GetEnumerator();

3. What properties and methods does the IEnumerator interface contain?
It has one property and two methods.

4. What values does the MoveNext() method return? What does it do?
Used to move a pointer down to the next (first) item in the list. return a boolean value/ True or false.

5. What values does the Reset() method return? What does it do?
Takes it back to before the first item. Doesn't return any value.

6. Are IEnumerable and IEnumerator type safe? Why or why not? If not, how do you implement type
safety? No, because they do return an object. You implemet type safety by using generic type.


7. Why don’t recursive methods retain state when used with data structures like binary trees?
You have a new stack which doesn't include any data from the new stack.

8. How do you define an enumerator?
create a class that implements the IEnumerable interface. A pointer indicate elements on the list.

9. What is an iterator?
block of code that yields an ordered sequence of values.

10. What does yield do?
 indicates the value that should be returned by each iteration.
