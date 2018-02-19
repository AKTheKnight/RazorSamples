# MySQL

This is a sample app showing how to connect to a MySQL database and read and write data to it

## How to create this

This app was created by running the "dotnet new web" command and then adding Microsoft.AspNet.Razor as a dependency.

### Inside Startup.cs:

- "services.AddMvc()" was added into ConfigureServices.
- "app.UseMvc()" was added into Configure.
  

## Pages

- The home page (Index.cshtml) shows a simple "Hello World" response
- The info page (/info/Index.cshtml) is a more complicated page showing various different features:
    - How layouts can be used to standardize the way pages look
    - It demonstrates how the ViewData dictionary can be used to move data to a Layout and avoid repeating data multiple times
    - How a model can be used to add data to a page (See /info/Index.cshtml.cs)
    
## Extra notes

- Although this project doesn't show it, you can add a "_ViewStart.cshtml" file to add the layout to all pages
