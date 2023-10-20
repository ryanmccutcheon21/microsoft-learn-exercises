// First exercise
// write 'Hello World' to console
Console.WriteLine("Hello World");

// Second exercise
// Comment out first exercise, then write Congratulations! You wrote your first lines of code.
Console.Write("Congratulations!");
Console.Write(" ");
Console.Write("You wrote your first lines of code.");




// Store and Retrieve Data Using Literal and Variable Values in C#

// Use character literals
// If you only wanted a single alphanumeric character printed to screen, you could create a char literal by surrounding one alphanumeric character in single quotes. The term char is short for character. In C#, this data type is officially named "char", but frequently referred to as a "character".

// Add the following line of code in the code editor:
Console.WriteLine('b');

// Observe the code you entered.

// Notice that the letter b is surrounded with single quotation marks 'b'. Single quotes create a character literal. Recall that using double quotation marks creates a string data type.






// Use integer literals
// If you want to display a numeric whole number (no fractions) value in the output console, you can use an int literal. The term int is short for integer, which you may recognize from studying math. In C#, this data type is officially named "int", but frequently referred to as "integer". An int literal requires no other operators like the string or char.

// Add the following line of code in the code editor:
Console.WriteLine(123);





// Use floating-point literals
// A floating-point number is a number that contains a decimal, for example 3.14159. C# supports three data types to represent decimal numbers: float, double, and decimal. Each type supports varying degrees of precision.

// Float Type    Precision
// ----------------------------
// float         ~6-9 digits
// double        ~15-17 digits
// decimal        28-29 digits
Console.WriteLine(0.25F);
// To create a float literal, append the letter F after the number. In this context, the F is called a literal suffix. The literal suffix tells the compiler you wish to work with a value of float type. You can use either a lower-case f or upper-case F as the literal suffix for a float.


Console.WriteLine(2.625);
// To create a double literal, just enter a decimal number. The compiler defaults to a double literal when a decimal number is entered without a literal suffix.


Console.WriteLine(12.39816m);
// To create a decimal literal, append the letter m after the number. In this context, the m is called a literal suffix. The literal suffix tells the compiler you wish to work with a value of decimal type. You can use either a lower-case m or upper-case M as the literal suffix for a decimal.




// Use Boolean literals
// If you wanted to print a value representing either true or false, you could use a bool literal.

// The term bool is short for Boolean. In C#, they're officially referred to as "bool", but often developers use the term "Boolean".

// Add the following lines of code in the code editor:
Console.WriteLine(true);
Console.WriteLine(false);