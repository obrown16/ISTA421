## Oscar Brown
## 5/24/2018
## Chapter 7  ASP.Net MVC 5

1. What is a Visual Studio Solution? How do you create them?
A Visual Studio solution is a container for one or more projects.

Create new solution

2. Why would you use an Empty project instead of a completed template? What are the advantages of an empty project, are there disadvantages with creating a project from a template?

3. What is Nuget? Describe how you use it and why?
A mechanism for sharing code. Defines how packages for .NET are created, hosted, and consumed, and provides the tools for each of those roles.

4. Explain what a Reference is, what is it used for? How you would add or remove one?
Right-click each project in the Solution Explorer window, select Add Reference

5. What is a DI Container? In this book they reference Ninject as the software being used, are there other software products that can be used for DI in Visual Studio?
A technique for achieving loose coupling between objects and their collaborators, or dependencies.

6. What is a domain model and how is it used? What is a view model and how is it used?
Domain models contain the data in a business domain as well as the operations, transformations, and rules for manipulating that data. View Models represent data being transferred between views and controllers.

7. What is meant by the term Repository Pattern? How is it used?
keep a degree of separation between the data model entities and the storage and retrieval logic. It is used to store and retrieve data.

8. What software development strategy is the term Mock Repository referring to? Why would you create a Mock repository?
9. Describe the role played by a Controller in this chapter, what is a View as explained in this chapter?
Controller an action method that can display details of the products in the repository. View displays a list of the details for each product.

10. What is a default route and what purpose does it serve? In what way does having readable Urls impact the website?
Tells the MVC Framework that it should send requests that arrive for the root URL of the application to the List action method.

11. What is ORM? Are we employing this technique? If so how?
An ORM framework presents the tables, columns, and rows of a relational database through regular C# objects.

12. How many ways can you add Database support to your solution? Name at least one way.
not sure.
13. What is a context class? Be specific.
The Context class is the root class for all managed code responses. It is used to access or create most of the other types of objects found in the Microsoft.EnterpriseManagement.Mom.Runtime namespace, such as alerts, events, and performance data.

14. How are optional parameters used within this chapter, give examples.
define the default values for action method parameters

...
public ActionResult CustomVariable(string id = "DefaultId") {
ViewBag.Controller = "Home";
ViewBag.Action = "CustomVariable";
ViewBag.CustomVariable = id;
return View();
}
...
15. What do TDD mean?
Test Driven Development

you use unit tests to help design your code

16. What method is used in TDD to verify the success or failure of the code?
17. What are Html Helpers?
Methods or functions

18. Breakdown this expression:
a. @Html.PageLinks(Model.PagingInfo, x => Url.Action("List", new { page = x }))
b. What does MvcHtmlString represent? How is it used?
19. What is Bootstrap? What is it used for?
A Class

create a panel with a header, just to give structure to the layout

