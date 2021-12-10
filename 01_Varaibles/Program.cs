//makeup of a variable in C#
//1: type
//2: name
//3: assignment operator
//4: value

string firstName = "Charlie";

//instead of console.log() we use Console.WriteLine()
Console.WriteLine(firstName);

firstName = "Bob";

Console.WriteLine(firstName);

//Get user input

//Give the user a prompt
Console.WriteLine("What is your favorite color?");
//Use readline to get their response
string color = Console.ReadLine();

//Print out what they told us
//Concatination:
System.Console.WriteLine("You said your favorite color was: " + color);
