// See https://aka.ms/new-console-template for more information

//Console.WriteLine("Hello, World!");
using MyConsoleApp1;

String car = "i20";
String company = "Hyundai";
//Double Mileage = 12.5;
Console.WriteLine("Enter your driving kilometers:-");
int kilo = Convert.ToInt32(Console.ReadLine());
double result = kilo * 12.5;
Console.WriteLine("Car name---" + car + "\nCompany name---"+ company);
Console.WriteLine("you will get mileage of: " + result);
