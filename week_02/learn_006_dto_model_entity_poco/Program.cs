using learn_006_dto_model_entity_poco.Dtos;

/// POCO - Plain Old CLR (Common Language Runtime) Object (Poco is inspired by Pojo (Plain Old Java Object)) (This is basically the .NET object)
/// DTO - Data Transfer Object
/// MODEL - Is either MVC (Model Views Controller (Non-Graphical))  or MVVM (Model, View, View Model (Graphical (Maui))) 
/// ENTITY - Is a database chart/sheet.
/// 

var url = "https://youtu.be/hk12OinL_H0";
Console.WriteLine("Video Link: " + url);

// ProductDto in this case is a lite record, and what you give it as values, will be it's values, you can't change them afterwards.
// because it's used for transfers and not local changes. ex.
var product = new ProductDto("One", "Two", "Three", 123);

// So you cannot do this with a Dto
//product.ArticleNumber = "123123";

Console.WriteLine(product.ArticleNumber);



Console.ReadKey();