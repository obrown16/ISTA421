## Oscar Brown
## 4/24/2018
## Read chapter 25, pages 601 – 650 in the C# Step by Step book.

1. What is the purpose of the Universal Windows Platform? What was the name of the predecessor to UWP?
UWP is an extension of the Windows Runtime. Universal Windows apps that are created using the UWP no longer indicate having been written for a specific OS in their manifest build; instead, they target one or more device families, such as a PC, smartphone, tablet, or Xbox One, using Universal Windows Platform Bridges.

2. Describe in detail how the lifetime of a UWP app differs from a traditional desktop application.
The app suspends execution when the user switches focus to another app and then to resume running when the focus returns.

3. Describe two ways you can set and modify the properties of controls.
use the properties window or typing the equivalent XAML markup into the XAML window.

4. Describe the two layout schemes of UWP apps that we constructed in class.
Tabular and Columnar

5. Describe three ways you can use the Visual State Manager to adapt the layout of UWP apps
You can create several versions of the MainPage.xaml file, one for each device family. You can use the Visual State Manager to modify the layout of the page at runtime. You can use the Visual State Manager to switch between views based on the height and width of the window.

6. Describe how you can modify multiple properties of multiple controls with one document. How do you connect this modification document with your UWP application
You can alter multiple properties of a control in a style sheet by creating a style and linking it to the app.xaml file.

