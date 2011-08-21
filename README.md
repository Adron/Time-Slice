
TIME SLICER
=================

This is a set of functionality that provides time parsing of a string representing a time value (like 1:20pm or 10:15am) into actual usable numeric values, methods, or properties. So far I've created a C# and JavaScript Version.

Usage
-----

To get started just download the libraries. Examples for C# and JavaScript are broken out below.

C# Example
----------

Once you've cloned the project open the TimeSliceCsharp directory and open the Solution file. Build the project to create assemblies to include in your project, or simply include the project itself. I've attached no particular key or anything of that sort, it is purely open code.

Once you've add the assembly (or project) you can then create and use the object as shown:

One usage is to instantiate and pass in the time string. The time string is then automatically parsed and a TimePiece object is returned with values for Hour, Minute, Meridian, and MilitaryHour.

In addition to this example below, check out the Test Project within the overall C# Solution to see actual usage.

Instantiating

    TimePiece timePiece = new TimePiece("1:23pm");
    var theHour = timePiece.Hour;
    var theMinute = timePiece.Minute;
    var theMilitaryHour = timePiece.MilitaryHour;

Parsing (which actually creates an instantiated object and returns it.)

    var timePiece = TimePiece.Parse("10:15pm);

JavaScript Example
------------------

Once you've cloned the project explore the TimeSliceJavaScript directory. There you will find a test file with additional examples.

    TimePiece(timeValueOne);
    var theHour = TimePiece.Hour();
    var theMinute = TimePiece.Minute();
    var theMilitaryHour = TimePiece.MilitaryHour();

AUTHOR
------

Adron B. Hall
http://compositecode.com
http://www.adronbhall.com