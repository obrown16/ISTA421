## Oscar Brown
## 4/24/2018
## Read chapter 21, pages 469 – 492 in the C# Step by Step book.

1. What is the difference in the purposes of SQL and LINQ? In other words, why do we need two different
query languages? Does LINQ replace SQL? Does SQL make LINQ unnecesary?
LINQ allows you to interact with unstructured data sitting in your machine.

2. What is the one essential requirement for the datastructures used with LINQ? Why is this requirement
important? LINQ requires the data to be stored in a data structe that implements the IEnumerable or IEnumerable<T> interface, as described in Bhapter 19.


3. Were does the LINQ Select() method live?
In the Enumerable class. Located in System.Linq namespace

4. (Select) Explain, token by token, each token in this line of code:
IEnumerable<string> customerFirstNames = customers.Select(cust => cust.FirstName);
Using the select method to retrieve specific information from the array.

5. (Filter) Explain, token by token, each token in this line of code:
IEnumerable<string> usCompanies = addresses.Where(addr =>
String.Equals(addr.Country, "United States")).Select(usComp => usComp.CompanyName);


6. (OrderBy) Explain, token by token, each token in this line of code:
IEnumerable<string> companyNames = addresses.OrderBy(addr =>
addr.CompanyName).Select(comp => comp.CompanyName);


7. (Group) Explain, token by token, each token in this line of code:
var companiesGroupedByCountry = addresses.GroupBy(addrs => addrs.Country);


8. (Distinct) Explain, token by token, each token in this line of code:
int numberOfCountries = addresses.Select(addr => addr.Country).Distinct().Count();
returns the count of unique countries.

9. (Join) Explain, token by token, each token in this line of code:
var companiesAndCustomers =
customers.Select(c =>
new { c.FirstName, c.LastName, c.CompanyName }).Join(addresses, custs =>
custs.CompanyName, addrs => addrs.CompanyName, (custs, addrs) =>
new {custs.FirstName, custs.LastName, addrs.Country });


10. Explain the difference between a deferred collection and a static, cached collection.
Linq command is in the HEAP 


