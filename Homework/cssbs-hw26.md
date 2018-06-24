## Oscar Brown
## 4/24/2018
## Read chapter 26, pages 651 – 696 in the C# Step by Step book.

1. Describe the three concerns that the Model-View-ViewModel design pattern addresses.
Graphic artist can focus attention on designing an appealing and intuitive UI. Database specialist can concentrate on implementing an optimized set of data structures for storing and accessing the data. C# developer can direct his efforts toward implementing the business logic for the app

2. Describe in detail how the MVVM design pattern works.
Views use data binding to retrieve and display data managed by the ViewModel. The ViewModel retrieves data from the model and formats it for the views. Views send commands to the ViewModel to perform business operations and update data. The ViewModel sends requests to the model to update data.

3. Describe in detail how data binding works with respect to controls and models.
Data Binding can link a property of a control to a property of an object; if the value of the specified property of the object changes, the property in the control that is linked to the object also changes. Data Binding can be bidirectional, if the value of a property in a control that uses data binding changes, the modification is propagated to the object to which the control is linked.

4. Describe the three methods that the ICommand interface defines. What is the purpose of each method?
The ICommand interface contains the CanExecute which returns a boolean value indicating whether a command can be ran. Execute which runs when the command is invoked. and the CanExecuteChanged method which is triggered when the state of the ViewModel changes.

5. What is a data context? Why do we need a data context? What does it do?
DataContext is the source of all entities mapped over a database connection.