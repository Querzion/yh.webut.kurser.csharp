using learn_010_presentation.Services;

/// Using different layered architectures in C# with Class libraries
/// Like N-Tier, Domain Driven Design [DDD] etc.
/// 
var url = "https://youtu.be/0BV-uIMSa8k";
Console.WriteLine("Video link: " + url);
Console.WriteLine("This is when we are introduced to use class libraries.");
Console.WriteLine("From here on, this project (week_02/class_libraries/Infrastructure),");
Console.WriteLine("is part of this project and lesson.");
Console.ReadKey();
Console.Clear();

// Files that exist in the project are specifically for this project, the class library projects
// are part of a shared library of files, functions, classes and methods.

// On dependencies, right-click and add project references. This makes it possible to use another projects files.
// It's stated that it's a one-way reference, so if you have multiple references, create a supply chain of the data.

Console.WriteLine("This is the Presentation layer, and it uses the PresentationClassesFolder");
Console.WriteLine("Presentation => Business_"); 
Console.WriteLine("Business_ => Domain_ & Data_"); 
Console.WriteLine("Data_ => none");
Console.WriteLine("Domain_ => Dtos_");
Console.WriteLine("Dtos_ => none");

Console.WriteLine("A project like this is Presentation as MainApp, ClassLibrary as Business or Infrastructure, then Domain & Data, no limit really.");

Console.ReadKey();
Console.Clear();

/// DEPENDENCIES
/// L10_P => PC/Business_ 
/// PC/Business_ => PC/Domain_ & PC/Data_
/// PC/Data_ => none
/// PC/Domain_ => PC/Dtos_
/// PC/Dtos_ => none
/// 

var menuService = new MenuService();
menuService.ShowMenuDialog();