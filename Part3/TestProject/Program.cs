// This module contains C# code to learn how to evaluate expressions in Microsoft's Foundational C# course

Console.WriteLine("a" == "a");
Console.WriteLine("a" == "A");
Console.WriteLine(1 == 2);

string myValue = "a";
Console.WriteLine(myValue == "a");

string value1 = " a";
string value2 = "A ";
Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());


// Using the inequality operator
Console.WriteLine("a" != "a");
Console.WriteLine("a" != "A");
Console.WriteLine(1 != 2);

string myValue2 = "a";
Console.WriteLine(myValue2 != "a");


// Using comaprison operators
Console.WriteLine("\n");
Console.WriteLine("\n");
Console.WriteLine("Using comparison operators");

Console.WriteLine(1 > 2);
Console.WriteLine(1 < 2);
Console.WriteLine(1 >= 1);
Console.WriteLine(1 <= 1);


// Methods that return a boolean value
Console.WriteLine("\n");
Console.WriteLine("\n");
Console.WriteLine("Methods that return a boolean value");

string pangram = "The quick brown fox jumped over the lazy dog";
Console.WriteLine(pangram.Contains("fox"));
Console.WriteLine(pangram.Contains("cow"));
// Logical negation
Console.WriteLine(pangram.Contains("fox") == false);
Console.WriteLine(!pangram.Contains("fox"));
Console.WriteLine(!pangram.Contains("fox"));
Console.WriteLine(!pangram.Contains("cow"));



// Implement the conditional operator
int saleAmount = 1001;
// int discount = saleAmount > 1000 ? 100 : 50;
// Console.WriteLine($"Discount: {discount}");

// use conditional operator
Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");