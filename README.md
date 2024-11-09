# NascarCalendar
A simple NASCAR calendar app.

Initially I was going to build this application using React, because that's the framework I am
most familiar with. However, I did a little research and saw that Blazor is somewhat similar to
Vue, which I am also familiar with. So I figured I'd take this opportunity to learn Blazor.

I'm sure I didn't follow all the Blazor conventions, but I  like how the application turned out.
I loosly modeled the UI after the NASCAR schedule on the NASCAR website.

The application starts by displaying the 2023 NASCAR Cup Series schedule. Using the top right buttons you can display the schedule for any of the three NASCAR series. There's a drop down to
select any year between 2015 and 2024. Those were the years that are available from the `cf.nascar.com` site.

## Screenshot of the Application
![Application Screenshot](screenshot.png)

## Features of Note
The NASCAR Truck Series logo displays the Camping World logo for the years 2015 to 2022. The Crafsman logo is used for 2023 and later. Same thing goes for the series name display.

The application properly resizes when the browser window width is changed (responsive design).

An error messages is displayed if the json cannot be fetched, or properly parsed, for whatever reason. An error message is also displayed if someone manually enters an incorrect URL path.

Custom 404 page.

The browser tab title updates when the application content changes.

## Helpful Online Tools
I used the [JSON 2 C#](https://json2csharp.com/) website to convert the JSON to a C# model class.

I used the [JSON formatter](https://jsonformatter.org/json-parser) website to help me browse the JSON more easily.

## Running the Project from the Command Line
This project can be run with the dotnet cli.

`dotnet build` builds the applications
`dotnet run` runs the application

Open the application in a browser. The dotnet cli output will tell you the URL to go to.

## Project Development from any Editor
Development can be done with any editor as long as the dotnet cli is present.

`dotnet watch` starts the server and opens the web page in the browser.

## TODO
change SeriesName to SeriesIdentifier in comp and page parameters.





