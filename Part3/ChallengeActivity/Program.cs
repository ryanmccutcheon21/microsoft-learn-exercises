// Use the Random class to generate a value.
// Consider the range of numbers that is required.
// Based on the value generated, use the conditional operator to display either heads or tails.
// There should be a 50% chance that the result is either heads or tails.
// Your code should be easy to read, but with as few lines as possible.
// You should be able to accomplish the desired result in three lines of code.

Random coin = new Random();
Console.WriteLine((coin.Next(0, 2) == 0) ? "heads" : "tails");