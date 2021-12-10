string firstName = "Simon";
string lastName = "Pawlak";
//strings in C# must have ""
//String manipulation
//Concatination
string fullName = firstName + " " + lastName;
System.Console.WriteLine(fullName);

//string composite formatting

string firstWord = "Help";
string secondWord = "Me";
string compositeResult = string.Format("When I get lost coding I simply tell my rubber duck {0} {1}", firstWord, secondWord);
//string.Format has a lot of extra functionality that can be worth digging into

System.Console.WriteLine(compositeResult);
//Additionally can do composite formatting directly in a writeline
System.Console.WriteLine("Somebody {0} {1}", firstWord, secondWord);
//for simple modifications composite formatting is probably the least used but it has a lot more that it can do overall

//Interpolation (Cash Money Curly Bros)
string interpolationResult = $"Hi my name is {firstName} and I need {firstWord}";
System.Console.WriteLine(interpolationResult);

