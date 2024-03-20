// See https://aka.ms/new-console-template for more information
using DemoApp;


var lion1 = new Person("Olsen", "Fischer");

var lion2 = new Person();
lion2.FirstName = "Olsen";
lion2.LastName = "Fischer";

var lion3 = new Person("Bonface", "NJuguna", 24);


Console.WriteLine($"FirstName: {lion1.FirstName} LastName: {lion1.LastName}");

